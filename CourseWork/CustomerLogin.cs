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
    public partial class CustomerLogin : Form
    {
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");

        public CustomerLogin()
        {
            InitializeComponent();
        }

        public static string SetValueForUser = "";

        private void link_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void link_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.Show();
            this.Hide();
        }
        private void emptyErrorMess()
        {
            lb_pError.Text = "";
            lb_UnError.Text = "";

        }
        private void emptyTextBox()
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            emptyErrorMess();
            pb_showPassword.Image = CourseWork.Properties.Resources.hidePassword;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
       
                emptyErrorMess();
                // validation of username and password
                string username = txt_username.Text;
                string password = txt_password.Text;

                if (username == "" || password == "")
                {
                    if (username == "")
                    {
                        lb_UnError.Text = "Please enter the Username!";
                    }
                    if (password == "")
                    {
                        lb_pError.Text = "Please enter the Password!";
                    }
                }

                else
                {
                try
                {
                    //open and close connection
                    //Check if entered username and password are correct
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Customer where username='" +username+ "' and password='" +password+ "'";
                    cmd.ExecuteNonQuery();

                    //sucess message
                    if (cmd.ExecuteReader().Read())
                    {
                        const string message = "Login succeed";
                        const string caption = "Message";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // set username here
                        SetValueForUser = username;

                        CustomerDashbard customerDashbard = new CustomerDashbard();
                        customerDashbard.Show();
                        this.Hide();
                    }
                    //error message
                    else
                    {
                        const string message = "Incorrect Username or Password, Please register before login";
                        const string caption = "Message";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    con.Close();
                   
                }
                        catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

        }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            emptyTextBox();
        }

        private void pb_showPassword_Click(object sender, EventArgs e)
        {
            if(txt_password.PasswordChar == '●')
            { 
                txt_password.PasswordChar = '\0';
                pb_showPassword.Image= CourseWork.Properties.Resources.showPassword;
            }
            else
            {
                txt_password.PasswordChar = '●';
                pb_showPassword.Image = CourseWork.Properties.Resources.hidePassword;
            }
        }
    }
}
