namespace CourseWork
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_clError = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_cLocation = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_desError = new System.Windows.Forms.Label();
            this.txt_destintaion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_productError = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_product = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShiftDBDataSet = new CourseWork.eShiftDBDataSet();
            this.lb_quanError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_orderNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_makeOrder = new System.Windows.Forms.Button();
            this.lb_back = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productTableAdapter = new CourseWork.eShiftDBDataSetTableAdapters.ProductTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShiftDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(419, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "MAKE ORDER";
            // 
            // lb_clError
            // 
            this.lb_clError.AutoSize = true;
            this.lb_clError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_clError.ForeColor = System.Drawing.Color.Coral;
            this.lb_clError.Location = new System.Drawing.Point(26, 450);
            this.lb_clError.Name = "lb_clError";
            this.lb_clError.Size = new System.Drawing.Size(137, 15);
            this.lb_clError.TabIndex = 40;
            this.lb_clError.Text = "Please enter the location!";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Wheat;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(779, 477);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 38;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Coral;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_add.Location = new System.Drawing.Point(688, 477);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 37;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_cLocation
            // 
            this.txt_cLocation.Location = new System.Drawing.Point(29, 427);
            this.txt_cLocation.Name = "txt_cLocation";
            this.txt_cLocation.Size = new System.Drawing.Size(259, 20);
            this.txt_cLocation.TabIndex = 36;
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(29, 223);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(259, 20);
            this.txt_username.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "CURRENT LOCATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "USERNAME";
            // 
            // lb_desError
            // 
            this.lb_desError.AutoSize = true;
            this.lb_desError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_desError.ForeColor = System.Drawing.Color.Coral;
            this.lb_desError.Location = new System.Drawing.Point(26, 521);
            this.lb_desError.Name = "lb_desError";
            this.lb_desError.Size = new System.Drawing.Size(137, 15);
            this.lb_desError.TabIndex = 43;
            this.lb_desError.Text = "Please enter the location!";
            // 
            // txt_destintaion
            // 
            this.txt_destintaion.Location = new System.Drawing.Point(29, 498);
            this.txt_destintaion.Name = "txt_destintaion";
            this.txt_destintaion.Size = new System.Drawing.Size(259, 20);
            this.txt_destintaion.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "DESTINATION";
            // 
            // lb_productError
            // 
            this.lb_productError.AutoSize = true;
            this.lb_productError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_productError.ForeColor = System.Drawing.Color.Coral;
            this.lb_productError.Location = new System.Drawing.Point(26, 303);
            this.lb_productError.Name = "lb_productError";
            this.lb_productError.Size = new System.Drawing.Size(145, 15);
            this.lb_productError.TabIndex = 46;
            this.lb_productError.Text = "Please enter the PRODUCT!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(26, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "CHOOSE PRODUCT";
            // 
            // cmb_product
            // 
            this.cmb_product.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "product_name", true));
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Location = new System.Drawing.Point(29, 280);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(259, 21);
            this.cmb_product.TabIndex = 47;
            this.cmb_product.SelectedValueChanged += new System.EventHandler(this.cmb_product_SelectedValueChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.eShiftDBDataSet;
            // 
            // eShiftDBDataSet
            // 
            this.eShiftDBDataSet.DataSetName = "eShiftDBDataSet";
            this.eShiftDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_quanError
            // 
            this.lb_quanError.AutoSize = true;
            this.lb_quanError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_quanError.ForeColor = System.Drawing.Color.Coral;
            this.lb_quanError.Location = new System.Drawing.Point(26, 371);
            this.lb_quanError.Name = "lb_quanError";
            this.lb_quanError.Size = new System.Drawing.Size(191, 15);
            this.lb_quanError.TabIndex = 49;
            this.lb_quanError.Text = "Please enter the PRODUCT quantity!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(26, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "QUANTITY";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(29, 348);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(259, 20);
            this.txt_quantity.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(26, 656);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Please enter the PRODUCT quantity!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(697, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 290);
            this.dataGridView1.TabIndex = 50;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Teal;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(875, 477);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 51;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_orderNo
            // 
            this.txt_orderNo.Enabled = false;
            this.txt_orderNo.Location = new System.Drawing.Point(29, 169);
            this.txt_orderNo.Name = "txt_orderNo";
            this.txt_orderNo.Size = new System.Drawing.Size(259, 20);
            this.txt_orderNo.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(26, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "ORDER NO";
            // 
            // btn_makeOrder
            // 
            this.btn_makeOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_makeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_makeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_makeOrder.Location = new System.Drawing.Point(688, 516);
            this.btn_makeOrder.Name = "btn_makeOrder";
            this.btn_makeOrder.Size = new System.Drawing.Size(262, 23);
            this.btn_makeOrder.TabIndex = 54;
            this.btn_makeOrder.Text = "MAKE THE ORDER";
            this.btn_makeOrder.UseVisualStyleBackColor = false;
            this.btn_makeOrder.Click += new System.EventHandler(this.btn_makeOrder_Click);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_back.ForeColor = System.Drawing.Color.Teal;
            this.lb_back.LinkColor = System.Drawing.Color.Turquoise;
            this.lb_back.Location = new System.Drawing.Point(26, 563);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(35, 13);
            this.lb_back.TabIndex = 57;
            this.lb_back.TabStop = true;
            this.lb_back.Text = "BACK";
            this.lb_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_back_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.Design_Grade_11_ATP_Annual_Teaching_Plan_and_Teachers_Guide;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -543);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(344, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(971, 599);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.btn_makeOrder);
            this.Controls.Add(this.txt_orderNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_quanError);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_product);
            this.Controls.Add(this.lb_productError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lb_desError);
            this.Controls.Add(this.txt_destintaion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_clError);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_cLocation);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShiftDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_clError;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_cLocation;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_desError;
        private System.Windows.Forms.TextBox txt_destintaion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_productError;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_product;
        private System.Windows.Forms.Label lb_quanError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_orderNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_makeOrder;
        private System.Windows.Forms.LinkLabel lb_back;
        private eShiftDBDataSet eShiftDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private eShiftDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}