namespace CSLG.CTalk.UI
{
    partial class UCFriendSearchList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFriendSearchList));
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.picadd = new System.Windows.Forms.PictureBox();
            this.pictalk = new System.Windows.Forms.PictureBox();
            this.pncontrol = new System.Windows.Forms.Panel();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictalk)).BeginInit();
            this.pncontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(99, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 12);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(99, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(3, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(67, 63);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // picadd
            // 
            this.picadd.BackColor = System.Drawing.Color.Transparent;
            this.picadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picadd.BackgroundImage")));
            this.picadd.Location = new System.Drawing.Point(4, 2);
            this.picadd.Name = "picadd";
            this.picadd.Size = new System.Drawing.Size(33, 33);
            this.picadd.TabIndex = 4;
            this.picadd.TabStop = false;
            this.picadd.Click += new System.EventHandler(this.picadd_Click);
            this.picadd.MouseEnter += new System.EventHandler(this.picadd_MouseEnter);
            this.picadd.MouseLeave += new System.EventHandler(this.picadd_MouseLeave);
            // 
            // pictalk
            // 
            this.pictalk.BackColor = System.Drawing.Color.Transparent;
            this.pictalk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictalk.BackgroundImage")));
            this.pictalk.Location = new System.Drawing.Point(44, 4);
            this.pictalk.Name = "pictalk";
            this.pictalk.Size = new System.Drawing.Size(33, 33);
            this.pictalk.TabIndex = 5;
            this.pictalk.TabStop = false;
            this.pictalk.Click += new System.EventHandler(this.pictalk_Click);
            this.pictalk.MouseEnter += new System.EventHandler(this.pictalk_MouseEnter);
            this.pictalk.MouseLeave += new System.EventHandler(this.pictalk_MouseLeave);
            // 
            // pncontrol
            // 
            this.pncontrol.Controls.Add(this.pictalk);
            this.pncontrol.Controls.Add(this.picadd);
            this.pncontrol.Location = new System.Drawing.Point(0, 68);
            this.pncontrol.Name = "pncontrol";
            this.pncontrol.Size = new System.Drawing.Size(216, 37);
            this.pncontrol.TabIndex = 6;
            this.pncontrol.Visible = false;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "122.png");
            this.imgList.Images.SetKeyName(1, "lumaqq.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // UCFriendSearchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pncontrol);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "UCFriendSearchList";
            this.Size = new System.Drawing.Size(216, 105);
            this.Load += new System.EventHandler(this.UCFriendSearchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictalk)).EndInit();
            this.pncontrol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.PictureBox picadd;
        private System.Windows.Forms.PictureBox pictalk;
        public  System.Windows.Forms.Panel pncontrol;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Label label1;
    }
}
