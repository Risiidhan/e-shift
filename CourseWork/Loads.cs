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
    public partial class Loads : Form
    {
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");

        public Loads()
        {
            InitializeComponent();
        }

        int orderNo = int.Parse(PendingOrder.orderNumber);


        //view order products in datagridView


        private void Loads_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            //make all labels empty when app loads
            lb_contNo.Text = "";
            lb_driver.Text = "";
            lb_lorryNo.Text = "";
            lb_titleCont.Text = "";
            lb_titleDriver.Text = "";
            lb_titleLorry.Text = "";
            lb_asisstTitle.Text = "";
            lb_asisstant.Text = "";

            try
            {
                //get the new order ID
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlCommand Comm1 = new SqlCommand("select MAX(job_id) from Jobs", con);
                con.Open();
                SqlDataReader DR1 = Comm1.ExecuteReader();
                if (DR1.Read())
                {
                    string Job = DR1.GetValue(0).ToString();
                    if (Job != "")
                    {
                        int jobID = int.Parse(Job);
                        jobID = jobID + 1;

                        txt_jobID.Text = jobID.ToString();
                    }
                    else
                    {
                        txt_jobID.Text = "1";
                    }

                }
                con.Close();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT product_name + ' x ' + CONVERT(varchar(10), quantity) as items FROM OrderItemWise where ow_id='" + orderNo + "'", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_products.DataSource = dt;
                cmb_products.ValueMember = "items";
                cmb_products.DisplayMember = "items";
                cmb_products.ResetText();
                con.Close();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                SqlDataAdapter da2 = new SqlDataAdapter("SELECT distinct description FROM Transport", con);

                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cmb_transUnit.DataSource = dt2;
                cmb_transUnit.ValueMember = "description";
                cmb_transUnit.DisplayMember = "description";
                cmb_transUnit.ResetText();
                con.Close();

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        int buttonPressed = 0;


        private void btn_createJob_Click(object sender, EventArgs e)
        {
            createJob();
        }

        private void createJob()
        {
            //validation
            if (cmb_transUnit.Text != "" || txt_loadItems.Text != "")
            {
                DateTime date = DateTime.Now;

                int transId;

                int jobId = int.Parse(txt_jobID.Text);
                string items = txt_loadItems.Text;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                try
                {

                    //select transport id from description selected in combobox
                    SqlCommand Com4 = new SqlCommand("select trans_id from Transport where description = '" + cmb_transUnit.Text + "'", con);
                    SqlDataReader DR4 = Com4.ExecuteReader();
                    if (DR4.Read())
                    {

                        //if validte, add order to load
                        if (buttonPressed == 0)
                        {
                            transId = DR4.GetInt32(0);
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into Load (trans_id,order_id,date) values ('" + transId + "' , '" + orderNo + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                            DR4.Close();
                            cmd.ExecuteNonQuery();

                        }
                        buttonPressed = 1;
                        DR4.Close();


                        //update status to accepted

                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "update Orders set status = '" + "Accepted" + "' where ow_id ='" + orderNo + "' ";


                        // select the load id with the respective order number
                        SqlCommand Com = new SqlCommand("select load_id from Load where order_id = '" + orderNo + "'", con);
                        SqlDataReader DR = Com.ExecuteReader();


                        if (DR.Read())
                        {
                            //insert into jobs
                            int loadId = DR.GetInt32(0);

                            SqlCommand cmd3 = con.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "insert into Jobs (job_id,load_id, products) values ('" + jobId + "', '" + loadId + "' , '" + items + "')";


                            const string message = "Added to Job Sucessfully";
                            const string caption = "Message";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            DR.Close();
                            cmd2.ExecuteNonQuery();
                            cmd3.ExecuteNonQuery();


                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }
                            con.Open();

                            // select all records from databse according to  order id

                            SqlCommand cmd4 = con.CreateCommand();
                            cmd4.CommandType = CommandType.Text;
                            cmd4.CommandText = "SELECT * FROM Jobs WHERE job_id = '" + jobId + "'";
                            cmd4.ExecuteNonQuery();

                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd4);
                            da.Fill(dt);
                            dataGridView2.DataSource = dt;
                            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                            txt_loadItems.Text = "";
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select the transport unit and load Iteams");
            }
        }

        private void cmb_transUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_transUnit.Text != "")
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();

                    //select lorry name
                    SqlCommand Com = new SqlCommand("select lorry_No from Transport where description = '" + cmb_transUnit.Text + "'", con);
                    SqlDataReader DR1 = Com.ExecuteReader();
                    if (DR1.Read())
                    {
                        lb_titleLorry.Text = "Lorry Name";
                        lb_lorryNo.Text = DR1.GetValue(0).ToString();
                    }


                    //select driver name
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    DR1.Close();
                    SqlCommand Com2 = new SqlCommand("select driver from Transport where description = '" + cmb_transUnit.Text + "'", con);
                    SqlDataReader DR2 = Com2.ExecuteReader();
                    if (DR2.Read())
                    {
                        lb_titleDriver.Text = "Driver";
                        lb_driver.Text = DR2.GetValue(0).ToString();
                    }

                    //select container name
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    DR2.Close();
                    SqlCommand Com3 = new SqlCommand("select container_no from Transport where description = '" + cmb_transUnit.Text + "'", con);
                    SqlDataReader DR3 = Com3.ExecuteReader();
                    if (DR3.Read())
                    {
                        lb_titleCont.Text = "Container No";
                        lb_contNo.Text = DR3.GetValue(0).ToString();

                    }

                    //select asisstant No
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    DR2.Close();
                    SqlCommand Com4 = new SqlCommand("select asisstant from Transport where description = '" + cmb_transUnit.Text + "'", con);
                    SqlDataReader DR4 = Com4.ExecuteReader();
                    if (DR4.Read())
                    {
                        lb_asisstTitle.Text = "Asisstant No";
                        lb_asisstant.Text = DR4.GetValue(0).ToString();

                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            createLoad();
        }

        private void createLoad()
        {
            if (txt_loadItems.Text == "")
            {
                txt_loadItems.Text = cmb_products.Text;
            }
            else
            {
                if (txt_loadItems.Text.Contains(cmb_products.Text))
                {
                    MessageBox.Show("Product already added");
                }
                else
                {

                    txt_loadItems.Text = txt_loadItems.Text + ", " + cmb_products.Text;
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_loadItems.Text = "";
        }

        private void lb_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PendingOrder pendingOrder = new PendingOrder();
            pendingOrder.Show();
            this.Hide();
        }
    }
}
