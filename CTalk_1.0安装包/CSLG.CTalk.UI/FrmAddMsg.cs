using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSLG.CTalk.UI
{
    public partial class FrmAddMsg : Form
    {
        public FrmAddMsg()
        {
            InitializeComponent();
        }
        int _id;
        int _userid;
        string _username;
        Image _headimage;
        int _samefriend;
        public FrmAddMsg(int id,int UserID,Image HeadImage,string  UserName ,int SameFriend)
        {
            InitializeComponent();
            this._id = id;
            this._userid = UserID;
            this._headimage = HeadImage;
            this._username = UserName;
            this._samefriend = SameFriend;
        }

        private void FrmAddMsg_Load(object sender, EventArgs e)
        {   FrmMain frm=new FrmMain();
            this.Text = this._id + "添加好友";
            this.lblName.Text = this._username;
            this.lblID.Text =Convert.ToString( this._userid) ;
            this.picHeadImage.Image=this._headimage ;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            if (this.txtValidation.Visible == false)
            {
                Model.friendRequest mf = new Model.friendRequest();
                mf.senderID = this._id;
                mf.receiveID = this._userid;
                mf.ValidationInfo = this.txtValidation.Text;
                mf.ValidationTime = DateTime.Now;
                mf.NumOfSameFriend = this._samefriend;
                mf.Station = 1;
                if (this.txtNickname.Text!="")
                {
                   mf.NickName = this.txtNickname.Text;  
                }
                else
                {
                    mf.NickName = this._username;
                }

                BLL.friendRequest bllfriend = new BLL.friendRequest();
                bllfriend.Add(mf);
                this.lblNickName.Text = "您的好友请求已经发送，正在等待对方请求确认！";
                this.txtNickname.Visible = false;
                this.btnNext.Visible = false;
                this.btnClose.Visible = false;
                this.btnOK.Visible = true;
            }
            if (this.txtValidation.Visible == true)
            {
                this.lblValidation.Visible = false;
                this.txtValidation.Visible = false;
                this.lblNickName.Visible = true;
                this.txtNickname.Visible = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
