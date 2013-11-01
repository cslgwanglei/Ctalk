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
    public partial class FrmEditInfo : Form
    {
        private Model.userInfo _user;
        private FrmMain _frm;
        public FrmEditInfo()
        {
            InitializeComponent();
        }
        public FrmEditInfo(Model.userInfo user,FrmMain frm)
        {
            InitializeComponent();
            this._user = user;
            this._frm = frm;
        }
        private void showMyInfo()
        {
            this.pictureBox1.Image=this._frm.imageList1.Images[Convert.ToInt32(this._user.userHeadImage)];
            this.lblID.Text = this._user.userID.ToString();
            this.txtName.Text = this._user.userName;
            this.dtpbirthday.Value = this._user.userBirthDay;
            this.cmbSex.Text = this._user.userSex;
            this.txtdescription.Text = this._user.userDescription;
            this.Text = this._user.userName +"的个人资料";
            this.cmbImage.Items.Clear();
            for (int i = 1; i <= this._frm.imageList1.Images.Count; i++)
            {
                this.cmbImage.Items.Add(i.ToString());
            }
            this.cmbImage.Text = (Convert.ToInt32 ( this._user.userHeadImage)+1).ToString();
        }
        private void FrmEditInfo_Load(object sender, EventArgs e)
        {
            showMyInfo();
        }

        private void cmbImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image=this._frm.imageList1.Images[this.cmbImage.SelectedIndex ];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = this.txtName.Text ;
            int newindex = Convert.ToInt32(this.cmbImage.Text)-1;
            if (username=="")
            {
                return;
                
            }
            this._user.userBirthDay = this.dtpbirthday.Value;
            this._user.userDescription = this.txtdescription.Text;
            this._user.userHeadImage = newindex.ToString();
            this._user.userName = username;
            this._user.userSex = this.cmbSex.Text;
            BLL.userInfo blluserinfo = new BLL.userInfo();
            blluserinfo.Update(this._user );
            this._frm.changeHeadImage(newindex);
            this._frm.changename(username);
            MessageBox.Show("修改成功！！");
            this.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

 
      
    }
}