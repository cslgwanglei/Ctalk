namespace CSLG.CTalk.UI
{
    partial class FrmAddMsg
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
            this.picHeadImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblValidation = new System.Windows.Forms.Label();
            this.txtValidation = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNickName = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeadImage
            // 
            this.picHeadImage.Location = new System.Drawing.Point(16, 18);
            this.picHeadImage.Name = "picHeadImage";
            this.picHeadImage.Size = new System.Drawing.Size(80, 80);
            this.picHeadImage.TabIndex = 0;
            this.picHeadImage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 149);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 12);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "label1";
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Location = new System.Drawing.Point(156, 18);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(101, 12);
            this.lblValidation.TabIndex = 3;
            this.lblValidation.Text = "请输入验证消息：";
            // 
            // txtValidation
            // 
            this.txtValidation.Location = new System.Drawing.Point(158, 42);
            this.txtValidation.Multiline = true;
            this.txtValidation.Name = "txtValidation";
            this.txtValidation.Size = new System.Drawing.Size(218, 75);
            this.txtValidation.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(182, 210);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(284, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(167, 18);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(53, 12);
            this.lblNickName.TabIndex = 7;
            this.lblNickName.Text = "备注名称";
            this.lblNickName.Visible = false;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(259, 18);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(100, 21);
            this.txtNickname.TabIndex = 8;
            this.txtNickname.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(365, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "完成";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmAddMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 244);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtValidation);
            this.Controls.Add(this.lblValidation);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picHeadImage);
            this.Name = "FrmAddMsg";
            this.Text = "FrmAddMsg";
            this.Load += new System.EventHandler(this.FrmAddMsg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeadImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.TextBox txtValidation;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Button btnOK;
    }
}