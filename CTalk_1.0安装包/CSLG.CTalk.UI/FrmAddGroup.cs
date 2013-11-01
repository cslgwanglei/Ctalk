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
    public partial class FrmAddGroup : Form
    {
        public FrmAddGroup()
        {
            InitializeComponent();
        }
        private Model.userInfo _user;
        FrmMain _frm;
        public FrmAddGroup(Model.userInfo user,FrmMain frm)
        {
            InitializeComponent();
            this._user = user;
            this._frm = frm;
        }
        List<UCGroup> uc = new List<UCGroup>();
        int groupID;
        private void FrmAddGroup_Load(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            groupID = this._user.userID + 9999;
            this.Text = "您群的ID为"+groupID;
            this.comboBox1 .Items.Clear();
            for (int i = 1; i <= frm.imageList1.Images.Count; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
            }
            this.comboBox1.Text = (Convert.ToInt32(this._user.userHeadImage) + 1).ToString();
            GetFriend();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.pictureBox1.Image = frm.imageList1.Images[this.comboBox1.SelectedIndex];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            GetFriend();
        }

        private void GetFriend()
        {
            FrmMain frm = new FrmMain();
            this.panel1.Controls.Clear();
            BLL.userInfo bll = new BLL.userInfo();
            List<Model.userInfo> muser = bll.GetModelList("userID like'%" + this.txtsearch.Text + "%'");
            int indext = 0;
            foreach (Model.userInfo m in muser)
            {
                UCGroup ucg = new UCGroup();
                ucg.Top = ucg.Height * indext;
                ucg.Id1 = m.userID;
                ucg.Username = m.userName;
                ucg.IsChouse = false;
                ucg.HeadImage=frm.imageList1.Images[Convert.ToInt32(m.userHeadImage )];
                ucg.Headimageindex = Convert.ToInt32(m.userHeadImage);
                ucg.MouseDoubleClick += new MouseEventHandler(ucg_MouseDoubleClick);
                indext++;
                uc.Add(ucg);
                this.panel1.Controls.Add(ucg);
            }
        }
        UCGroup temp = new UCGroup();
        int tempindex=0;
        void ucg_MouseDoubleClick(object o, MouseEventArgs e)
        {
            UCGroup u = (UCGroup)o;
            if (u.IsChouse ==false )
            {
                temp = u;
                temp.IsChouse = true;
                temp.Top = temp.Height  * tempindex;
                tempindex++;
                this.panel2.Controls.Add(temp );
               
            }
            else
            {
                u.IsChouse = false;
                tempindex--;
                FreshChosed();
            }

            FreshnoChosed();
           
        }
        private void FreshnoChosed()
        {
            this.panel1.Controls.Clear();
            int x = 0;
            foreach (UCGroup m in uc)
            {
                if (m.IsChouse == false )
                {
                    m.Top = m.Height * x;
                    this.panel1.Controls.Add(m);
                    x++;
                }
            }
        }

        private void FreshChosed()
        {
            this.panel2.Controls.Clear();
            int x = 0;
            foreach (UCGroup m in uc)
            {
                if (m.IsChouse == true)
                {
                    m.Top = m.Height * x;
                    this.panel2.Controls.Add(m);
                    x++;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BLL.groupu bll = new BLL.groupu();
            Model.groupu mgroup = new Model.groupu();
            if (this.txtgroupname.Text=="")
            {
                MessageBox.Show("群名称不能为空！");
                return;
            }
            foreach (UCGroup  f in uc )
            {
                if (f.Id1==this._user .userID&&f.IsChouse==false  )
                {
                    f.IsChouse = true;
                }
                if (f.IsChouse ==true )
                {
                    mgroup.groupImage = Convert.ToInt32( this.comboBox1.Text) ;
                    mgroup.groupID = groupID;
                    mgroup.groupAnnouncement = this.textBox1.Text;
                    mgroup.groupfriendID = f.Id1;
                    mgroup.groupName = this.txtgroupname.Text;
                    mgroup.groupuserID = this._user.userID;
                    bll.Add(mgroup);
                }
              
            }
            MessageBox.Show("创建成功！");
            this.Close();
            this._frm.getGroupList();
        }
    }
}
