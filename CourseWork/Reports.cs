using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class Reports : Form
    {
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            // get title from variable declared in admin dashborad

            lb_reportTitle.Text = AdminDashboard.SetValueForText;
            string title = lb_reportTitle.Text;
            try
            {
                //check for the title and generate the command according to title
                if (title == "Accepted Oders for last 30 days")
                {
                    lb_reportTitle.Text = title;
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();

                    // select and combine records from job, order_wise and transport table to generate report
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"select distinct Jobs.job_id,OrderItemWise.customer_name, 
                                        Jobs.unique_load_code, Jobs.products, Transport.description, Transport.lorry_No, 
                                        Transport.container_No, OrderItemWise.current_location, OrderItemWise.destination, 
                                        Load.date from Load join OrderItemWise on Load.order_id=OrderItemWise.ow_id 
                                        join Transport on Load.trans_id = Transport.trans_id join Jobs on Load.load_id = Jobs.load_id 
                                        where datediff(day,Load.date,getdate())<31";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                }

                //check for the title and generate the command according to title

                if (title == "Declined Oders")
                {
                    lb_reportTitle.Text = title;

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    // select and combine records of declined orders from orders and order_wise to generate report

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Orders.order_id, OrderItemWise.customer_name, OrderItemWise.product_name, OrderItemWise.quantity, Orders.status from Orders inner join OrderItemWise on Orders.ow_id=OrderItemWise.ow_id where Orders.status='Declined'";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                //check for the title and generate the command according to title

                if (title == "All Oders") 
                {
                    lb_reportTitle.Text = title;

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    // select and combine records of all orders from orders and order_wise to generate report

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Orders.order_id, OrderItemWise.customer_name, OrderItemWise.product_name, OrderItemWise.quantity, Orders.status from Orders inner join OrderItemWise on Orders.ow_id=OrderItemWise.ow_id";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lb_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
