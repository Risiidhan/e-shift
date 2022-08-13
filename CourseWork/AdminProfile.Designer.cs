namespace CourseWork
{
    partial class AdminProfile
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
            this.link_back = new System.Windows.Forms.LinkLabel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_newName = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_UnError = new System.Windows.Forms.Label();
            this.lb_pError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_newPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // link_back
            // 
            this.link_back.AutoSize = true;
            this.link_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_back.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_back.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.link_back.Location = new System.Drawing.Point(150, 347);
            this.link_back.Name = "link_back";
            this.link_back.Size = new System.Drawing.Size(40, 17);
            this.link_back.TabIndex = 43;
            this.link_back.TabStop = true;
            this.link_back.Text = "BACK";
            this.link_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_back_LinkClicked);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Snow;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Location = new System.Drawing.Point(176, 309);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 42;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Coral;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_update.Location = new System.Drawing.Point(85, 309);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 41;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_newName
            // 
            this.txt_newName.Location = new System.Drawing.Point(41, 188);
            this.txt_newName.Name = "txt_newName";
            this.txt_newName.Size = new System.Drawing.Size(259, 20);
            this.txt_newName.TabIndex = 40;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(41, 119);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(259, 20);
            this.txt_username.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "NEW USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "USERNAME";
            // 
            // lb_UnError
            // 
            this.lb_UnError.AutoSize = true;
            this.lb_UnError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_UnError.ForeColor = System.Drawing.Color.Coral;
            this.lb_UnError.Location = new System.Drawing.Point(38, 142);
            this.lb_UnError.Name = "lb_UnError";
            this.lb_UnError.Size = new System.Drawing.Size(145, 15);
            this.lb_UnError.TabIndex = 33;
            this.lb_UnError.Text = "Please enter the username!";
            // 
            // lb_pError
            // 
            this.lb_pError.AutoSize = true;
            this.lb_pError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_pError.ForeColor = System.Drawing.Color.Coral;
            this.lb_pError.Location = new System.Drawing.Point(38, 211);
            this.lb_pError.Name = "lb_pError";
            this.lb_pError.Size = new System.Drawing.Size(145, 15);
            this.lb_pError.TabIndex = 34;
            this.lb_pError.Text = "Please enter the password!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(38, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(146, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "ADMIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 32;
            this.label1.Text = "PROFILE SETTING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.Design_Grade_11_ATP_Annual_Teaching_Plan_and_Teachers_Guide;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(41, 257);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(259, 20);
            this.txt_password.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(38, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "NEW PASSWORD";
            // 
            // lb_newPass
            // 
            this.lb_newPass.AutoSize = true;
            this.lb_newPass.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_newPass.ForeColor = System.Drawing.Color.Coral;
            this.lb_newPass.Location = new System.Drawing.Point(38, 280);
            this.lb_newPass.Name = "lb_newPass";
            this.lb_newPass.Size = new System.Drawing.Size(145, 15);
            this.lb_newPass.TabIndex = 44;
            this.lb_newPass.Text = "Please enter the password!";
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(342, 510);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_newPass);
            this.Controls.Add(this.link_back);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_newName);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_UnError);
            this.Controls.Add(this.lb_pError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_back;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_newName;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_UnError;
        private System.Windows.Forms.Label lb_pError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_newPass;
    }
}