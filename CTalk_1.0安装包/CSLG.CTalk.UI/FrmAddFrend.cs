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
    public partial class FrmAddFrend : Form
    {
        public FrmAddFrend()
        {
            InitializeComponent();
        }
        FrmMain _frm;
        Model.userInfo _user;
  
     
        public FrmAddFrend(FrmMain frm,Model.userInfo user)
        {
            InitializeComponent();
            this._frm = frm;
            this._user = user;
        }
        private List<UCFriendSearchList> ucflFriend = new List<UCFriendSearchList>();
        private void FrmAddFrend_Load(object sender, EventArgs e)
        {
            this.Text = this._user.userID.ToString()+"查找联系人";
           
           
        }



        void uc_MouseEnter(object sender, EventArgs e)
        {
            UCFriendSearchList uc = (UCFriendSearchList)sender;
            foreach (UCFriendSearchList ucfl in ucflFriend)
            {
                ucfl.pncontrol.Visible = false;
            }
            uc.pncontrol.Visible = true;
        }

        private void FrmAddFrend_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._frm.panel1.Controls.Clear();
            this._frm.getFriendList();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            this.panFriend.Controls.Clear();

            if (cmbFriend.Text == "按用户ID查询")
            {
                BLL.userInfo blluser = new BLL.userInfo();
                List<Model.userInfo> alluser = blluser.GetModelList("userID like'%" + this.txtID.Text + "%'");
                int index = 0;


                for (int j = 0; j < alluser.Count; j++)
                {
                    int i = 0;
                    BLL.friendInfo bll = new BLL.friendInfo();
                    List<Model.friendInfo> userfriend = bll.GetModelList(" userID= " + this._user.userID);
                    List<Model.friendInfo> friend = bll.GetModelList(" userID= " + alluser[j].userID);
                    foreach (Model.friendInfo uf in userfriend)
                    {
                        foreach (Model.friendInfo f in friend)
                        {
                            if (uf.friendID == f.friendID)
                            {
                                i++;
                            }

                        }
                    }

                    UCFriendSearchList uc = new UCFriendSearchList();
                    uc.MouseEnter += new EventHandler(uc_MouseEnter);
                    uc.Top = j / 3 * uc.Height;
                    uc.Left = j % 3 * uc.Width;
                    uc.HeadImage = this._frm.imageList1.Images[Convert.ToInt16(alluser[j].userHeadImage)];
                    uc.UserID = alluser[j].userID;
                    uc.UserName = alluser[j].userName;
                    uc.Iname = this._user.userName;
                    uc.Id = this._user.userID;
                    uc.SameFriend = i;
                    uc.Iimage = this._frm.imageList1.Images[Convert.ToInt16(this._user.userHeadImage)];
                    uc.FrmtalkIsOpen = false;
                    ucflFriend.Add(uc);
                    ;
                    this.panFriend.Controls.Add(uc);
                    index++;
                }




            }
            if (cmbFriend.Text == "按用户NAME查询")
            {
                BLL.userInfo blluser = new BLL.userInfo();
                List<Model.userInfo> alluser = blluser.GetModelList("userName like'%" + this.txtID.Text + "%'");
                int index = 0;

                for (int j = 0; j < alluser.Count; j++)
                {
                    int i = 0;
                    BLL.friendInfo bll = new BLL.friendInfo();
                    List<Model.friendInfo> userfriend = bll.GetModelList(" userID= " + this._user.userID);
                    List<Model.friendInfo> friend = bll.GetModelList(" userID= " + alluser[j].userID);
                    foreach (Model.friendInfo uf in userfriend)
                    {
                        foreach (Model.friendInfo f in friend)
                        {
                            if (uf.friendID == f.friendID)
                            {
                                i++;
                            }

                        }
                    }

                    UCFriendSearchList uc = new UCFriendSearchList();
                    uc.MouseEnter += new EventHandler(uc_MouseEnter);
                    uc.Top = j / 3 * uc.Height;
                    uc.Left = j % 3 * uc.Width;
                    uc.HeadImage = this._frm.imageList1.Images[Convert.ToInt16(alluser[j].userHeadImage)];
                    uc.UserID = alluser[j].userID;
                    uc.UserName = alluser[j].userName;
                    uc.Id = this._user.userID;
                    uc.Iname = this._user.userName;
                    uc.SameFriend = i;
                    uc.Iimage = this._frm.imageList1.Images[Convert.ToInt16(this._user.userHeadImage)];
                    uc.FrmtalkIsOpen = false;
                    ucflFriend.Add(uc);
                    this.panFriend.Controls.Add(uc);
                    index++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1 .Controls.Clear();
            int gid=0;
            int z = 0;
            if (cmbFriend.Text == "按用户ID查询")
            {
                BLL.groupu blluser = new BLL.groupu();
                List<Model.groupu> alluser = blluser.GetModelList("groupID like'%" + this.textBox1 .Text + "%'");
                for (int i = 0; i < alluser.Count ; i++)
                {
                    if (gid != alluser[i].groupID)
                    {
                        UCGroupSearch uc = new UCGroupSearch();
                        uc.Top =z / 3 * uc.Height;
                        uc.Left = z % 3 * uc.Width;
                        uc.GroupID = alluser[i].groupID;
                        uc.GroupImage = alluser[i].groupImage;
                        uc.GroupName = alluser[i].groupName;
                        uc.GroupuserID = alluser[i].groupuserID;
                        uc.FriendID = this._user.userID;
                        this.panel1.Controls.Add(uc);
                        gid = alluser[i].groupID;
                       z++;
                    }
                 
                }
               
              

         

            }
            if (cmbFriend.Text == "按用户NAME查询")
            {
                BLL.userInfo blluser = new BLL.userInfo();
                List<Model.userInfo> alluser = blluser.GetModelList("userName like'%" + this.txtID.Text + "%'");
                int index = 0;

                for (int j = 0; j < alluser.Count; j++)
                {
                    int i = 0;
                    BLL.friendInfo bll = new BLL.friendInfo();
                    List<Model.friendInfo> userfriend = bll.GetModelList(" userID= " + this._user.userID);
                    List<Model.friendInfo> friend = bll.GetModelList(" userID= " + alluser[j].userID);
                    foreach (Model.friendInfo uf in userfriend)
                    {
                        foreach (Model.friendInfo f in friend)
                        {
                            if (uf.friendID == f.friendID)
                            {
                                i++;
                            }

                        }
                    }

                    UCFriendSearchList uc = new UCFriendSearchList();
                    uc.MouseEnter += new EventHandler(uc_MouseEnter);
                    uc.Top = j / 3 * uc.Height;
                    uc.Left = j % 3 * uc.Width;
                    uc.HeadImage = this._frm.imageList1.Images[Convert.ToInt16(alluser[j].userHeadImage)];
                    uc.UserID = alluser[j].userID;
                    uc.UserName = alluser[j].userName;
                    uc.Id = this._user.userID;
                    uc.Iname = this._user.userName;
                    uc.SameFriend = i;
                    uc.Iimage = this._frm.imageList1.Images[Convert.ToInt16(this._user.userHeadImage)];
                    uc.FrmtalkIsOpen = false;
                    ucflFriend.Add(uc);
                    this.panFriend.Controls.Add(uc);
                    index++;
                }
            }
        }
    }
}
