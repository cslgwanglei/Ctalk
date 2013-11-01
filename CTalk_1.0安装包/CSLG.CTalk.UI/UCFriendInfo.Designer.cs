namespace CSLG.CTalk.UI
{
    partial class UCFriendInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UCpcb = new System.Windows.Forms.PictureBox();
            this.uclblname = new System.Windows.Forms.Label();
            this.uclblshuoshuo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UCpcb)).BeginInit();
            this.SuspendLayout();
            // 
            // UCpcb
            // 
            this.UCpcb.Location = new System.Drawing.Point(15, 11);
            this.UCpcb.Name = "UCpcb";
            this.UCpcb.Size = new System.Drawing.Size(80, 80);
            this.UCpcb.TabIndex = 0;
            this.UCpcb.TabStop = false;
            this.UCpcb.DoubleClick += new System.EventHandler(this.UCpcb_DoubleClick);
            this.UCpcb.MouseEnter += new System.EventHandler(this.UCpcb_MouseEnter);
            // 
            // uclblname
            // 
            this.uclblname.AutoSize = true;
            this.uclblname.Location = new System.Drawing.Point(110, 20);
            this.uclblname.Name = "uclblname";
            this.uclblname.Size = new System.Drawing.Size(41, 12);
            this.uclblname.TabIndex = 1;
            this.uclblname.Text = "label1";
            this.uclblname.DoubleClick += new System.EventHandler(this.uclblname_DoubleClick);
            this.uclblname.MouseEnter += new System.EventHandler(this.uclblname_MouseEnter);
            // 
            // uclblshuoshuo
            // 
            this.uclblshuoshuo.AutoSize = true;
            this.uclblshuoshuo.Location = new System.Drawing.Point(110, 51);
            this.uclblshuoshuo.Name = "uclblshuoshuo";
            this.uclblshuoshuo.Size = new System.Drawing.Size(41, 12);
            this.uclblshuoshuo.TabIndex = 2;
            this.uclblshuoshuo.Text = "label2";
            this.uclblshuoshuo.DoubleClick += new System.EventHandler(this.uclblshuoshuo_DoubleClick);
            this.uclblshuoshuo.MouseEnter += new System.EventHandler(this.uclblshuoshuo_MouseEnter);
            // 
            // UCFriendInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uclblshuoshuo);
            this.Controls.Add(this.uclblname);
            this.Controls.Add(this.UCpcb);
            this.Name = "UCFriendInfo";
            this.Size = new System.Drawing.Size(296, 103);
            this.Load += new System.EventHandler(this.UCFriendInfo_Load);
            this.Click += new System.EventHandler(this.UCFriendInfo_Click);
            this.DoubleClick += new System.EventHandler(this.UCFriendInfo_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.UCFriendInfo_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCFriendInfo_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.UCpcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UCpcb;
        private System.Windows.Forms.Label uclblname;
        private System.Windows.Forms.Label uclblshuoshuo;
    }
}
