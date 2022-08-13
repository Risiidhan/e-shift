namespace CourseWork
{
    partial class CustomerRegistration
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_UnError = new System.Windows.Forms.Label();
            this.lb_pError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_conPass = new System.Windows.Forms.TextBox();
            this.lb_conPError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_contError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Snow;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Location = new System.Drawing.Point(179, 402);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Coral;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_add.Location = new System.Drawing.Point(88, 402);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(41, 285);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(259, 20);
            this.txt_password.TabIndex = 26;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(41, 98);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(259, 20);
            this.txt_username.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(131, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "CUSTOMER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(70, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "REGISTRATION";
            // 
            // lb_UnError
            // 
            this.lb_UnError.AutoSize = true;
            this.lb_UnError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_UnError.ForeColor = System.Drawing.Color.Coral;
            this.lb_UnError.Location = new System.Drawing.Point(41, 121);
            this.lb_UnError.Name = "lb_UnError";
            this.lb_UnError.Size = new System.Drawing.Size(145, 15);
            this.lb_UnError.TabIndex = 30;
            this.lb_UnError.Text = "Please enter the username!";
            // 
            // lb_pError
            // 
            this.lb_pError.AutoSize = true;
            this.lb_pError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_pError.ForeColor = System.Drawing.Color.Coral;
            this.lb_pError.Location = new System.Drawing.Point(41, 308);
            this.lb_pError.Name = "lb_pError";
            this.lb_pError.Size = new System.Drawing.Size(145, 15);
            this.lb_pError.TabIndex = 31;
            this.lb_pError.Text = "Please enter the password!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "CONFIRM PASSWORD";
            // 
            // txt_conPass
            // 
            this.txt_conPass.Location = new System.Drawing.Point(41, 351);
            this.txt_conPass.Name = "txt_conPass";
            this.txt_conPass.PasswordChar = '●';
            this.txt_conPass.Size = new System.Drawing.Size(259, 20);
            this.txt_conPass.TabIndex = 26;
            // 
            // lb_conPError
            // 
            this.lb_conPError.AutoSize = true;
            this.lb_conPError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_conPError.ForeColor = System.Drawing.Color.Coral;
            this.lb_conPError.Location = new System.Drawing.Point(41, 374);
            this.lb_conPError.Name = "lb_conPError";
            this.lb_conPError.Size = new System.Drawing.Size(145, 15);
            this.lb_conPError.TabIndex = 31;
            this.lb_conPError.Text = "Please enter the password!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(38, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "ADDRESS";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(41, 162);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(259, 20);
            this.txt_address.TabIndex = 25;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(40, 217);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(259, 20);
            this.txt_contact.TabIndex = 33;
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(37, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "CONTACT";
            // 
            // lb_contError
            // 
            this.lb_contError.AutoSize = true;
            this.lb_contError.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.lb_contError.ForeColor = System.Drawing.Color.Coral;
            this.lb_contError.Location = new System.Drawing.Point(38, 240);
            this.lb_contError.Name = "lb_contError";
            this.lb_contError.Size = new System.Drawing.Size(135, 15);
            this.lb_contError.TabIndex = 34;
            this.lb_contError.Text = "Please enter the number!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.Design_Grade_11_ATP_Annual_Teaching_Plan_and_Teachers_Guide;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 439);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(342, 573);
            this.Controls.Add(this.lb_contError);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_UnError);
            this.Controls.Add(this.lb_conPError);
            this.Controls.Add(this.lb_pError);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_conPass);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerRegistration";
            this.Text = "CustomerRegistration";
            this.Load += new System.EventHandler(this.CustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_UnError;
        private System.Windows.Forms.Label lb_pError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_conPass;
        private System.Windows.Forms.Label lb_conPError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_contError;
    }
}