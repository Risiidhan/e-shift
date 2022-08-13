namespace CourseWork
{
    partial class PendingOrder
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
            this.cmb_orderNo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_decline = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lb_back = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_orderNo
            // 
            this.cmb_orderNo.FormattingEnabled = true;
            this.cmb_orderNo.Location = new System.Drawing.Point(29, 81);
            this.cmb_orderNo.Name = "cmb_orderNo";
            this.cmb_orderNo.Size = new System.Drawing.Size(121, 21);
            this.cmb_orderNo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(29, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.Coral;
            this.btn_accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_accept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_accept.Location = new System.Drawing.Point(34, 353);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(181, 23);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "ACCEPT FOR JOB";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_decline
            // 
            this.btn_decline.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_decline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_decline.ForeColor = System.Drawing.Color.Black;
            this.btn_decline.Location = new System.Drawing.Point(236, 353);
            this.btn_decline.Name = "btn_decline";
            this.btn_decline.Size = new System.Drawing.Size(75, 23);
            this.btn_decline.TabIndex = 2;
            this.btn_decline.Text = "DECLINE";
            this.btn_decline.UseVisualStyleBackColor = false;
            this.btn_decline.Click += new System.EventHandler(this.btn_decline_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.Design_Grade_11_ATP_Annual_Teaching_Plan_and_Teachers_Guide;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(974, 667);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "ACCEPT OR DECLINE ORDERS";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(165, 81);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_back.ForeColor = System.Drawing.Color.Teal;
            this.lb_back.LinkColor = System.Drawing.Color.Turquoise;
            this.lb_back.Location = new System.Drawing.Point(29, 407);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(35, 13);
            this.lb_back.TabIndex = 27;
            this.lb_back.TabStop = true;
            this.lb_back.Text = "BACK";
            this.lb_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_back_LinkClicked);
            // 
            // PendingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(732, 537);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_decline);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_orderNo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PendingOrder";
            this.Text = "PendingOrder";
            this.Load += new System.EventHandler(this.PendingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_orderNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_decline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.LinkLabel lb_back;
    }
}