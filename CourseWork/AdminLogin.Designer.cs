namespace CourseWork
{
    partial class AdminLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.link_back = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_pError = new System.Windows.Forms.Label();
            this.lb_UnError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_showPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_showPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(122, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(147, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADMIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(39, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "PASSWORD";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(42, 123);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(259, 20);
            this.txt_username.TabIndex = 5;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(42, 192);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(259, 20);
            this.txt_password.TabIndex = 6;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Coral;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_login.Location = new System.Drawing.Point(86, 249);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Snow;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Location = new System.Drawing.Point(177, 249);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // link_back
            // 
            this.link_back.AutoSize = true;
            this.link_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_back.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_back.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.link_back.Location = new System.Drawing.Point(151, 287);
            this.link_back.Name = "link_back";
            this.link_back.Size = new System.Drawing.Size(40, 17);
            this.link_back.TabIndex = 30;
            this.link_back.TabStop = true;
            this.link_back.Text = "BACK";
            this.link_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_back_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(39, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 2;
            // 
            // lb_pError
            // 
            this.lb_pError.AutoSize = true;
            this.lb_pError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_pError.ForeColor = System.Drawing.Color.Coral;
            this.lb_pError.Location = new System.Drawing.Point(39, 215);
            this.lb_pError.Name = "lb_pError";
            this.lb_pError.Size = new System.Drawing.Size(145, 15);
            this.lb_pError.TabIndex = 2;
            this.lb_pError.Text = "Please enter the password!";
            // 
            // lb_UnError
            // 
            this.lb_UnError.AutoSize = true;
            this.lb_UnError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_UnError.ForeColor = System.Drawing.Color.Coral;
            this.lb_UnError.Location = new System.Drawing.Point(39, 146);
            this.lb_UnError.Name = "lb_UnError";
            this.lb_UnError.Size = new System.Drawing.Size(145, 15);
            this.lb_UnError.TabIndex = 2;
            this.lb_UnError.Text = "Please enter the username!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.Design_Grade_11_ATP_Annual_Teaching_Plan_and_Teachers_Guide;
            this.pictureBox1.Location = new System.Drawing.Point(0, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pb_showPassword
            // 
            this.pb_showPassword.BackColor = System.Drawing.Color.White;
            this.pb_showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_showPassword.Image = global::CourseWork.Properties.Resources.showPassword;
            this.pb_showPassword.Location = new System.Drawing.Point(283, 195);
            this.pb_showPassword.Name = "pb_showPassword";
            this.pb_showPassword.Size = new System.Drawing.Size(14, 14);
            this.pb_showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_showPassword.TabIndex = 34;
            this.pb_showPassword.TabStop = false;
            this.pb_showPassword.Click += new System.EventHandler(this.pb_showPassword_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(343, 453);
            this.Controls.Add(this.pb_showPassword);
            this.Controls.Add(this.link_back);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_UnError);
            this.Controls.Add(this.lb_pError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_showPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.LinkLabel link_back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_pError;
        private System.Windows.Forms.Label lb_UnError;
        private System.Windows.Forms.PictureBox pb_showPassword;
    }
}

