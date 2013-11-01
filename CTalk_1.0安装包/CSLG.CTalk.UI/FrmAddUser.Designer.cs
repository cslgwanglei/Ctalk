namespace CSLG.CTalk.UI
{
    partial class FrmAddUser
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtShuoshuo = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.Ylblname = new System.Windows.Forms.Label();
            this.Ylblpassword = new System.Windows.Forms.Label();
            this.Ylblsex = new System.Windows.Forms.Label();
            this.Ylblbirthday = new System.Windows.Forms.Label();
            this.Ylblshuoshuo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "说说：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "个人说明：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "密码：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(344, 22);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // txtShuoshuo
            // 
            this.txtShuoshuo.Location = new System.Drawing.Point(28, 152);
            this.txtShuoshuo.Multiline = true;
            this.txtShuoshuo.Name = "txtShuoshuo";
            this.txtShuoshuo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShuoshuo.Size = new System.Drawing.Size(416, 48);
            this.txtShuoshuo.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(28, 242);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(416, 48);
            this.txtDescription.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(482, 243);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(69, 47);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "注册";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(73, 70);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(100, 20);
            this.cmbSex.TabIndex = 13;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(344, 73);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(100, 21);
            this.dtpBirthday.TabIndex = 14;
            // 
            // Ylblname
            // 
            this.Ylblname.AutoSize = true;
            this.Ylblname.ForeColor = System.Drawing.Color.Red;
            this.Ylblname.Location = new System.Drawing.Point(191, 30);
            this.Ylblname.Name = "Ylblname";
            this.Ylblname.Size = new System.Drawing.Size(0, 12);
            this.Ylblname.TabIndex = 15;
            // 
            // Ylblpassword
            // 
            this.Ylblpassword.AutoSize = true;
            this.Ylblpassword.ForeColor = System.Drawing.Color.Red;
            this.Ylblpassword.Location = new System.Drawing.Point(462, 25);
            this.Ylblpassword.Name = "Ylblpassword";
            this.Ylblpassword.Size = new System.Drawing.Size(0, 12);
            this.Ylblpassword.TabIndex = 16;
            // 
            // Ylblsex
            // 
            this.Ylblsex.AutoSize = true;
            this.Ylblsex.ForeColor = System.Drawing.Color.Red;
            this.Ylblsex.Location = new System.Drawing.Point(191, 73);
            this.Ylblsex.Name = "Ylblsex";
            this.Ylblsex.Size = new System.Drawing.Size(0, 12);
            this.Ylblsex.TabIndex = 17;
            // 
            // Ylblbirthday
            // 
            this.Ylblbirthday.AutoSize = true;
            this.Ylblbirthday.ForeColor = System.Drawing.Color.Red;
            this.Ylblbirthday.Location = new System.Drawing.Point(462, 73);
            this.Ylblbirthday.Name = "Ylblbirthday";
            this.Ylblbirthday.Size = new System.Drawing.Size(0, 12);
            this.Ylblbirthday.TabIndex = 18;
            // 
            // Ylblshuoshuo
            // 
            this.Ylblshuoshuo.AutoSize = true;
            this.Ylblshuoshuo.ForeColor = System.Drawing.Color.Red;
            this.Ylblshuoshuo.Location = new System.Drawing.Point(462, 170);
            this.Ylblshuoshuo.Name = "Ylblshuoshuo";
            this.Ylblshuoshuo.Size = new System.Drawing.Size(0, 12);
            this.Ylblshuoshuo.TabIndex = 19;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 302);
            this.Controls.Add(this.Ylblshuoshuo);
            this.Controls.Add(this.Ylblbirthday);
            this.Controls.Add(this.Ylblsex);
            this.Controls.Add(this.Ylblpassword);
            this.Controls.Add(this.Ylblname);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtShuoshuo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加用户";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtShuoshuo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label Ylblname;
        private System.Windows.Forms.Label Ylblpassword;
        private System.Windows.Forms.Label Ylblsex;
        private System.Windows.Forms.Label Ylblbirthday;
        private System.Windows.Forms.Label Ylblshuoshuo;
    }
}