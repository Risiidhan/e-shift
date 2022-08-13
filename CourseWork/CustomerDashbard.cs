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
    public partial class CustomerDashbard : Form

    {
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");

        public CustomerDashbard()
        {
            InitializeComponent();
        }

 

        private void CustomerDashbard_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            // get customer name from variable passed from login form
            lb_username.Text = CustomerLogin.SetValueForUser;
            lb_user.Text = CustomerLogin.SetValueForUser;
            lb_orderStatus.Text = "None";
            lb_viewOrder.Text = "";
            string orderNo = cmb_orderNo.Text;

            try
            {

                //select orders from user
                SqlCommand Comm = new SqlCommand("SELECT distinct ow_id FROM OrderItemWise WHERE customer_name = '" + lb_username.Text + "'", con);
                con.Open();
                SqlDataReader DR1 = Comm.ExecuteReader();
                if (DR1.Read())
                {
                    DR1.Close();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT distinct ow_id FROM OrderItemWise WHERE customer_name = '" + lb_username.Text + "'", con);

                    //fill combo box
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmb_orderNo.DataSource = dt;
                    cmb_orderNo.DisplayMember = "ow_id";
                    cmb_orderNo.ValueMember = "ow_id";
                    cmb_orderNo.ResetText();
                    cmb_orderNo.Text = "";
                }
                con.Close();


                // select total orders made by the user
                SqlCommand Comm1 = new SqlCommand("SELECT COUNT(*) from (select distinct Orders.order_id, OrderItemWise.customer_name, Orders.status from Orders inner join OrderItemWise on Orders.ow_id=OrderItemWise.ow_id where OrderItemWise.customer_name='" + lb_username.Text + "')t", con);
                con.Open();
                SqlDataReader DR2 = Comm1.ExecuteReader();
                if (DR2.Read())
                { 
                    lb_ordersNo.Text = DR2.GetValue(0).ToString();
                }
                con.Close();


                //select accepted orders of that user
                SqlCommand Comm2 = new SqlCommand("SELECT COUNT(*) from (select distinct Orders.order_id, OrderItemWise.customer_name, Orders.status from Orders inner join OrderItemWise on Orders.ow_id=OrderItemWise.ow_id where OrderItemWise.customer_name='" + lb_username.Text + "' and Orders.status='accepted')t;", con);
                con.Open();
                SqlDataReader DR3 = Comm2.ExecuteReader();
                if (DR3.Read())
                {
                    lb_accOrderNo.Text = DR3.GetValue(0).ToString();
                }
                con.Close();

                //select pending orders of that user
                SqlCommand Comm3 = new SqlCommand("SELECT COUNT(*) from (select distinct Orders.order_id, OrderItemWise.customer_name, Orders.status from Orders inner join OrderItemWise on Orders.ow_id=OrderItemWise.ow_id where OrderItemWise.customer_name='" + lb_username.Text + "' and Orders.status='pending')t;", con);
                con.Open();
                SqlDataReader DR4 = Comm3.ExecuteReader();
                if (DR4.Read())
                {
                    lb_pendingOrders.Text = DR4.GetValue(0).ToString();
                }
                con.Close();


                //select declined orders of that user
                SqlCommand Comm4 = new SqlCommand("SELECT COUNT(*) from (select distinct Orders.order_id, OrderItemWise.customer_name, Orders.status from Orders inner join OrderItemWise on Orders.ow_id=OrderItemWise.ow_id where OrderItemWise.customer_name='" + lb_username.Text + "' and Orders.status='declined')t;", con);
                con.Open();
                SqlDataReader DR5 = Comm4.ExecuteReader();
                if (DR5.Read())
                {
                    lb_declinedOrders.Text = DR5.GetValue(0).ToString();
                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
  
        private void loadOrderDetails()
        {
            string orderNo = cmb_orderNo.Text;

            //validate
            if (orderNo != "")
            {
                try
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    //display the order of customer with specified id
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select product_name, quantity from OrderItemWise where ow_id = '" + cmb_orderNo.Text + "'";
                    cmd.ExecuteNonQuery();

                    //fill data in datagridview
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;


                    //show current status of the order
                    SqlCommand Comm2 = new SqlCommand("SELECT status FROM Orders WHERE ow_id = '" + orderNo + "';", con);

                    SqlDataReader DR1 = Comm2.ExecuteReader();
                    if (DR1.Read())
                    {
                        lb_orderStatus.Text = DR1.GetValue(0).ToString();
                    }
                    con.Close();

                    lb_viewOrder.Text = "View Your Order Details Here";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

        }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loadOrderDetails();
        }

    

        private void lb_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void lb_statusTitle_Click(object sender, EventArgs e)
        {
            panel_dashboard.Hide();
        }

        private void lb_dashboard_Click(object sender, EventArgs e)
        {
            panel_dashboard.Show();
        }

        private void lb_makeOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }

        private void lb_logout_Click(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
            this.Hide();
        }

        private void lb_profile_Click(object sender, EventArgs e)
        {
            customerProfile cusP = new customerProfile();
            cusP.Show();
            this.Hide();
        }
    }
}
