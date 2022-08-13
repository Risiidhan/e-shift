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
    public partial class PendingOrder : Form
    {
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");
        public PendingOrder()
        {
            InitializeComponent();
        }

        public static string orderNumber = "";


        private void PendingOrder_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            try
            {              
                fillCombo();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(cmb_orderNo.Text != "")
            {
                viewData();
            }
        }

        private void fillCombo()
        {
            //fill values to comboox from database

            try
            {
                
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                //select pending orders ids

                SqlDataAdapter da = new SqlDataAdapter("SELECT distinct ow_id FROM Orders WHERE status = '" + "Pending" + "'", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_orderNo.DataSource = dt;
                cmb_orderNo.DisplayMember = "ow_id";
                cmb_orderNo.ValueMember = "ow_id";
                cmb_orderNo.ResetText();
                cmb_orderNo.Text = "";
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void viewData()
        {
            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                // select all records from databse according to  order id

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM OrderItemWise WHERE ow_id = '" + cmb_orderNo.Text + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




   

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (cmb_orderNo.Text != "")
            {
                viewData();
            }
        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
            try
            {
                //confrimation from user
                int orderNo = int.Parse(cmb_orderNo.Text);
                const string message = "Are You Sure to Decline the Order";
                const string caption = "Message";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();

                    // change order status to declined

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Orders set status = '" + "Declined" + "' where ow_id ='" + orderNo + "'";
                    cmd.ExecuteNonQuery();

                    const string message1 = "Order Declined";

                    var result1 = MessageBox.Show(message1, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fillCombo();
                    viewData();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if(cmb_orderNo.Text != "")
            {
                orderNumber = cmb_orderNo.Text;
                Loads loads = new Loads();
                loads.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select the Order Number");
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
