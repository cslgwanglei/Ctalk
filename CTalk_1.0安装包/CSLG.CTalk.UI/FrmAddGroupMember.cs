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
    public partial class FrmAddGroupMember : Form
    {
        public FrmAddGroupMember()
        {
            InitializeComponent();
        }
            private Model.userInfo _user;
            FrmMain _frm;
        public FrmAddGroupMember(Model.userInfo user, FrmMain frm)
        {
            InitializeComponent();
            this._user = user;
            this._frm = frm;
        }
        List<UCGroup> uc = new List<UCGroup>();
        List<Model.groupu> groupfriend = new List<Model.groupu>();
        private void FrmAddGroupMember_Load(object sender, EventArgs e)
        {
            BLL.groupu bll = new BLL.groupu();
            groupfriend = bll.GetModelList("groupuserID=" + this._user.userID);
            this.Text = this._user.userID + "添加群联系人到群"+groupfriend[1].groupID ;
            GetFriend();
          
        }
        private void GetFriend()
        {
            int i = 0;
            FrmMain frm = new FrmMain();
            this.panel1.Controls.Clear();
            BLL.userInfo bll = new BLL.userInfo();
            List<Model.userInfo> muser = bll.GetModelList("userID like'%" + this.txtsearch.Text + "%'");
            int indext = 0;
            foreach (Model.userInfo m in muser)
            {
                foreach (Model.groupu  mg in groupfriend )
                {
                    if (m.userID==mg.groupfriendID )
                    {
                        i++;
                    }
                }

                if (i==0)
                {
                    UCGroup ucg = new UCGroup();
                    ucg.Top = ucg.Height * indext;
                    ucg.Id1 = m.userID;
                    ucg.Username = m.userName;
                    ucg.IsChouse = false;
                    ucg.HeadImage = frm.imageList1.Images[Convert.ToInt32(m.userHeadImage)];
                    ucg.Headimageindex = Convert.ToInt32(m.userHeadImage);
                    ucg.MouseDoubleClick += new MouseEventHandler(ucg_MouseDoubleClick);
                    indext++;
                    uc.Add(ucg);
                    this.panel1.Controls.Add(ucg);
                
                }
                i = 0;
               
            }
        }
        UCGroup temp = new UCGroup();
        int tempindex = 0;
        void ucg_MouseDoubleClick(object o, MouseEventArgs e)
        {
            UCGroup u = (UCGroup)o;
            if (u.IsChouse == false)
            {
                temp = u;
                temp.IsChouse = true;
                temp.Top = temp.Height * tempindex;
                tempindex++;
                this.panel2.Controls.Add(temp);

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
                if (m.IsChouse == false)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetFriend();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.groupu bll = new BLL.groupu();
            Model.groupu mgroup = new Model.groupu();
            foreach (UCGroup f in uc)
            {
                if (f.Id1 == this._user.userID && f.IsChouse == false)
                {
                    f.IsChouse = true;
                }
                if (f.IsChouse == true)
                {
                    mgroup.groupImage = groupfriend[0].groupImage ;
                    mgroup.groupID =groupfriend[0].groupID ;
                    mgroup.groupAnnouncement = groupfriend[0].groupAnnouncement ;
                    mgroup.groupfriendID = f.Id1;
                    mgroup.groupName =groupfriend[0].groupName ;
                    mgroup.groupuserID = this._user.userID;
                    bll.Add(mgroup);
                }

            }
            MessageBox.Show("添加成功！");
            this.Close();
            this._frm.getGroupList();
        }

    }
}
