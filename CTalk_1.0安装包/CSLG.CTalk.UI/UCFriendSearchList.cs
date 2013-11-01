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
    public partial class UCFriendSearchList : UserControl
    {
        public UCFriendSearchList()
        {
            InitializeComponent();
        }
         
      

        private Image _headImage;
      
        public Image HeadImage
        {
            get { return _headImage; }
            set { _headImage = value;
            this.picImage.Image  = _headImage;
            }
        }
        private string _userName;
        private string _iname;

        public string Iname
        {
            get { return _iname; }
            set { _iname = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value;
            this.lblName.Text = _userName;
                }
        }
        private int _userID;
        private Image _iimage;

        public Image Iimage
        {
            get { return _iimage; }
            set { _iimage = value; }
        }
        private bool _frmtalkIsOpen;

        public bool FrmtalkIsOpen
        {
            get { return _frmtalkIsOpen; }
            set { _frmtalkIsOpen = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int UserID
        {
            get { return _userID; }
            set { _userID = value;
            this.lblID.Text = _userID.ToString();
                }
        }
        private int _sameFriend;

        public int SameFriend
        {
            get { return _sameFriend; }
            set { _sameFriend = value;
            this.label1.Text = "有" + _sameFriend.ToString() + "个共同好友";
            }
        }
        private void UCFriendSearchList_Load(object sender, EventArgs e)
        {
            this.pncontrol.BackColor = Color.Blue;
        }
        private int i = 0;
   
  
     

        private void picadd_Click(object sender, EventArgs e)
        {


            BLL.friendInfo bllFriend = new BLL.friendInfo();
            List<Model.friendInfo> myFriends = bllFriend.GetModelList("userID =" + id);
            if (myFriends.Count == 0)
            {
              
                FrmAddMsg frm = new FrmAddMsg(id,UserID,HeadImage,UserName,SameFriend );
                frm.Show();
            }
            else
            {
                foreach (Model.friendInfo f in myFriends)
                {
                    if (f.friendID == UserID)
                    {
                        i++;

                    }

                }
                if (i == 0)
                {
                    
                    FrmAddMsg frm = new FrmAddMsg(id, UserID, HeadImage, UserName,SameFriend );
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("已是您的好友，请勿重复添加！");
                }

            }
        }

        private void picadd_MouseEnter(object sender, EventArgs e)
        {
            this.picadd.Image=this.imgList.Images[0];
        }

        private void picadd_MouseLeave(object sender, EventArgs e)
        {
            this.picadd.Image = null;
        }

        private void pictalk_MouseEnter(object sender, EventArgs e)
        {
            this.pictalk .Image = this.imgList.Images[1];
        }

        private void pictalk_MouseLeave(object sender, EventArgs e)
        {
            this.pictalk.Image = null;
        }

        private void pictalk_Click(object sender, EventArgs e)
        {
            if (this.FrmtalkIsOpen==true )
            {
                return;
            }
            FrmTalk frm = new FrmTalk(HeadImage,Iimage ,UserID,id,UserName,_frmtalkIsOpen ,Iname );
            frm.Show();
            this._frmtalkIsOpen = true;
        }


           
    }
}
