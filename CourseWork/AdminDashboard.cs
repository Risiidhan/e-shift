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
    public partial class AdminDashboard : Form
    {
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");

        public static string SetValueForText = "";

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void loadOrderDetails()
        {
            //assign variables
            string accepted = lb_accepted.Text;
            string pending = lb_pending.Text;
            string total = lb_totalOrder.Text;

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            try 
            { 

                //check total orders except declined orders
                SqlCommand Com = new SqlCommand("select count(*) from Orders where status <> 'Declined'", con);
                SqlDataReader DR1 = Com.ExecuteReader();
                if (DR1.Read())
                {
                    lb_totalOrder.Text = DR1.GetValue(0).ToString();
                }
                else
                {
                    lb_totalOrder.Text = "0";

                }

                // check pending order
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                DR1.Close();
                SqlCommand Com1 = new SqlCommand("select COUNT(*) from Orders where status= 'Pending'", con);
                SqlDataReader DR2 = Com1.ExecuteReader();
                if (DR2.Read())
                {
                    lb_pending.Text = DR2.GetValue(0).ToString();
                }
                else
                {
                    lb_pending.Text= "0";

                }

                //check accpete orders 

                DR2.Close();
                SqlCommand Com2 = new SqlCommand("select COUNT(*) from Orders where status= 'Accepted'",con);
                SqlDataReader DR3 = Com2.ExecuteReader();
                if (DR3.Read())
                {
                    lb_accepted.Text = DR3.GetValue(0).ToString();
                }
                else
                {
                    lb_accepted.Text = "0";

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void lb_profile_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile();
            adminProfile.Show();
            this.Hide();
        }

        private void lb_products_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            loadOrderDetails();
        }

        private void lb_pending_Click(object sender, EventArgs e)
        {

            PendingOrder pendingOrder = new PendingOrder();
            pendingOrder.Show();
            this.Hide();
        }

        private void lb_viewOrders_Click(object sender, EventArgs e)
        {
            //set variable value to pass to reports forms
            SetValueForText = "All Oders";
            Reports reports = new Reports();
            reports.Show();
            this.Hide();

        }

        private void lb_declinedOrders_Click(object sender, EventArgs e)
        {
            //set variable value to pass to reports forms

            SetValueForText = "Declined Oders";
            Reports reports = new Reports();
            reports.Show();
            this.Hide();

        }

        private void lb_accpetedOrders_Click(object sender, EventArgs e)
        {
            //set variable value to pass to reports forms

            SetValueForText = "Accepted Oders for last 30 days";
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void lb_accepted_Click(object sender, EventArgs e)
        {
            //set variable value to pass to reports forms

            SetValueForText = "Accepted Oders for last 30 days";
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void lb_totalOrder_Click(object sender, EventArgs e)
        {
            //set variable value to pass to reports forms

            SetValueForText = "All Oders";
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void lb_transport_Click(object sender, EventArgs e)
        {
            //navigate to transport form
            Transport transport = new Transport();  
            transport.Show();
            this.Hide();
        }

        private void lb_logout_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();    
            login.Show();
            this.Hide();
        }
    }
}
