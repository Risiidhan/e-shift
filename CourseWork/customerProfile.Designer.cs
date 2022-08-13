namespace CourseWork
{
    partial class customerProfile
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_newPass = new System.Windows.Forms.Label();
            this.link_back = new System.Windows.Forms.LinkLabel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_CurrentUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_CurreUnError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_addError = new System.Windows.Forms.Label();
            this.lb_contError = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(42, 323);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(259, 20);
            this.txt_password.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(39, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "NEW PASSWORD";
            // 
            // lb_newPass
            // 
            this.lb_newPass.AutoSize = true;
            this.lb_newPass.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_newPass.ForeColor = System.Drawing.Color.Coral;
            this.lb_newPass.Location = new System.Drawing.Point(39, 346);
            this.lb_newPass.Name = "lb_newPass";
            this.lb_newPass.Size = new System.Drawing.Size(145, 15);
            this.lb_newPass.TabIndex = 60;
            this.lb_newPass.Text = "Please enter the password!";
            // 
            // link_back
            // 
            this.link_back.AutoSize = true;
            this.link_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_back.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_back.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.link_back.Location = new System.Drawing.Point(151, 424);
            this.link_back.Name = "link_back";
            this.link_back.Size = new System.Drawing.Size(40, 17);
            this.link_back.TabIndex = 59;
            this.link_back.TabStop = true;
            this.link_back.Text = "BACK";
            this.link_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_back_LinkClicked);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Snow;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Location = new System.Drawing.Point(177, 386);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 58;
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
            this.btn_update.Location = new System.Drawing.Point(86, 386);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 57;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_CurrentUsername
            // 
            this.txt_CurrentUsername.Location = new System.Drawing.Point(42, 112);
            this.txt_CurrentUsername.Name = "txt_CurrentUsername";
            this.txt_CurrentUsername.Size = new System.Drawing.Size(259, 20);
            this.txt_CurrentUsername.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "CURRENT USERNAME";
            // 
            // lb_CurreUnError
            // 
            this.lb_CurreUnError.AutoSize = true;
            this.lb_CurreUnError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_CurreUnError.ForeColor = System.Drawing.Color.Coral;
            this.lb_CurreUnError.Location = new System.Drawing.Point(39, 135);
            this.lb_CurreUnError.Name = "lb_CurreUnError";
            this.lb_CurreUnError.Size = new System.Drawing.Size(145, 15);
            this.lb_CurreUnError.TabIndex = 49;
            this.lb_CurreUnError.Text = "Please enter the username!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(39, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(137, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "CUSTOMER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 48;
            this.label1.Text = "PROFILE SETTING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.Design_Grade_11_ATP_Annual_Teaching_Plan_and_Teachers_Guide;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(42, 254);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(259, 20);
            this.txt_contact.TabIndex = 69;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(42, 185);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(259, 20);
            this.txt_address.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(39, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 67;
            this.label7.Text = "CONTACT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(39, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "ADDRESS";
            // 
            // lb_addError
            // 
            this.lb_addError.AutoSize = true;
            this.lb_addError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_addError.ForeColor = System.Drawing.Color.Coral;
            this.lb_addError.Location = new System.Drawing.Point(39, 208);
            this.lb_addError.Name = "lb_addError";
            this.lb_addError.Size = new System.Drawing.Size(135, 15);
            this.lb_addError.TabIndex = 63;
            this.lb_addError.Text = "Please enter the address!";
            // 
            // lb_contError
            // 
            this.lb_contError.AutoSize = true;
            this.lb_contError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_contError.ForeColor = System.Drawing.Color.Coral;
            this.lb_contError.Location = new System.Drawing.Point(39, 277);
            this.lb_contError.Name = "lb_contError";
            this.lb_contError.Size = new System.Drawing.Size(133, 15);
            this.lb_contError.TabIndex = 64;
            this.lb_contError.Text = "Please enter the contact!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(39, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 14);
            this.label11.TabIndex = 65;
            // 
            // customerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(340, 533);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_addError);
            this.Controls.Add(this.lb_contError);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_newPass);
            this.Controls.Add(this.link_back);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_CurrentUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_CurreUnError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "customerProfile";
            this.Text = "customerProfile";
            this.Load += new System.EventHandler(this.customerProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_newPass;
        private System.Windows.Forms.LinkLabel link_back;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_CurrentUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_CurreUnError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_addError;
        private System.Windows.Forms.Label lb_contError;
        private System.Windows.Forms.Label label11;
    }
}