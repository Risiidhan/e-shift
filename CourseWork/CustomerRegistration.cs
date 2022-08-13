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
    public partial class CustomerRegistration : Form
    {
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");
        public CustomerRegistration()
        {
            InitializeComponent();
        }



        private void emptyErrorMess()
        {
            //clear error message
            lb_pError.Text = "";
            lb_UnError.Text = "";
            lb_conPError.Text = "";
            lb_contError.Text = "";

        }
        private void emptyTextBox()
        {
            //clear textbox value
            txt_username.Text = "";
            txt_password.Text = "";
            txt_conPass.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            emptyErrorMess();
            // validation of username and password
            string username = txt_username.Text;
            string password = txt_password.Text;
            string conPassword = txt_conPass.Text;
            string address = txt_address.Text;
            string contactNo = txt_contact.Text;

            if (username == "" || password == "" || conPassword == "" || contactNo == "")
            {
                if (username == "")
                {
                    lb_UnError.Text = "Please enter the Username!";
                }
                if (password == "")
                {
                    lb_pError.Text = "Please enter the Password!";
                }
                if (conPassword == "")
                {
                    lb_conPError.Text = "Please enter the Confirm Password!";
                }
                if (contactNo == "")
                {
                    lb_contError.Text = "Please enter the Contact number!";
                }
            }
            else
            {
                int contact = int.Parse(txt_contact.Text);

                //check if passwords are matching
                if (password != conPassword)
                {
                    const string message = "Password and Confrim Password are not the same";
                    const string caption = "Message";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    emptyTextBox();
                }
                else
                {
                    try
                    {
                        //check if username already exists
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from Customer where username='" + username + "'";
                    

                        //error message
                        if (cmd.ExecuteReader().Read())
                        {
                            const string message = "username already exists";
                            const string caption = "Message";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            emptyTextBox();
                            con.Close();
                        }
                        //insert and success message
                        else
                        {
                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }
                            con.Open();
                            cmd.CommandText = "insert into Customer (username,password,address,contact) values ('" + username + "' , '" + password + "', '" + address + "', '" + contact + "')";
                            cmd.ExecuteNonQuery();
                            const string message = "registered Sucessfully";
                            const string caption = "Message";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            CustomerLogin CusL = new CustomerLogin();
                            CusL.Show();
                            this.Hide();
                        }
                        con.Close();
                    }
                        catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
            }
            }
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            emptyErrorMess();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CustomerLogin CusL = new CustomerLogin();
            CusL.Show();
            this.Hide();
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow user to onl type number and allow backspace
            e.Handled = !char.IsDigit(e.KeyChar);
            if (e.KeyChar == '\b')
            {
                e.Handled = char.IsDigit(e.KeyChar);
            }
        }
    }
}
