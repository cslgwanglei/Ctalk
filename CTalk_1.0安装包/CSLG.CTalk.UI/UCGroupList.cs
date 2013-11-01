using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSLG.CTalk.UI
{
    public partial class UCGroupList : UserControl
    {
        public UCGroupList()
        {
            InitializeComponent();
        }
        private string groupname;

        public string Groupname
        {
            get { return groupname; }
            set { groupname = value;
            this.label1.Text = groupname;
            }
        }
        private int groupID;

        public int GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }
        private int friendID;

        public int FriendID
        {
            get { return friendID; }
            set { friendID = value; }
        }
        private Image headImage;

        public Image HeadImage
        {
            get { return headImage; }
            set { headImage = value;
            this.pictureBox1.Image = headImage;
            }
        }
        private string groupannouncement;

        public string Groupannouncement
        {
            get { return groupannouncement; }
            set { groupannouncement = value; }
        }
        private int _headImageLeft;
        private int _headImageTop;
        private void UCGroupList_Load(object sender, EventArgs e)
        {
            _headImageLeft = this.pictureBox1 .Left;
            _headImageTop = this.pictureBox1.Top;
        }
        private int flag = 0;
        public void ImageJump()
        {
            int temp = flag % 4;

            if (temp == 0)
            {
                this.pictureBox1.Left = _headImageLeft - 2;
                this.pictureBox1.Top = _headImageTop + 2;
            }

            if (temp == 1)
            {
                this.pictureBox1.Left = _headImageLeft;
                this.pictureBox1.Top = _headImageTop;
            }
            if (temp == 2)
            {
                this.pictureBox1.Left = _headImageLeft + 2;
                this.pictureBox1.Top = _headImageTop + 2;
            }
            if (temp == 3)
            {
                this.pictureBox1.Left = _headImageLeft;
                this.pictureBox1.Top = _headImageTop;

            }
            flag++;

        }
    }
}
