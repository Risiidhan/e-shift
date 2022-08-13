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

    public partial class customerProfile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");

        public customerProfile()
        {
            InitializeComponent();
        }

        private void emptyErrorMess()
        {
            //clear error message
            lb_addError.Text = "";
            lb_contError.Text = "";
            lb_newPass.Text = "";
            lb_CurreUnError.Text = "";
        }
        private void emptyTextBox()
        {
            // clear textbox value
            txt_address.Text = "";
            txt_password.Text = "";
            txt_contact.Text = "";
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            emptyErrorMess();
            // validation of username and password
            string address = txt_address.Text;
            string contacts = txt_contact.Text;
            string password = txt_password.Text;

            //validation
            if (address == "" || contacts == "" || password == "")
            {
       
                if (password == "")
                {
                    lb_newPass.Text = "Please enter the Password!";
                }
                if (contacts == "")
                {
                    lb_contError.Text = "Please enter the contact number!";
                }
                if (address == "")
                {
                    lb_addError.Text = "Please enter the address!";
                }
            }
            else
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                int contact = int.Parse(contacts);

                //update admin details
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Customer set password = '" + password + "', address = '" + address + "', contact = '" + contact + "' where username ='" + txt_CurrentUsername.Text + "' ";
                cmd.ExecuteNonQuery();
                const string message = "Updated Sucessfully";
                const string caption = "Message";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                con.Close();
                
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            emptyTextBox();
            emptyErrorMess();
        }

        private void customerProfile_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            txt_CurrentUsername.Text = CustomerLogin.SetValueForUser;
            txt_CurrentUsername.Enabled=false;
            emptyErrorMess();
        }

        private void link_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerDashbard customerDashbard = new CustomerDashbard();
            customerDashbard.Show();
            this.Hide();
        }
    }
}
