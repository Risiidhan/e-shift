namespace CourseWork
{
    partial class Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_UnError = new System.Windows.Forms.Label();
            this.lb_pError = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_peoNo = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lb_idError = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_guide = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.LinkLabel();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(326, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "PRODUCTS";
            // 
            // lb_UnError
            // 
            this.lb_UnError.AutoSize = true;
            this.lb_UnError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_UnError.ForeColor = System.Drawing.Color.Coral;
            this.lb_UnError.Location = new System.Drawing.Point(33, 250);
            this.lb_UnError.Name = "lb_UnError";
            this.lb_UnError.Size = new System.Drawing.Size(123, 15);
            this.lb_UnError.TabIndex = 40;
            this.lb_UnError.Text = "Please enter the name!";
            // 
            // lb_pError
            // 
            this.lb_pError.AutoSize = true;
            this.lb_pError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_pError.ForeColor = System.Drawing.Color.Coral;
            this.lb_pError.Location = new System.Drawing.Point(33, 319);
            this.lb_pError.Name = "lb_pError";
            this.lb_pError.Size = new System.Drawing.Size(135, 15);
            this.lb_pError.TabIndex = 42;
            this.lb_pError.Text = "Please enter the number!";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Location = new System.Drawing.Point(583, 459);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Coral;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_add.Location = new System.Drawing.Point(429, 407);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 38;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_peoNo
            // 
            this.txt_peoNo.Location = new System.Drawing.Point(33, 296);
            this.txt_peoNo.Name = "txt_peoNo";
            this.txt_peoNo.Size = new System.Drawing.Size(259, 20);
            this.txt_peoNo.TabIndex = 37;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(33, 227);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(259, 20);
            this.txt_name.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(35, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "PRODUCT IMAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "PRODUCT NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(30, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "PRODUCT ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(33, 156);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(259, 20);
            this.txt_ID.TabIndex = 36;
            // 
            // lb_idError
            // 
            this.lb_idError.AutoSize = true;
            this.lb_idError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_idError.ForeColor = System.Drawing.Color.Coral;
            this.lb_idError.Location = new System.Drawing.Point(33, 179);
            this.lb_idError.Name = "lb_idError";
            this.lb_idError.Size = new System.Drawing.Size(106, 15);
            this.lb_idError.TabIndex = 41;
            this.lb_idError.Text = "Please enter the ID!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(366, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 184);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // lb_guide
            // 
            this.lb_guide.AutoSize = true;
            this.lb_guide.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_guide.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_guide.Location = new System.Drawing.Point(33, 179);
            this.lb_guide.Name = "lb_guide";
            this.lb_guide.Size = new System.Drawing.Size(176, 15);
            this.lb_guide.TabIndex = 41;
            this.lb_guide.Text = "Only to search, update or delete ";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Location = new System.Drawing.Point(532, 407);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 39;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_delete.Location = new System.Drawing.Point(479, 459);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 39;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Location = new System.Drawing.Point(643, 407);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 39;
            this.btn_view.Text = "VIEW ALL";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.LightGreen;
            this.btn_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upload.Location = new System.Drawing.Point(38, 378);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 46;
            this.btn_upload.Text = "UPLOAD";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "MIN NO OF PEOPLE TO CARRY";
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_back.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.btn_back.Location = new System.Drawing.Point(33, 532);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(44, 17);
            this.btn_back.TabIndex = 73;
            this.btn_back.TabStop = true;
            this.btn_back.Text = "BACK";
            this.btn_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_back_LinkClicked);
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(36, 407);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(171, 110);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 45;
            this.pb_image.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.Design_Grade_11_ATP_Annual_Teaching_Plan_and_Teachers_Guide;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -545);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_UnError);
            this.Controls.Add(this.lb_guide);
            this.Controls.Add(this.lb_idError);
            this.Controls.Add(this.lb_pError);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_peoNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_UnError;
        private System.Windows.Forms.Label lb_pError;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_peoNo;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lb_idError;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_guide;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel btn_back;
    }
}