namespace CSLG.CTalk.UI
{
    partial  class FrmTalk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTalk));
            this.txtmessge = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picFriend = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.TmPicker = new System.Windows.Forms.Timer(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtinfo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnHistory = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除此条信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除所有信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmessge
            // 
            this.txtmessge.Location = new System.Drawing.Point(5, 242);
            this.txtmessge.Multiline = true;
            this.txtmessge.Name = "txtmessge";
            this.txtmessge.Size = new System.Drawing.Size(387, 68);
            this.txtmessge.TabIndex = 0;
            this.txtmessge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmessge_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(233, 314);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picFriend
            // 
            this.picFriend.Location = new System.Drawing.Point(398, 105);
            this.picFriend.Name = "picFriend";
            this.picFriend.Size = new System.Drawing.Size(100, 93);
            this.picFriend.TabIndex = 4;
            this.picFriend.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(398, 204);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(100, 88);
            this.picUser.TabIndex = 5;
            this.picUser.TabStop = false;
            // 
            // TmPicker
            // 
            this.TmPicker.Enabled = true;
            this.TmPicker.Interval = 1000;
            this.TmPicker.Tick += new System.EventHandler(this.TmPicker_Tick);
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(5, 12);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ReadOnly = true;
            this.txtinfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtinfo.Size = new System.Drawing.Size(384, 206);
            this.txtinfo.TabIndex = 6;
            this.txtinfo.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "消息记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnHistory
            // 
            this.pnHistory.AutoScroll = true;
            this.pnHistory.Location = new System.Drawing.Point(394, 13);
            this.pnHistory.Name = "pnHistory";
            this.pnHistory.Size = new System.Drawing.Size(225, 297);
            this.pnHistory.TabIndex = 8;
            this.pnHistory.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(592, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 19);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除此条信息ToolStripMenuItem,
            this.删除所有信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // 删除此条信息ToolStripMenuItem
            // 
            this.删除此条信息ToolStripMenuItem.Name = "删除此条信息ToolStripMenuItem";
            this.删除此条信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除此条信息ToolStripMenuItem.Text = "删除此条信息";
            this.删除此条信息ToolStripMenuItem.Click += new System.EventHandler(this.删除此条信息ToolStripMenuItem_Click);
            // 
            // 删除所有信息ToolStripMenuItem
            // 
            this.删除所有信息ToolStripMenuItem.Name = "删除所有信息ToolStripMenuItem";
            this.删除所有信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除所有信息ToolStripMenuItem.Text = "删除多条信息";
            this.删除所有信息ToolStripMenuItem.Click += new System.EventHandler(this.删除所有信息ToolStripMenuItem_Click);
            // 
            // FrmTalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnHistory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picFriend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtmessge);
            this.Name = "FrmTalk";
            this.Text = "FrmTalk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTalk_FormClosed);
            this.Load += new System.EventHandler(this.FrmTalk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmessge;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picFriend;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Timer TmPicker;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.RichTextBox txtinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除此条信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除所有信息ToolStripMenuItem;
    }
}