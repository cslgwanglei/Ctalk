namespace CSLG.CTalk.UI
{
    partial class FrmAddFrend
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panFriend = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbFriend = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panFriend);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.cmbFriend);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询好友";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查询群";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panFriend
            // 
            this.panFriend.AutoScroll = true;
            this.panFriend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panFriend.Location = new System.Drawing.Point(3, 46);
            this.panFriend.Name = "panFriend";
            this.panFriend.Size = new System.Drawing.Size(691, 330);
            this.panFriend.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(543, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 41);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(204, 8);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(300, 21);
            this.txtID.TabIndex = 5;
            // 
            // cmbFriend
            // 
            this.cmbFriend.FormattingEnabled = true;
            this.cmbFriend.Items.AddRange(new object[] {
            "按用户ID查询",
            "按用户NAME查询"});
            this.cmbFriend.Location = new System.Drawing.Point(26, 8);
            this.cmbFriend.Name = "cmbFriend";
            this.cmbFriend.Size = new System.Drawing.Size(124, 20);
            this.cmbFriend.TabIndex = 4;
            this.cmbFriend.Text = "按用户ID查询";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 21);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "按用户ID查询",
            "按用户NAME查询"});
            this.comboBox1.Location = new System.Drawing.Point(55, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "按用户ID查询";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 318);
            this.panel1.TabIndex = 10;
            // 
            // FrmAddFrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAddFrend";
            this.Text = "查找联系人";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddFrend_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddFrend_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panFriend;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbFriend;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}