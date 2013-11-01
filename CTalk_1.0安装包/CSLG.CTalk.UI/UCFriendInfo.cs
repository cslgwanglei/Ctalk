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
    public partial class UCFriendInfo : UserControl
    {
        public UCFriendInfo()
        {
            InitializeComponent();
        }
        private Model.userInfo _user;
        private  FrmMain _frm;
        public UCFriendInfo(Model.userInfo user,FrmMain frm)
        {
            InitializeComponent();
            this._user = user;
            this._frm = frm;
        }
        public delegate void delDBClick(object sender, EventArgs e);
        private int _headImageLeft;
        private int _headImageTop;
        public event delDBClick myDBClick;
        private void UCFriendInfo_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
            _headImageLeft = this.UCpcb.Left ;
            _headImageTop = this.UCpcb.Top;
        }
        private Image _headImage;
        private string _userName;
        private string _userShuoshuo;
        private int _userID;
        private int _fID;

        public int FID
        {
            get { return _fID; }
            set { _fID = value; }
        }
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        public string UserShuoshuo
        {
            get { return _userShuoshuo; }
            set
            { 
                _userShuoshuo = value;
                this.uclblshuoshuo.Text = _userShuoshuo;
            }
        }
        public string UserName
        {
            get { return _userName; }
            set { 
                _userName = value;
                this.uclblname.Text  = _userName;
            }
        }
        public Image HeadImage
        {
            get { return _headImage; }
            set { 
                _headImage = value;
                this.UCpcb.Image = _headImage;
            }
        }
        
       
        private int flag=0;
        public void ImageJump()
        { 
            int temp = flag % 4;
         
            if (temp==0)
            {
                this.UCpcb.Left = _headImageLeft - 2;
                this.UCpcb.Top = _headImageTop + 3;
            }
            
             if (temp==1)
            {
            this.UCpcb.Left = _headImageLeft;
            this.UCpcb.Top = _headImageTop;
             }
             if (temp==2)
            {
            this.UCpcb.Left = _headImageLeft + 2;
            this.UCpcb.Top = _headImageTop + 3;
             }
             if (temp == 3)
             {
           this.UCpcb.Left = _headImageLeft;
           this.UCpcb.Top = _headImageTop;
                
             }
      flag++; 
    
   }
        private void UCFriendInfo_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;

        }

        private void UCFriendInfo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
        }

        private void UCFriendInfo_Click(object sender, EventArgs e)
        {

        }
        private void UCpcb_DoubleClick(object sender, EventArgs e)
        {
            this.myDBClick(this,e);
        }

        private void uclblname_DoubleClick(object sender, EventArgs e)
        {
            this.myDBClick(this, e);
        }

        private void uclblshuoshuo_DoubleClick(object sender, EventArgs e)
        {
            this.myDBClick(this, e);
        }

        private void UCFriendInfo_DoubleClick(object sender, EventArgs e)
        {
              this.myDBClick(this,e);
        }

        private void uclblname_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
        }

        private void uclblshuoshuo_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
        }

        private void UCpcb_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
        }
        private Model.userInfo _friendInfo;

        public Model.userInfo FriendInfo
        {
            get { return _friendInfo; }
            set { _friendInfo = value; }
        }
        private string _nickName;

        public string NickName
        {
            get { return _nickName; }
            set { _nickName = value; }
        }

        public void tmJump_Tick(object sender, EventArgs e)
        {
          
            
        }
    }
}
