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
using System.IO;
using System.Drawing.Imaging;
using System.Data.Linq;

namespace CourseWork
{
    public partial class Product : Form
    {
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");


        public Product()
        {
            InitializeComponent();
        }


        string imageLocation = "";


        private void emptyErrorMess()
        {
            // empty error message
            lb_pError.Text = "";
            lb_UnError.Text = "";
            lb_idError.Text = "";
            lb_guide.Text = "";
        }
        private void emptyTextBox()
        {
            //empty textbox
            txt_name.Text = "";
            txt_peoNo.Text = "";
            txt_ID.Text = "";
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            addProduct();

        }

        private void addProduct()
        {
            emptyErrorMess();

            // validation of name and number
            string productName = txt_name.Text;
            string peopleNo = txt_peoNo.Text;


            if (productName == "" || peopleNo == "" || pb_image.Image == null)
            {
                if (productName == "")
                {
                    lb_UnError.Text = "Please enter the Product Name!";
                }
                if (peopleNo == "")
                {
                    lb_pError.Text = "Please enter the Number!";
                }
                if (pb_image.Image == null)
                {
                    MessageBox.Show("Please select an Image");
                }
            }

            else
            {
                try
                {
                    byte[] img = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    img = brs.ReadBytes((int)stream.Length);


                    int pNo = int.Parse(txt_peoNo.Text);

                    //check if product already exists


                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Product where product_name='" + productName + "'";



                    //error message
                    if (cmd.ExecuteReader().Read())
                    {
                        const string message = "Product already exists";
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

                        //insert command

                        string query = "insert into Product (product_name,no_of_people,image) values ('" + productName + "' , '" + peopleNo + "', @img)";

                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = query;
                        cmd1.Parameters.Add("@img", SqlDbType.Image);
                        cmd1.Parameters[0].Value = img;


                        cmd1.ExecuteNonQuery();
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

        private void deleteProduct()
        {
            emptyErrorMess();
            int id;
            String pid = txt_ID.Text;

            //validation

            if (pid == "")
            {
                lb_guide.Text = "";
                lb_idError.Text = "Please enter the Product ID";
            }
            else
            {
                try
                {
                    //confiramtion
                    const string message = "Are You Sure to Delete the Product";
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

                        // delete command
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Product where id ='" + id + "' ";
                        cmd.ExecuteNonQuery();

                        const string newmessage = "Deleted Sucessfully";
                        const string newcaption = "Message";
                        var newresult = MessageBox.Show(newmessage, newcaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        viewData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }



            }
        }

        private void updateProduct()
        {
            emptyErrorMess();
            string productName = txt_name.Text;
            string peopleNo = txt_peoNo.Text;
            int id;
            String pid = txt_ID.Text;

            //validation
            if (pid == "" || productName == "" || peopleNo == "" || pb_image.Image == null)
            {
                if (productName == "")
                {
                    lb_UnError.Text = "Please enter the Product Name!";
                }
                if (peopleNo == "")
                {
                    lb_pError.Text = "Please enter the Number!";
                }
                if (pid == "")
                {
                    lb_idError.Text = "Please enter the Product ID";
                }
                if (pb_image.Image == null)
                {
                    MessageBox.Show("Please select an Image");
                }

            }
            else
            {
                try
                {

                    const string message = "Are You Sure to Update the Product";
                    const string caption = "Message";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    byte[] img = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    img = brs.ReadBytes((int)stream.Length);

                    //confirmation
                    if (result == DialogResult.Yes)
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Open();
                        id = int.Parse(txt_ID.Text);

                        //update command
                        string query = "update Product set product_name = '" + productName + "' , no_of_people = '" + peopleNo + "', image = @img  where ID ='" + id + "' ";
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.Add("@img", SqlDbType.Image);
                        cmd.Parameters[0].Value = img;

                        cmd.ExecuteNonQuery();

                        const string newmessage = "Updated Sucessfully";
                        const string newcaption = "Message";
                        var newresult = MessageBox.Show(newmessage, newcaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        viewData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }




            }
        }
        
        private void viewData()
        {
            try
            {
                emptyErrorMess();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                //select command

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ID,product_name,no_of_people from Product";
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

        private void searchProduct()
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

                    //search command
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select ID,product_name,no_of_people from Product where id ='" + id + "' ";
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


        private void Product_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            emptyErrorMess();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            viewData();
        }
        

        private void btn_delete_Click(object sender, EventArgs e)
        {
           deleteProduct();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            updateProduct();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchProduct();
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            
            // open dialog to select pictures
            try
            {
                OpenFileDialog open = new OpenFileDialog();

                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = open.FileName.ToString();
                    pb_image.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("Can not upload image");
            }
        }    

        private byte[] convertImageToByte(System.Drawing.Image imageIn)
        {
            // convert images to byte array to store in database
            using(MemoryStream ms =new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
          

        }

        private void btn_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}

