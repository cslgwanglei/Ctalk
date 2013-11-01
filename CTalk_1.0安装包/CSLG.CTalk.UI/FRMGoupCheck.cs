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
    public partial class FRMGoupCheck : Form
    {
        public FRMGoupCheck()
        {
            InitializeComponent();
        }
        private int _friendid;
        private int _groupid;
        private int _groupimage;
        private int _groupuserid;
        private string _groupname;

        public FRMGoupCheck(int  FriendID,int  GroupImage ,int  GroupID ,int GroupuserID ,string  GroupName)
        {
            InitializeComponent();
            this._friendid = FriendID;
            this._groupid = GroupID;
            this._groupimage = GroupImage;
            this._groupuserid = GroupuserID;
            this._groupname = GroupName;
        }

        private void FRMGoupCheck_Load(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.pictureBox1.Image = frm.imageList1.Images[_groupimage ];
            this.label1.Text = "您申请加入群" +" :"+ _groupname +"(" + _groupid + ")";
            this.label2.Text = "创建人"+_groupuserid ;
            this.Text = this._friendid + "添加群";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Model.friendRequest mf = new Model.friendRequest();
            mf.senderID = this._friendid ;
            mf.receiveID = this._groupid  ;
            mf.ValidationInfo = this.textBox1 .Text;
            mf.ValidationTime = DateTime.Now;
            mf.NumOfSameFriend = 0;
            mf.Station = 1;
           
            BLL.friendRequest bllfriend = new BLL.friendRequest();
            bllfriend.Add(mf);
            this.Close();
        }
    }
}
