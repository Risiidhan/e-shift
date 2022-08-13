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
    
    public partial class AdminProfile : Form
    {
    
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");

        public AdminProfile()
        {
            InitializeComponent();
        }
        private void emptyErrorMess()
        {
            //clear error message
            lb_pError.Text = "";
            lb_UnError.Text = "";
            lb_newPass.Text = "";
        }
        private void emptyTextBox()
        {
            // clear textbox value
            txt_username.Text = "";
            txt_password.Text = "";
            txt_newName.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            emptyErrorMess();
            // validation of username and password
            string username = txt_username.Text;
            string password = txt_password.Text;
            string newUsername = txt_newName.Text;

            //validation
            if (username == "" || password == "" || newUsername == "")
            {
                if (username == "")
                {
                    lb_UnError.Text = "Please enter the current Username!";
                }
                if (password == "")
                {
                    lb_pError.Text = "Please enter the Password!";
                }
                if (newUsername == "")
                {
                   lb_newPass.Text = "Please enter the new Username!";
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
                    cmd.CommandText = "select * from Admin where username='" + username + "'";
                    cmd.ExecuteNonQuery();

                    //sucess message
                    if (cmd.ExecuteReader().Read())
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Open();

                        //update admin details
                        cmd.CommandText = "update Admin set username = '" + newUsername + "' , password = '" + password + "' where username ='" + username + "' ";
                        cmd.ExecuteNonQuery();
                        const string message = "Updated Sucessfully";
                        const string caption = "Message";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
        }
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            emptyErrorMess();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            emptyTextBox();
        }

        private void link_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin AdL = new AdminLogin();
            AdL.Show();
            this.Hide();
        }
    }
}
