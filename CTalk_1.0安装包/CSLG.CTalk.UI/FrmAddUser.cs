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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }
        FrmLogin _frm;
        public FrmAddUser(FrmLogin frm)
        {
            InitializeComponent();
            this._frm = frm;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Ylblname.Text = "";
            this.Ylblpassword.Text = "";
            this.Ylblsex.Text = "";
            this.Ylblbirthday.Text = "";
            this.Ylblshuoshuo.Text = "";
            if (this.txtName.Text =="")
            {
                this.Ylblname.Text  = "*昵称不能为空";
                return;
            }
            if (this.txtPassword .Text == "")
            {
                this.Ylblpassword .Text = "*密码不能为空";
                return;
            }
            if (this.cmbSex.Text=="" )
            {
                this.Ylblsex.Text = "*性别不能为空";
                return;
            }
            if (this.dtpBirthday.Value>=BLL.NormalOperation.getServerTime())
            {
                this.Ylblbirthday.Text = "*时间输入不正确！";
            }
            if (this.txtShuoshuo.Text=="")
            {
                this.Ylblshuoshuo.Text = "*说说不能为空！";
                return;
            }
            BLL.userInfo blluser = new BLL.userInfo();
             Model.userInfo m = new Model.userInfo();
             m.userBirthDay = this.dtpBirthday.Value;
             m.userDescription = this.txtDescription.Text;
             m.userHeadImage =Convert.ToString("1");
             m.userName = this.txtName.Text ;
             m.userPWD = this.txtPassword.Text;
             m.userSex = this.cmbSex.Text;
             m.userShuoshuo = this.txtShuoshuo.Text;
             m.userState = 2;
             blluser.Add(m);
             MessageBox.Show("注册成功！");
             this.Close();
             this._frm.ShowList();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
           
            BLL.userInfo blluser = new BLL.userInfo();
           
            List<Model.userInfo> mu = blluser.GetModelList("");
            int userid = 0;
            userid = 10001 + mu.Count;
            this.Text = "您的ID为"+userid.ToString();
        }
    }
}
