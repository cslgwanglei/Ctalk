namespace CSLG.CTalk.UI
{
    partial class FrmGroupTalk
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
            this.components = new System.ComponentModel.Container();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmessge = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtinfo = new System.Windows.Forms.RichTextBox();
            this.timergroup = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(313, 17);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(147, 100);
            this.textBox2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(314, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 193);
            this.panel1.TabIndex = 2;
            // 
            // txtmessge
            // 
            this.txtmessge.Location = new System.Drawing.Point(11, 238);
            this.txtmessge.Multiline = true;
            this.txtmessge.Name = "txtmessge";
            this.txtmessge.Size = new System.Drawing.Size(296, 53);
            this.txtmessge.TabIndex = 3;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(134, 297);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 4;
            this.btnsend.Text = "发送";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(215, 297);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "关闭";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(11, 17);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ReadOnly = true;
            this.txtinfo.Size = new System.Drawing.Size(296, 201);
            this.txtinfo.TabIndex = 6;
            this.txtinfo.Text = "";
            // 
            // timergroup
            // 
            this.timergroup.Enabled = true;
            this.timergroup.Tick += new System.EventHandler(this.timergroup_Tick);
            // 
            // FrmGroupTalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 332);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtmessge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Name = "FrmGroupTalk";
            this.Text = "FrmGroupTalk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGroupTalk_FormClosed);
            this.Load += new System.EventHandler(this.FrmGroupTalk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtmessge;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.RichTextBox txtinfo;
        private System.Windows.Forms.Timer timergroup;
    }
}