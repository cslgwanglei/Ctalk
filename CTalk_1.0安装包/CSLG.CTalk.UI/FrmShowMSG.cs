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
    public partial class FrmShowMSG : Form
    {
        public FrmShowMSG()
        {
            InitializeComponent();
        }
        Model.friendRequest _frmr;
        FrmMain _frm;
        public FrmShowMSG(Model.friendRequest friendrequest,FrmMain frm)
        {
            InitializeComponent();
            this._frmr = friendrequest;
            this._frm = frm;
        }
        private Model.userInfo _user;
        private void FrmShowMSG_Load(object sender, EventArgs e)
        {   FrmMain frm=new FrmMain();
            BLL.userInfo bll = new BLL.userInfo();
            _user = bll.GetModel( this._frmr.senderID );
            this.picImageHead.Image =frm.imageList1.Images[Convert.ToInt32(_user.userHeadImage )];
            this.lblName.Text = _user.userName;
            this.lblID.Text = _user.userID.ToString();
            this.textBox1.Text = this._frmr.ValidationInfo;
 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbok.Checked==true )
            {    BLL.friendRequest bll = new BLL.friendRequest();
                 Model.friendRequest mf = new Model.friendRequest();
                mf.ID = this._frmr .ID;
                mf.NickName = this._frmr.NickName;
                mf.NumOfSameFriend = this._frmr.NumOfSameFriend;
                mf.receiveID = this._frmr.receiveID;
                mf.senderID = this._frmr.senderID;
                mf.ValidationInfo = this._frmr.ValidationInfo;
                mf.ValidationTime = this._frmr.ValidationTime;
                mf.Station = 2;
                bll.Update(mf);
                BLL.friendInfo bff = new BLL.friendInfo();
                Model.friendInfo m = new Model.friendInfo();
                m.friendID = this._frmr.senderID;
                m.userID = this._frmr.receiveID;
                m.friendName = this._user.userName;
                bff.Add(m);
                m.friendID = this._frmr.receiveID ;
                m.userID = this._frmr.senderID ;
                m.friendName = this._frmr.NickName;
                bff.Add(m);
                this.Close();
            }
            if (rbno.Checked==true )
            {
                BLL.friendRequest bll = new BLL.friendRequest();
                 Model.friendRequest mf = new Model.friendRequest();
                mf.ID = this._frmr .ID;
                mf.NickName = this._frmr.NickName;
                mf.NumOfSameFriend = this._frmr.NumOfSameFriend;
                mf.receiveID = this._frmr.receiveID;
                mf.senderID = this._frmr.senderID;
                mf.ValidationInfo = this._frmr.ValidationInfo;
                mf.ValidationTime = this._frmr.ValidationTime;
                mf.Station = 3;
                bll.Update(mf);
                this.Close ();
            }
            if (rbhulue.Checked==true )
            {
                BLL.friendRequest bll = new BLL.friendRequest();
                 Model.friendRequest mf = new Model.friendRequest();
                mf.ID = this._frmr .ID;
                mf.NickName = this._frmr.NickName;
                mf.NumOfSameFriend = this._frmr.NumOfSameFriend;
                mf.receiveID = this._frmr.receiveID;
                mf.senderID = this._frmr.senderID;
                mf.ValidationInfo = this._frmr.ValidationInfo;
                mf.ValidationTime = this._frmr.ValidationTime;
                mf.Station = 4;
                bll.Update(mf);
                this.Close();
            }
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {

            BLL.friendRequest bll = new BLL.friendRequest();
            Model.friendRequest mf = new Model.friendRequest();
            mf.ID = this._frmr.ID;
            mf.NickName = this._frmr.NickName;
            mf.NumOfSameFriend = this._frmr.NumOfSameFriend;
            mf.receiveID = this._frmr.receiveID;
            mf.senderID = this._frmr.senderID;
            mf.ValidationInfo = this._frmr.ValidationInfo;
            mf.ValidationTime = this._frmr.ValidationTime;
            mf.Station = 4;
            bll.Update(mf);
            this.Close();
        }

        private void FrmShowMSG_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frm.panel1.Controls.Clear();
            this._frm.getFriendList();
        }
    }
}
