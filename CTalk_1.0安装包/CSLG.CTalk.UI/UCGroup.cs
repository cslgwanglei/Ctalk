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
    public partial class UCGroup : UserControl
    {
        public UCGroup()
        {
            InitializeComponent();
        }

        private int Id;

        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }
        private Image headImage;

        public Image HeadImage
        {
            get { return headImage; }
            set { headImage = value;
            this.pictureBox1.Image = headImage;
            }
        }
        private bool isChouse;

        public bool IsChouse
        {
            get { return isChouse; }
            set { isChouse = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private int headimageindex;

        public int Headimageindex
        {
            get { return headimageindex; }
            set { headimageindex = value; }
        }
        private void UCGroup_Load(object sender, EventArgs e)
        {
            this.label1.Text =this.username  +"(" + this.Id + ")";
        }
    }
}
