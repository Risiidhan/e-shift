namespace CourseWork
{
    partial class Transport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_desError = new System.Windows.Forms.Label();
            this.lb_guide = new System.Windows.Forms.Label();
            this.lb_idError = new System.Windows.Forms.Label();
            this.lb_asissNoError = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_asissNo = new System.Windows.Forms.TextBox();
            this.lb_transID = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lb_asissNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_lorryNoError = new System.Windows.Forms.Label();
            this.txt_lorry = new System.Windows.Forms.TextBox();
            this.lb_lorryNo = new System.Windows.Forms.Label();
            this.lb_contNoError = new System.Windows.Forms.Label();
            this.txt_container = new System.Windows.Forms.TextBox();
            this.lb_contNo = new System.Windows.Forms.Label();
            this.lb_driverError = new System.Windows.Forms.Label();
            this.txt_driver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(347, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 252);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // lb_desError
            // 
            this.lb_desError.AutoSize = true;
            this.lb_desError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_desError.ForeColor = System.Drawing.Color.Coral;
            this.lb_desError.Location = new System.Drawing.Point(31, 208);
            this.lb_desError.Name = "lb_desError";
            this.lb_desError.Size = new System.Drawing.Size(117, 15);
            this.lb_desError.TabIndex = 58;
            this.lb_desError.Text = "Please enter the type!";
            // 
            // lb_guide
            // 
            this.lb_guide.AutoSize = true;
            this.lb_guide.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_guide.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_guide.Location = new System.Drawing.Point(31, 137);
            this.lb_guide.Name = "lb_guide";
            this.lb_guide.Size = new System.Drawing.Size(176, 15);
            this.lb_guide.TabIndex = 60;
            this.lb_guide.Text = "Only to search, update or delete ";
            // 
            // lb_idError
            // 
            this.lb_idError.AutoSize = true;
            this.lb_idError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_idError.ForeColor = System.Drawing.Color.Coral;
            this.lb_idError.Location = new System.Drawing.Point(31, 137);
            this.lb_idError.Name = "lb_idError";
            this.lb_idError.Size = new System.Drawing.Size(106, 15);
            this.lb_idError.TabIndex = 59;
            this.lb_idError.Text = "Please enter the ID!";
            // 
            // lb_asissNoError
            // 
            this.lb_asissNoError.AutoSize = true;
            this.lb_asissNoError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_asissNoError.ForeColor = System.Drawing.Color.Coral;
            this.lb_asissNoError.Location = new System.Drawing.Point(34, 421);
            this.lb_asissNoError.Name = "lb_asissNoError";
            this.lb_asissNoError.Size = new System.Drawing.Size(135, 15);
            this.lb_asissNoError.TabIndex = 61;
            this.lb_asissNoError.Text = "Please enter the number!";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_delete.Location = new System.Drawing.Point(569, 462);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Location = new System.Drawing.Point(470, 462);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 55;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Location = new System.Drawing.Point(783, 462);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 57;
            this.btn_view.Text = "VIEW ALL";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Location = new System.Drawing.Point(673, 462);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 54;
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
            this.btn_add.Location = new System.Drawing.Point(367, 462);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 53;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(34, 114);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(259, 20);
            this.txt_ID.TabIndex = 51;
            // 
            // txt_asissNo
            // 
            this.txt_asissNo.Location = new System.Drawing.Point(34, 398);
            this.txt_asissNo.Name = "txt_asissNo";
            this.txt_asissNo.Size = new System.Drawing.Size(259, 20);
            this.txt_asissNo.TabIndex = 52;
            // 
            // lb_transID
            // 
            this.lb_transID.AutoSize = true;
            this.lb_transID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_transID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_transID.Location = new System.Drawing.Point(28, 95);
            this.lb_transID.Name = "lb_transID";
            this.lb_transID.Size = new System.Drawing.Size(95, 16);
            this.lb_transID.TabIndex = 48;
            this.lb_transID.Text = "TRANSPORT ID";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(34, 185);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(259, 20);
            this.txt_description.TabIndex = 50;
            // 
            // lb_asissNo
            // 
            this.lb_asissNo.AutoSize = true;
            this.lb_asissNo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_asissNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_asissNo.Location = new System.Drawing.Point(31, 379);
            this.lb_asissNo.Name = "lb_asissNo";
            this.lb_asissNo.Size = new System.Drawing.Size(122, 16);
            this.lb_asissNo.TabIndex = 49;
            this.lb_asissNo.Text = "NO OF ASISSTANTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(34, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "DESCRIPTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(361, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "TRANSPORT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.Design_Grade_11_ATP_Annual_Teaching_Plan_and_Teachers_Guide;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -569);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(907, 636);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // lb_lorryNoError
            // 
            this.lb_lorryNoError.AutoSize = true;
            this.lb_lorryNoError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_lorryNoError.ForeColor = System.Drawing.Color.Coral;
            this.lb_lorryNoError.Location = new System.Drawing.Point(31, 283);
            this.lb_lorryNoError.Name = "lb_lorryNoError";
            this.lb_lorryNoError.Size = new System.Drawing.Size(109, 15);
            this.lb_lorryNoError.TabIndex = 65;
            this.lb_lorryNoError.Text = "Please enter the no!";
            // 
            // txt_lorry
            // 
            this.txt_lorry.Location = new System.Drawing.Point(34, 260);
            this.txt_lorry.Name = "txt_lorry";
            this.txt_lorry.Size = new System.Drawing.Size(259, 20);
            this.txt_lorry.TabIndex = 64;
            // 
            // lb_lorryNo
            // 
            this.lb_lorryNo.AutoSize = true;
            this.lb_lorryNo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lorryNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_lorryNo.Location = new System.Drawing.Point(31, 241);
            this.lb_lorryNo.Name = "lb_lorryNo";
            this.lb_lorryNo.Size = new System.Drawing.Size(70, 16);
            this.lb_lorryNo.TabIndex = 63;
            this.lb_lorryNo.Text = "LORRY NO";
            // 
            // lb_contNoError
            // 
            this.lb_contNoError.AutoSize = true;
            this.lb_contNoError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_contNoError.ForeColor = System.Drawing.Color.Coral;
            this.lb_contNoError.Location = new System.Drawing.Point(31, 356);
            this.lb_contNoError.Name = "lb_contNoError";
            this.lb_contNoError.Size = new System.Drawing.Size(109, 15);
            this.lb_contNoError.TabIndex = 68;
            this.lb_contNoError.Text = "Please enter the no!";
            // 
            // txt_container
            // 
            this.txt_container.Location = new System.Drawing.Point(34, 333);
            this.txt_container.Name = "txt_container";
            this.txt_container.Size = new System.Drawing.Size(259, 20);
            this.txt_container.TabIndex = 67;
            // 
            // lb_contNo
            // 
            this.lb_contNo.AutoSize = true;
            this.lb_contNo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_contNo.Location = new System.Drawing.Point(31, 314);
            this.lb_contNo.Name = "lb_contNo";
            this.lb_contNo.Size = new System.Drawing.Size(102, 16);
            this.lb_contNo.TabIndex = 66;
            this.lb_contNo.Text = "CONTAINER NO";
            // 
            // lb_driverError
            // 
            this.lb_driverError.AutoSize = true;
            this.lb_driverError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_driverError.ForeColor = System.Drawing.Color.Coral;
            this.lb_driverError.Location = new System.Drawing.Point(34, 489);
            this.lb_driverError.Name = "lb_driverError";
            this.lb_driverError.Size = new System.Drawing.Size(123, 15);
            this.lb_driverError.TabIndex = 71;
            this.lb_driverError.Text = "Please enter the name!";
            // 
            // txt_driver
            // 
            this.txt_driver.Location = new System.Drawing.Point(34, 466);
            this.txt_driver.Name = "txt_driver";
            this.txt_driver.Size = new System.Drawing.Size(259, 20);
            this.txt_driver.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "DRIVER";
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_back.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.btn_back.Location = new System.Drawing.Point(31, 543);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(44, 17);
            this.btn_back.TabIndex = 72;
            this.btn_back.TabStop = true;
            this.btn_back.Text = "BACK";
            this.btn_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_back_LinkClicked);
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(900, 574);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_driverError);
            this.Controls.Add(this.txt_driver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_contNoError);
            this.Controls.Add(this.txt_container);
            this.Controls.Add(this.lb_contNo);
            this.Controls.Add(this.lb_lorryNoError);
            this.Controls.Add(this.txt_lorry);
            this.Controls.Add(this.lb_lorryNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_desError);
            this.Controls.Add(this.lb_guide);
            this.Controls.Add(this.lb_idError);
            this.Controls.Add(this.lb_asissNoError);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_asissNo);
            this.Controls.Add(this.lb_transID);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lb_asissNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Transport";
            this.Text = "Transport";
            this.Load += new System.EventHandler(this.Transport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_desError;
        private System.Windows.Forms.Label lb_guide;
        private System.Windows.Forms.Label lb_idError;
        private System.Windows.Forms.Label lb_asissNoError;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_asissNo;
        private System.Windows.Forms.Label lb_transID;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lb_asissNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_lorryNoError;
        private System.Windows.Forms.TextBox txt_lorry;
        private System.Windows.Forms.Label lb_lorryNo;
        private System.Windows.Forms.Label lb_contNoError;
        private System.Windows.Forms.TextBox txt_container;
        private System.Windows.Forms.Label lb_contNo;
        private System.Windows.Forms.Label lb_driverError;
        private System.Windows.Forms.TextBox txt_driver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel btn_back;
    }
}