namespace CSLG.CTalk.UI
{
    partial class SystemWarn
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
            this.lblwarn = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnignore = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwarn
            // 
            this.lblwarn.AutoSize = true;
            this.lblwarn.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblwarn.ForeColor = System.Drawing.Color.Red;
            this.lblwarn.Location = new System.Drawing.Point(38, 38);
            this.lblwarn.Name = "lblwarn";
            this.lblwarn.Size = new System.Drawing.Size(0, 21);
            this.lblwarn.TabIndex = 0;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(26, 143);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "打开";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnignore
            // 
            this.btnignore.Location = new System.Drawing.Point(107, 143);
            this.btnignore.Name = "btnignore";
            this.btnignore.Size = new System.Drawing.Size(75, 23);
            this.btnignore.TabIndex = 2;
            this.btnignore.Text = "忽略";
            this.btnignore.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(197, 143);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "关闭";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // SystemWarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnignore);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.lblwarn);
            this.Name = "SystemWarn";
            this.Text = "提示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemWarn_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SystemWarn_FormClosed);
            this.Load += new System.EventHandler(this.SystemWarn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwarn;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnignore;
        private System.Windows.Forms.Button btnclose;
    }
}