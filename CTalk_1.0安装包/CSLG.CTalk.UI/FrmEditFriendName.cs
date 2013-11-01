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
    public partial class FrmEditFriendName : Form
    {
        public FrmEditFriendName()
        {
            InitializeComponent();
        }

        private int _friendID;
        private FrmMain _frm;
        private string _friendName;
        private int _userID;
        private int _fID;
        public FrmEditFriendName(string nickName,int fID,FrmMain frm,int userID,int FRIENDid)
        {
            InitializeComponent();
            this._friendName = nickName;
            this._fID  = fID ;
            this._frm = frm;
            this._userID = userID;
            this._friendID = FRIENDid;
          
        }
        private void FrmEditFriendName_Load(object sender, EventArgs e)
        {
            this.txtName.Text = this._friendName;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BLL.friendInfo bff = new BLL.friendInfo();
            Model.friendInfo mff = new Model.friendInfo();
            mff.ID = this._fID ;
            mff.friendName = this.txtName.Text ;
            mff.userID = this._userID;
            mff.friendID = this._friendID;
            bff.Update(mff);
            this.Close();
            this._frm.panel1.Controls.Clear  ();
            this._frm.getFriendList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
