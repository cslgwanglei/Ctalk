namespace CSLG.CTalk.UI
{
    partial class FrmShowMSG
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
            this.picImageHead = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMSG = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbok = new System.Windows.Forms.RadioButton();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.rbhulue = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImageHead)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageHead
            // 
            this.picImageHead.Location = new System.Drawing.Point(7, 7);
            this.picImageHead.Name = "picImageHead";
            this.picImageHead.Size = new System.Drawing.Size(80, 80);
            this.picImageHead.TabIndex = 0;
            this.picImageHead.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 133);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 12);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "label1";
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Location = new System.Drawing.Point(129, 21);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(65, 12);
            this.lblMSG.TabIndex = 3;
            this.lblMSG.Text = "请求消息：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(204, 280);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnIgnore
            // 
            this.btnIgnore.Location = new System.Drawing.Point(303, 280);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(75, 23);
            this.btnIgnore.TabIndex = 5;
            this.btnIgnore.Text = "忽略";
            this.btnIgnore.UseVisualStyleBackColor = true;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 52);
            this.textBox1.TabIndex = 6;
            // 
            // rbok
            // 
            this.rbok.AutoSize = true;
            this.rbok.Location = new System.Drawing.Point(131, 128);
            this.rbok.Name = "rbok";
            this.rbok.Size = new System.Drawing.Size(47, 16);
            this.rbok.TabIndex = 7;
            this.rbok.TabStop = true;
            this.rbok.Text = "同意";
            this.rbok.UseVisualStyleBackColor = true;
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Location = new System.Drawing.Point(131, 150);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(47, 16);
            this.rbno.TabIndex = 8;
            this.rbno.TabStop = true;
            this.rbno.Text = "拒绝";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // rbhulue
            // 
            this.rbhulue.AutoSize = true;
            this.rbhulue.Location = new System.Drawing.Point(131, 172);
            this.rbhulue.Name = "rbhulue";
            this.rbhulue.Size = new System.Drawing.Size(47, 16);
            this.rbhulue.TabIndex = 9;
            this.rbhulue.TabStop = true;
            this.rbhulue.Text = "忽略";
            this.rbhulue.UseVisualStyleBackColor = true;
            // 
            // FrmShowMSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 315);
            this.Controls.Add(this.rbhulue);
            this.Controls.Add(this.rbno);
            this.Controls.Add(this.rbok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIgnore);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picImageHead);
            this.Name = "FrmShowMSG";
            this.Text = "FrmShowMSG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmShowMSG_FormClosing);
            this.Load += new System.EventHandler(this.FrmShowMSG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageHead;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbok;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RadioButton rbhulue;
    }
}