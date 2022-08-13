namespace CourseWork
{
    partial class Reports
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_reportTitle = new System.Windows.Forms.Label();
            this.lb_back = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(51, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.Design_Grade_11_ATP_Annual_Teaching_Plan_and_Teachers_Guide;
            this.pictureBox1.Location = new System.Drawing.Point(1, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 636);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lb_reportTitle
            // 
            this.lb_reportTitle.AutoSize = true;
            this.lb_reportTitle.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.lb_reportTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lb_reportTitle.Location = new System.Drawing.Point(45, 29);
            this.lb_reportTitle.Name = "lb_reportTitle";
            this.lb_reportTitle.Size = new System.Drawing.Size(142, 31);
            this.lb_reportTitle.TabIndex = 16;
            this.lb_reportTitle.Text = "WELCOME";
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_back.ForeColor = System.Drawing.Color.Teal;
            this.lb_back.LinkColor = System.Drawing.Color.Turquoise;
            this.lb_back.Location = new System.Drawing.Point(48, 407);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(35, 13);
            this.lb_back.TabIndex = 18;
            this.lb_back.TabStop = true;
            this.lb_back.Text = "BACK";
            this.lb_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_back_LinkClicked);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(957, 543);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.lb_reportTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_reportTitle;
        private System.Windows.Forms.LinkLabel lb_back;
    }
}