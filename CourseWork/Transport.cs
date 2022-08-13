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
    public partial class Transport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");

        public Transport()
        {
            InitializeComponent();
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            emptyErrorMess();
        }

        private void emptyErrorMess()
        {
            //clear error message

            lb_asissNoError.Text = "";
            lb_contNoError.Text = "";
            lb_desError.Text = "";
            lb_idError.Text = "";
            lb_lorryNoError.Text = "";
            lb_driverError.Text = "";

        }
        private void viewData()
        {
            // to view all records from table
            try 
            { 
                emptyErrorMess();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Transport";
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

        private void btn_view_Click(object sender, EventArgs e)
        {
            viewData();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            //validation
            emptyErrorMess();
            int id;
            String pid = txt_ID.Text;


            if (pid == "")
            {
                lb_guide.Text = "";
                lb_idError.Text = "Please enter the Product ID";
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    id = int.Parse(txt_ID.Text);

                    //select command 
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Transport where trans_id ='" + id + "' ";
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
        }

        private void deleteTransport()
        {
            try
            {
                // clear error messages and validation
                emptyErrorMess();
                int id;
                String Tid = txt_ID.Text;

                if (Tid == "")
                {
                    lb_guide.Text = "";
                    lb_idError.Text = "Please enter the Product ID";
                }
                else
                {
                    //confirm if user wants to delete
                    const string message = "Are You Sure to Delete the Transport Unit";
                    const string caption = "Message";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Open();
                        id = int.Parse(txt_ID.Text);

                        // delete transport unit
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Transport where trans_id ='" + id + "' ";
                        cmd.ExecuteNonQuery();

                        const string newmessage = "Deleted Sucessfully";
                        const string newcaption = "Message";
                        var newresult = MessageBox.Show(newmessage, newcaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        viewData();
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateTransport()
        {
            try
            {
                // empty error message and validation
                emptyErrorMess();
                string description = txt_description.Text;
                string lorry = txt_lorry.Text;
                string container = txt_container.Text;
                string asisstants = txt_asissNo.Text;
                string driver = txt_driver.Text;
                int id;
                String Tid = txt_ID.Text;

                if (Tid == "" || description == "" || lorry == "" || container == "" || asisstants == "" || driver == "")
                {
                    if (description == "")
                    {
                        lb_desError.Text = "Please enter the type!";
                    }
                    if (lorry == "")
                    {
                        lb_lorryNoError.Text = "Please enter the Number!";
                    }
                    if (container == "")
                    {
                        lb_contNoError.Text = "Please enter the Number!";
                    }
                    if (asisstants == "")
                    {
                        lb_asissNoError.Text = "Please enter the Number!";
                    }

                    if (Tid == "")
                    {
                        lb_idError.Text = "Please enter the Transport ID";
                    }
                    if (driver == "")
                    {
                        lb_driverError.Text = "Please enter the driver name";
                    }


                }
                else
                {
                    //confirm message before update
                    const string message = "Are You Sure to Update the Transport Unit";
                    const string caption = "Message";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Open();
                        id = int.Parse(txt_ID.Text);

                        //update the transport Unit
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Transport set description = '" + description + "' , lorry_No = '" + lorry + "', container_No = '" + container + "', asisstant = '" + asisstants + "', driver = '" + driver + "' where trans_id ='" + id + "' ";
                        cmd.ExecuteNonQuery();

                        const string newmessage = "Updated Sucessfully";
                        const string newcaption = "Message";
                        var newresult = MessageBox.Show(newmessage, newcaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        viewData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addTransport()
        {
            emptyErrorMess();
            string description = txt_description.Text;
            string lorry = txt_lorry.Text;
            string container = txt_container.Text;
            string asisstants = txt_asissNo.Text;
            string driver = txt_driver.Text;


            //validate if all fields are filled
            if (description == "" || lorry == "" || container == "" || asisstants == "" || driver == "")
            {
                if (description == "")
                {
                    lb_desError.Text = "Please enter the type!";
                }
                if (lorry == "")
                {
                    lb_lorryNoError.Text = "Please enter the Number!";
                }
                if (container == "")
                {
                    lb_contNoError.Text = "Please enter the Number!";
                }
                if (asisstants == "")
                {
                    lb_asissNoError.Text = "Please enter the Number!";
                }

                if (driver == "")
                {
                    lb_driverError.Text = "Please enter the driver name";
                }


            }

            else
            {
                try
                {

                    //check if product already exists

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Transport where description='" + txt_description.Text + "'";


                    //error message
                    if (cmd.ExecuteReader().Read())
                    {
                        const string message = "Trnsport Unit already exists";
                        const string caption = "Message";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        con.Close();
                    }
                    //insert and success 
                    else
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Open();

                        cmd.CommandText = "insert into Transport (description,lorry_No, driver, container_No, asisstant) values ('" + description + "' , '" + lorry + "', '" + driver + "', '" + container + "', '" + asisstants + "')";
                        cmd.ExecuteNonQuery();
                        const string message = "Inserted Sucessfully";
                        const string caption = "Message";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    con.Close();
                    viewData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteTransport();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateTransport();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
           addTransport();
        }

        private void btn_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();

        }
    }
}
