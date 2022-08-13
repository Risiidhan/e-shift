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

namespace CourseWork
{
    public partial class Order : Form
    {
        //server connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFEGPS;Initial Catalog=eShiftDB;Integrated Security=True");
        public Order()
        {
            InitializeComponent();
        }


        private void emptyErrorMess()
        {
            lb_clError.Text = "";
            lb_quanError.Text = "";
            lb_desError.Text = "";
            lb_productError.Text = "";

        }
        private void emptyTextBox()
        {
            cmb_product.Text = "";
            txt_quantity.Text = "";
        }

        private void Order_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            //get username from varible in login form
            txt_username.Text = CustomerLogin.SetValueForUser;

            //empty error message
            lb_clError.Text = "";
            lb_desError.Text = "";
            lb_productError.Text = "";
            lb_quanError.Text = "";

            string newOrderNo = "";
            int orderID;

            try
            {
                //get the new order ID
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlCommand Comm1 = new SqlCommand("select MAX(ow_id) from OrderItemWise", con);
                con.Open();
                SqlDataReader DR1 = Comm1.ExecuteReader();
                if (DR1.Read())
                {
                    newOrderNo = DR1.GetValue(0).ToString();
                    orderID = int.Parse(newOrderNo);
                    orderID = orderID + 1;

                    txt_orderNo.Text = orderID.ToString();
                }
                con.Close();



                //fill combo box
                SqlDataAdapter da = new SqlDataAdapter("select product_name from Product", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_product.DataSource = dt;
                cmb_product.DisplayMember = "product_name";
                cmb_product.ValueMember = "product_name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void addToCart()
        {
            string orderID = txt_orderNo.Text;
            string customerName = txt_username.Text;
            string productName = cmb_product.Text;
            string quantity = txt_quantity.Text;
            string currentLocation = txt_cLocation.Text;
            string destination = txt_destintaion.Text;

            //validation
            if (productName == "" || quantity == "" || currentLocation == "" || destination == "")
            {
                if (productName == "")
                {
                    lb_productError.Text = "Please choose the product!";
                }
                if (quantity == "")
                {
                    lb_quanError.Text = "Please enter the quantity!";
                }
                if (currentLocation == "")
                {
                    lb_clError.Text = "Please enter the location!";
                }
                if (destination == "")
                {
                    lb_desError.Text = "Please enter the location!";
                }
            }
            else
            {
                try
                {

                    //check if porduct already exists
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select customer_name from OrderItemWise where product_name = '" + productName + "' AND ow_id = '" + orderID + "'";


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
                        cmd.CommandText = "insert into OrderItemWise (ow_id, customer_name, product_name,quantity,current_location,destination) values ('" + orderID + "' , '" + customerName + "', '" + productName + "', '" + quantity + "', '" + currentLocation + "','" + destination + "')";
                        cmd.ExecuteNonQuery();

                        viewData();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                con.Close();
            }

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            addToCart();
        }


        private void viewData()
        {
            int orderID = int.Parse(txt_orderNo.Text);
            // display all data in datagridView
            emptyErrorMess();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            try
            {
                // show product name and quantity
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select product_name, quantity from OrderItemWise where ow_id = '" + orderID + "'";
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

        private void deleteOrderData()
        {
            //confirmation
            const string message = "Are You Sure to Clear this Order?";
            const string caption = "Message";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);

          
                SqlCommand cmd = con.CreateCommand();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                try
                {
                    //clear order
                    cmd.CommandText = "delete from OrderItemWise where ow_id ='" + txt_orderNo.Text + "'";
                    cmd.ExecuteNonQuery();

                    const string messageN = "Your Order has been Cleared";
                    var resultN = MessageBox.Show(messageN, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {

            deleteOrderData();
            viewData();
        }

        private void btn_makeOrder_Click(object sender, EventArgs e)
        {
            makeOrder();
            
        }

        private void makeOrder()
        {
            int orderNo;
            string orderID = txt_orderNo.Text;
            orderNo = int.Parse(orderID);

            //validate and confrim
            if (dataGridView1.Rows.Count != 0)
            {
                const string message = "Are You Sure to Make an Order?";
                const string caption = "Message";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = con.CreateCommand();
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

                        //insert command
                        con.Open();
                        cmd.CommandText = "insert into Orders (ow_id, status) values ('" + orderNo + "','" + "Pending" + "')";
                        cmd.ExecuteNonQuery();

                        const string messageN = "Your Order has been placed Successfully";
                        var resultN = MessageBox.Show(messageN, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //naviagate to dashboard
                        CustomerDashbard customerDashbard = new CustomerDashbard();
                        customerDashbard.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }

            }
            else
            {
                const string message = "Please enter products before making an order";
                const string caption = "Message";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            deleteOrderData();

            CustomerDashbard customerDashbard = new CustomerDashbard();
            customerDashbard.Show();
            this.Hide();
        }
  

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            // convert byte array to image

            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }

        private void lb_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deleteOrderData();
            CustomerDashbard cs = new CustomerDashbard();
            cs.Show();
            this.Hide();
        }


        private void cmb_product_SelectedValueChanged(object sender, EventArgs e)
        {

            string product = cmb_product.Text;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand Comm = new SqlCommand("select image from Product where product_name ='" + product + "'", con);
            SqlDataReader reader = Comm.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                byte[] img = (byte[])reader[0];
                pictureBox2.Image = Image.FromStream(new MemoryStream(img));

            }
            con.Close();

        }
    }
    
}


    


















