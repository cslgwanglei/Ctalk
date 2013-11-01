using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
namespace CSLG.CTalk.UI
{
    public partial class FrmMain : Form
    {
        private Model.userInfo _user;
        private FrmLogin _frm;
        private List<RelFriendToFrmTalk> tbFriendTalkInfo = new List<RelFriendToFrmTalk>();
        private List<UCFriendInfo> ucflFriend = new List<UCFriendInfo>();
        private UCFriendInfo currentRight;
        private List<UCGroupList> ucgroupe = new List<UCGroupList>();
         public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(Model.userInfo user, FrmLogin frm)
        {
            InitializeComponent();
            this._user = user;
            this._frm = frm;
        }
        private void showMyinfo()
        {

            int headImageIndex = Convert.ToInt32(this._user.userHeadImage);
            this.picbox.Image = this.imageList1.Images[headImageIndex];
            string shuoshuo = this._user.userShuoshuo;
            this.txtshuoshuo.Text = shuoshuo;
            if (shuoshuo.Length > 12)
            {
                shuoshuo = shuoshuo.Substring(0, 10) + "...";
            }
            this.lblname.Text = this._user.userName;
            this.lblshuoshuo.Text = shuoshuo;
        }
        public void changeHeadImage(int index)
        {
            this.picbox.Image = this.imageList1.Images[index];
        }
        public void changename(string name)
        {
            this.lblname.Text = name;
        }

        private void getrecentfriend()
        {
            FileStream fs = new FileStream(Application.StartupPath + "\\" + "friend.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int index = 0;
            while (sr.Peek() > -1)
            {
                string tmp = sr.ReadLine();
                string[] res = tmp.Split(' ');

                foreach (Model.friendInfo fri in myFriends)
                {
                    if (this._user.userID == Convert.ToInt32(res[0]) && res[1] == fri.friendID.ToString())
                    {

                        BLL.friendInfo bllfrq = new BLL.friendInfo();
                        List<Model.friendInfo> bllfq = bllfrq.GetModelList("userid=" + _user.userID + "and friendid=" + Convert.ToInt32(res[1]) + "");
                        UCFriendInfo ucRecentfriend = new UCFriendInfo(_user, this);
                        BLL.userInfo frueser = new BLL.userInfo();
                        Model.userInfo u = frueser.GetModel(bllfq[0].friendID);
                        ucRecentfriend.Top = ucRecentfriend.Height * index;

                        ucRecentfriend.UserName = bllfq[0].friendName;
                        ucRecentfriend.NickName = bllfq[0].friendName;
                        ucRecentfriend.UserShuoshuo = u.userShuoshuo;
                        ucRecentfriend.FriendInfo = u;
                        ucRecentfriend.HeadImage = this.imageList1  .Images[Convert.ToInt32(u.userHeadImage)];
                        this.pnrecentfriend.Controls.Add(ucRecentfriend);
                        ucRecentfriend.MouseClick += new MouseEventHandler(ucf_MouseClick);
                        //ucRecentfriend.MouseLeave += new EventHandler(ucf_MouseLeave);
                        //ucRecentfriend.myDBClick += new UCFriendInfo.delDBClick(ucf_myDBClick);
                        //ucRecentfriend.MouseEnter += new EventHandler(ucf_MouseEnter);

                        index++;
                    }
                }
            }
            sr.Close();
            fs.Close();

        }
        void ucf_MouseClick(object o, EventArgs e) 
        {
            UCFriendInfo ucf = (UCFriendInfo)o;
            for (int i = 0; i < tbFriendTalkInfo.Count; i++)
            {
                if (tbFriendTalkInfo[i].FriendId == ucf.FriendInfo.userID)
                {
                    if (tbFriendTalkInfo[i].IsOpenTalkForm)
                    {
                        return;
                    }
                    else
                    {
                        tbFriendTalkInfo[i].IsOpenTalkForm = true;
                        break;
                    }
                }
            }


            FrmTalk frm = new FrmTalk(tbFriendTalkInfo, this, this._user, ucf.FriendInfo, ucf.NickName);
            frm.Show();
        }
        private int loginno;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.timeSystemn.Enabled = true;
            BLL.userInfo bllUserInfo = new BLL.userInfo();
            List<Model.userInfo> muer = bllUserInfo.GetModelList("");
            foreach (Model.userInfo  m in muer )
            {
                if (m.userState!=2)
                {
                    loginno++;
                }
                
            }
            this.notifyIcon1.Visible = true;
            this.Top = 0;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            showMyinfo();
            this.txtshuoshuo.Visible = false;
            getFriendList();
            this.tmPicker.Enabled = true;
            this.pictureBox22.Image = this.imageList2.Images[this._user.userState-1];
            getGroupList();
            getrecentfriend();
            BLL.groupu bll = new BLL.groupu();
            List<Model.groupu> mgroup = bll.GetModelList("groupuserID =" + this._user.userID);
            if (mgroup.Count() < 1)
            {
                this.btnAddmember.Visible = false;
                this.button2.Visible = false;
            }
        }
    
        public void getGroupList()
        {
            RelFriendToFrmTalk ft = new RelFriendToFrmTalk();
            BLL.groupu bll = new BLL.groupu();
            List<Model.groupu> grouplist = bll.GetModelList("groupfriendID="+this._user.userID.ToString());
            int index = 0;
            foreach (Model.groupu  mg in grouplist)
            {
                UCGroupList ucl = new UCGroupList();
                ucl.GroupID = mg.groupID;
                ucl.Groupname = mg.groupName;
                ucl.Top = ucl.Height * index;
                ucl.HeadImage=this.imageList1.Images[Convert.ToInt32(mg.groupImage )];
                ucl.MouseDoubleClick += new MouseEventHandler(ucl_MouseDoubleClick);
                ucl.Groupannouncement = mg.groupAnnouncement;
                ucl.FriendID = this._user.userID;
                this.panel2.Controls.Add(ucl );
                index++;

                ft.FriendId = mg.groupID ;
                ft.IsOpenTalkForm = false;
                ft.Frm = null;
                tbFriendTalkInfo.Add(ft);
                ucgroupe.Add(ucl );
            }
            
        }

        void ucl_MouseDoubleClick(object o, MouseEventArgs e)
        {
           UCGroupList uc=(UCGroupList )o ;
           for (int i = 0; i < tbFriendTalkInfo.Count; i++)
           {
               if (tbFriendTalkInfo[i].FriendId == uc.GroupID )
               {
                   if (tbFriendTalkInfo[i].IsOpenTalkForm)
                   {
                       return;
                   }
                   else
                   {
                       tbFriendTalkInfo[i].IsOpenTalkForm = true;
                       break;
                   }
               }
           }
           FrmGroupTalk frm = new FrmGroupTalk(tbFriendTalkInfo, this._user ,uc);
           frm.Show();
        }
        List<Model.friendInfo> myFriends = new List<Model.friendInfo>();
        public  void getFriendList()
        {
            BLL.friendInfo bllFriend = new BLL.friendInfo();
             myFriends = bllFriend.GetModelList("userID =" + this._user.userID.ToString());
            int index = 0;
         
            ucflFriend.Clear();
            foreach (Model.friendInfo f in myFriends)
            {    UCFriendInfo ucF = new UCFriendInfo();
                 
                 RelFriendToFrmTalk ft = new RelFriendToFrmTalk();
                 BLL.userInfo bllUserInfo = new BLL.userInfo();
                Model.userInfo friend = bllUserInfo.GetModel(f.friendID);
                if (friend.userState != 2 && friend.userState!=3)
                {
                   
                    ucF.Top = ucF.Height * index;
                    ucF.HeadImage = this.imageList1.Images[Convert.ToInt32(friend.userHeadImage)];
                    ucF.UserName = f.friendName;
                    ucF.myDBClick += new UCFriendInfo.delDBClick(ucF_myDBClick);
                    ucF.MouseClick += new MouseEventHandler(ucF_MouseClick);
                    ucF.FriendInfo = friend;
                    ucF.NickName = f.friendName;
                    ucF.UserShuoshuo = friend.userShuoshuo;
                    ucF.FID = f.ID;
                    if (ucF.UserShuoshuo.Length >= 10)
                    {
                        ucF.UserShuoshuo = ucF.UserShuoshuo.Substring(0, 10) + "...";
                    }
                    this.panel1.Controls.Add(ucF);
                    index++;
                    
                    ft.FriendId = f.friendID;
                    ft.IsOpenTalkForm = false;
                    ft.Frm = null;
                    tbFriendTalkInfo.Add(ft);
                    ucF.UserID = f.friendID;
                    ucflFriend.Add(ucF);

                }
                
            }
            foreach (Model.friendInfo f in myFriends)
            {
                UCFriendInfo ucF = new UCFriendInfo();
                RelFriendToFrmTalk ft = new RelFriendToFrmTalk();
                BLL.userInfo bllUserInfo = new BLL.userInfo();
                Model.userInfo friend = bllUserInfo.GetModel(f.friendID);
                if (friend.userState == 2||friend.userState==3)
                {

                    ucF.Top = ucF.Height * index;
                    ucF.HeadImage = this.imageList1.Images[Convert.ToInt32(friend.userHeadImage)+110];
                    ucF.UserName = f.friendName;
                    ucF.myDBClick += new UCFriendInfo.delDBClick(ucF_myDBClick);
                    ucF.MouseClick += new MouseEventHandler(ucF_MouseClick);
                    ucF.FriendInfo = friend;
                    ucF.NickName = f.friendName;
                    ucF.UserShuoshuo = friend.userShuoshuo;
                    ucF.FID = f.ID;
                    if (ucF.UserShuoshuo.Length >= 10)
                    {
                        ucF.UserShuoshuo = ucF.UserShuoshuo.Substring(0, 10) + "...";
                    }
                    this.panel1.Controls.Add(ucF);
                    index++;

                    ft.FriendId = f.friendID;
                    ft.IsOpenTalkForm = false;
                    ft.Frm = null;
                    tbFriendTalkInfo.Add(ft);
                    ucF.UserID = f.friendID;
                    ucflFriend.Add(ucF);

                }

            }
          
        }

        void ucF_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button!= System.Windows.Forms.MouseButtons.Right )
            {
                return;
            }
            currentRight = (UCFriendInfo)sender;
            this.menuFriend.Show(Control.MousePosition );
        }

        void ucF_myDBClick(object o, EventArgs e)
        {
            UCFriendInfo ucf = (UCFriendInfo)o;
            for (int i = 0; i < tbFriendTalkInfo.Count; i++)
            {
                if (tbFriendTalkInfo[i].FriendId == ucf.FriendInfo.userID)
                {
                    if (tbFriendTalkInfo[i].IsOpenTalkForm)
                    {
                        return;
                    }
                    else
                    {
                        tbFriendTalkInfo[i].IsOpenTalkForm = true;
                        break;
                    }
                }
            }


            FrmTalk frm = new FrmTalk(tbFriendTalkInfo, this, this._user, ucf.FriendInfo, ucf.NickName);
            frm.Show();
        }


        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._frm.Dispose();
            BLL.userInfo bllUserInfo = new BLL.userInfo();
            Model.userInfo user = bllUserInfo.GetModel(this._user.userID );
            user.userID = this._user.userID;
            user.userState = 2;
            bllUserInfo.Update(user);
        }

        private void lblshuoshuo_Click(object sender, EventArgs e)
        {
            this.lblshuoshuo.Visible = false;
            this.txtshuoshuo.Visible = true;
        }

        private void txtshuoshuo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                updateshuoshuo();

            }
        }

        private void updateshuoshuo()
        {
            BLL.userInfo blluserinfo = new BLL.userInfo();
            this._user.userShuoshuo = this.txtshuoshuo.Text;
            blluserinfo.Update(this._user);
            showMyinfo();
            this.lblshuoshuo.Visible = true;
            this.txtshuoshuo.Visible = false;
        }

        private void txtshuoshuo_Leave(object sender, EventArgs e)
        {
            updateshuoshuo();
        }

        private void FrmMain_Click(object sender, EventArgs e)
        {
            if (this.txtshuoshuo.Visible == true)
            {
                updateshuoshuo();
            }
        }

        private void picbox_Click(object sender, EventArgs e)
        {
            FrmEditInfo frm = new FrmEditInfo(this._user, this);
            frm.ShowDialog();
        }
        private int j = 0;
        private void tmPicker_Tick(object sender, EventArgs e)
        {

            FriendJump();

            GroupJump();
  }

        private void GroupJump()
        {
            BLL.groupMessage bllmsg = new BLL.groupMessage();
            List<Model.groupMessage> msgInfo = bllmsg.GetModelList("receiverID= '" + this._user.userID + "'and messageState=31 ");
            foreach (Model.groupMessage m in msgInfo)
            {


                foreach (RelFriendToFrmTalk ft in tbFriendTalkInfo)
                {
                    if (ft.FriendId == m.groupID)
                    {

                        if (!ft.IsOpenTalkForm)
                        {
                            foreach (UCGroupList u in ucgroupe)
                            {
                                if (u.GroupID == m.groupID)
                                {
                                    u.ImageJump();
                                }

                            }
                        }
                    }

                }


            }

        }
        

        private void FriendJump()
        {

            BLL.messsageInfo bllmsg = new BLL.messsageInfo();
            List<Model.messsageInfo> msgInfo = bllmsg.GetModelList("receiverID= '" + this._user.userID + "'and messageState=1 ");


            foreach (Model.messsageInfo m in msgInfo)
            {
                foreach (RelFriendToFrmTalk ft in tbFriendTalkInfo)
                {
                    if (ft.FriendId == m.senderID)
                    {   
                        if (!ft.IsOpenTalkForm)
                        {
                            foreach (UCFriendInfo u in ucflFriend)
                            {
                                if (u.UserID == m.senderID)
                                {
                                    u.ImageJump();
                                   

                                    if (j % 2 == 1)
                                    {
                                        this.notifyIcon1.Visible = false;
                                        j++;
                                    }
                                }

                            }

                        }
                    }

                }

            }
            RefreshList();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           FrmAddFrend ff = new FrmAddFrend(this,this._user  );
            ff.Show();
           
        }
     
       
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

      

        private void RefreshList()
        {

            int mn = 0;
            BLL.userInfo bllUserInfo = new BLL.userInfo();
            List<Model.userInfo> muer = bllUserInfo.GetModelList("");
            foreach (Model.userInfo m in muer)
            {
                if (m.userState != 2&&m.userState!=3)
                {
                    mn++;
                }

            }
            if (mn != loginno)
            {
                loginno = mn;
                this.panel1.Controls.Clear();
                getFriendList();

            }
        }

        private void 发送即时消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCFriendInfo ucf = (UCFriendInfo)currentRight;
            for (int i = 0; i < tbFriendTalkInfo.Count; i++)
            {
                if (tbFriendTalkInfo[i].FriendId == ucf.FriendInfo.userID)
                {
                    if (tbFriendTalkInfo[i].IsOpenTalkForm)
                    {
                        return;
                    }
                    else
                    {
                        tbFriendTalkInfo[i].IsOpenTalkForm = true;
                        break;
                    }
                }
            }


            FrmTalk frm = new FrmTalk(tbFriendTalkInfo, this, this._user, ucf.FriendInfo, ucf.NickName);
            frm.Show();
        }

        private void 修改备注ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UCFriendInfo ucf = (UCFriendInfo)currentRight;
            FrmEditFriendName fefm = new FrmEditFriendName(ucf.NickName,ucf.FID,this ,this._user.userID ,ucf.FriendInfo.userID   );
            fefm.Show();

        }

        private void 删除好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCFriendInfo ucf = (UCFriendInfo)currentRight;
            BLL.friendInfo bllfriend = new BLL.friendInfo();
        
            int mf= ucf.FID;
            bllfriend.Delete(mf);
            this.panel1.Controls.Clear();
            getFriendList();

        }

        private void 屏蔽消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuFriend_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.contextMenuStrip1.Show(Control.MousePosition);
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL.userInfo bllUser = new BLL.userInfo();
            Model.userInfo mu = new Model.userInfo();
            mu.userID = this._user.userID;
            mu.userState = 1;
            mu.userBirthDay = this._user.userBirthDay;
            mu.userDescription = this._user.userDescription;
            mu.userHeadImage = this._user.userHeadImage;
            mu.userName = this._user.userName;
            mu.userPWD = this._user.userPWD;
            mu.userSex = this._user.userSex;
            mu.userShuoshuo = this._user.userShuoshuo;
            this.pictureBox22.Image=this.imageList2.Images[0];
            bllUser.Update(mu );
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BLL.userInfo bllUser = new BLL.userInfo();
            Model.userInfo mu = new Model.userInfo();
            mu.userID = this._user.userID;
            mu.userState = 3;
            mu.userBirthDay = this._user.userBirthDay;
            mu.userDescription = this._user.userDescription;
            mu.userHeadImage = this._user.userHeadImage;
            mu.userName = this._user.userName;
            mu.userPWD = this._user.userPWD;
            mu.userSex = this._user.userSex;
            mu.userShuoshuo = this._user.userShuoshuo;
            this.pictureBox22.Image = this.imageList2.Images[2];
            bllUser.Update(mu);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BLL.userInfo bllUser = new BLL.userInfo();
            Model.userInfo mu = new Model.userInfo();
            mu.userID = this._user.userID;
            mu.userState = 5;
            mu.userBirthDay = this._user.userBirthDay;
            mu.userDescription = this._user.userDescription;
            mu.userHeadImage = this._user.userHeadImage;
            mu.userName = this._user.userName;
            mu.userPWD = this._user.userPWD;
            mu.userSex = this._user.userSex;
            mu.userShuoshuo = this._user.userShuoshuo;
            this.pictureBox22.Image = this.imageList2.Images[4];
            bllUser.Update(mu);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BLL.userInfo bllUser = new BLL.userInfo();
            Model.userInfo mu = new Model.userInfo();
            mu.userID = this._user.userID;
            mu.userState = 4;
            mu.userBirthDay = this._user.userBirthDay;
            mu.userDescription = this._user.userDescription;
            mu.userHeadImage = this._user.userHeadImage;
            mu.userName = this._user.userName;
            mu.userPWD = this._user.userPWD;
            mu.userSex = this._user.userSex;
            mu.userShuoshuo = this._user.userShuoshuo;
            this.pictureBox22.Image = this.imageList2.Images[3];
            bllUser.Update(mu);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BLL.userInfo bllUser = new BLL.userInfo();
            Model.userInfo mu = new Model.userInfo();
            mu.userID = this._user.userID;
            mu.userState = 2;
            mu.userBirthDay = this._user.userBirthDay;
            mu.userDescription = this._user.userDescription;
            mu.userHeadImage = this._user.userHeadImage;
            mu.userName = this._user.userName;
            mu.userPWD = this._user.userPWD;
            mu.userSex = this._user.userSex;
            mu.userShuoshuo = this._user.userShuoshuo;
            this.pictureBox22.Image = this.imageList2.Images[1];
            bllUser.Update(mu);
        }
       
        private void timeSystemn_Tick(object sender, EventArgs e)
        {
            BLL.messsageInfo bmess = new BLL.messsageInfo();
            List<Model.messsageInfo> mmess = bmess.GetModelList("receiverID= '" + this._user.userID + "'and messageState=20 ");
            foreach (Model.messsageInfo  m in mmess)
            {
                BLL.messsageInfo BllMsgInfo = new BLL.messsageInfo();
                Model.messsageInfo msg = new Model.messsageInfo();
                msg.messageContent = m.messageContent;
                msg.senderID = m.senderID;
                msg.receiverID = m.receiverID;
                msg.messageState = 21;
                msg.sendTime = m.sendTime;
                msg.messageID = m.messageID;
                BllMsgInfo.Update(msg);
                BLL.userInfo bll2=new BLL.userInfo();
                Model.userInfo mfriend2=bll2.GetModel(m.senderID );
              
                FrmimmediatelyMsg frm = new FrmimmediatelyMsg(tbFriendTalkInfo, this, this._user,mfriend2,mfriend2.userName  );
                frm.Show();
            }
            BLL.friendRequest bl = new BLL.friendRequest();
            List<Model.friendRequest> mfrien = bl.GetModelList("senderID= '" + this._user.userID + "'and Station=2 ");
            foreach (Model.friendRequest m in mfrien)
            {

            
               FrmOkWarn sw =new FrmOkWarn(m,this );
                sw.Show();
                Model.friendRequest mf = new Model.friendRequest();
                mf.ID = m.ID;
                mf.NickName = m.NickName;
                mf.NumOfSameFriend = m.NumOfSameFriend;
                mf.receiveID = m.receiveID;
                mf.senderID = m.senderID;
                mf.ValidationInfo = m.ValidationInfo;
                mf.ValidationTime = m.ValidationTime;
                mf.Station = 5;
                bl.Update(mf);
            }
          
            BLL.friendRequest bll = new BLL.friendRequest();
            List<Model.friendRequest> mfriend = bll.GetModelList("receiveID= '" + this._user.userID + "'and Station=1 ");
            foreach (Model.friendRequest m in mfriend)
            {
               
       
                SystemWarn sw = new SystemWarn(m,this );
                sw.Show();
                Model.friendRequest mf = new Model.friendRequest();
                mf.ID = m.ID;
                mf.NickName = m.NickName;
                mf.NumOfSameFriend = m.NumOfSameFriend;
                mf.receiveID = m.receiveID;
                mf.senderID = m.senderID;
                mf.ValidationInfo = m.ValidationInfo;
                mf.ValidationTime = m.ValidationTime;
                mf.Station = 5;
                bll.Update(mf);
            }
            BLL.groupu bllgroup = new BLL.groupu();
            List<Model.groupu> mgroup = bllgroup.GetModelList("groupuserID="+this._user.userID );
            if (mgroup .Count !=0)
            {
                int receiverID = mgroup[0].groupID;
                List<Model.friendRequest> mfriend2 = bll.GetModelList("receiveID= '" + receiverID + "'and Station=1 ");
                foreach (Model.friendRequest m in mfriend2)
                {

               
                    FrmGroupWarn sw = new FrmGroupWarn(m, this);
                    sw.Show();
                    Model.friendRequest mf = new Model.friendRequest();
                    mf.ID = m.ID;
                 
                    mf.NumOfSameFriend = m.NumOfSameFriend;
                    mf.receiveID = m.receiveID;
                    mf.senderID = m.senderID;
                    mf.ValidationInfo = m.ValidationInfo;
                    mf.ValidationTime = m.ValidationTime;
                    mf.Station = 5;
                    bll.Update(mf);
                }
            }
         
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.groupu bll = new BLL.groupu();
            List<Model.groupu> mgroup = bll.GetModelList("groupuserID =" + this._user.userID);
            if (mgroup.Count() <1 )
          {
              FrmAddGroup frm = new FrmAddGroup(this._user,this  );
              frm.Show();
              
          }
          else
          {
              MessageBox.Show("您已创建了群，不能继续添加！");
          }
        }

        private void btnAddmember_Click(object sender, EventArgs e)
        {

            BLL.groupu bll = new BLL.groupu();
            List<Model.groupu> mgroup = bll.GetModelList("groupuserID =" + this._user.userID);
            if (mgroup.Count() < 1)
            {
                MessageBox.Show("您未创建了群，不能添加群成员！");
            }
            else
            {
                FrmAddGroupMember frm = new FrmAddGroupMember(this._user, this);
                frm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BLL.groupu bll = new BLL.groupu();
            List<Model.groupu> mgroup = bll.GetModelList("groupuserID =" + this._user.userID);
            if (mgroup.Count() < 1)
            {
                MessageBox.Show("您未创建了群，不能删除群成员！");
            }
            else
            {
                FrmDeleteMember frm = new FrmDeleteMember(this._user, this);
                frm.Show();
            }
        }

      

      
    }
}