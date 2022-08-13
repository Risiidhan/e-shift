using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Home : Form
    {
        public Home()
        {
           

        
            InitializeComponent();
            
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            //navigate to admin login
            AdminLogin AdL = new AdminLogin();
            AdL.Show();
            this.Hide();

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            //navigate to customer login
            CustomerLogin CusL = new CustomerLogin();
            CusL.Show();
            this.Hide();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            CenterToScreen();

        }
    }
}
