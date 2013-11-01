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
    public partial class FrmGroupTalk : Form
    {
        public FrmGroupTalk()
        {
            InitializeComponent();
        }
        private Model.userInfo _me;
        private List<RelFriendToFrmTalk> _ft;
        private UCGroupList _uc;
        List<UCGroup> luc = new List<UCGroup>();
        public FrmGroupTalk(List<RelFriendToFrmTalk> ft, Model.userInfo me, UCGroupList uc)
        {
            InitializeComponent();
            this._ft=ft;
            this._me = me;
            this._uc = uc;
        }

        private void FrmGroupTalk_Load(object sender, EventArgs e)
        {
            this.textBox2.Text = this._uc.Groupannouncement;
            FrmMain frm = new FrmMain();
            BLL.groupu bll = new BLL.groupu();
            List<Model.groupu> mylist = bll.GetModelList("groupID="+this._uc.GroupID );
            int index = 0;
           
            foreach (Model.groupu  mg in mylist)
            {
                BLL.userInfo bu = new BLL.userInfo();
                Model.userInfo mu = bu.GetModel(mg.groupfriendID );
                UCGroup ucg1 = new UCGroup();
                ucg1.Top = ucg1.Height * index;
                ucg1.Id1 = mg.groupfriendID;
                ucg1.HeadImage=frm.imageList1.Images[Convert.ToInt32(mu.userHeadImage  )];
                ucg1.Username = mu.userName;
                luc.Add(ucg1);
                this.panel1.Controls.Add(ucg1 );
                index++;
            }
           
        }

        private void SendMsg()
        {
            string comment = this.txtmessge.Text;
            if (comment == "")
            {
                return;

            }
            BLL.groupu bllgroup = new BLL.groupu();
            List<Model.groupu> mgroup = bllgroup.GetModelList("groupID="+this._uc.GroupID );
            BLL.groupMessage BllMsgInfo = new BLL.groupMessage();
            Model.groupMessage msg = new Model.groupMessage();
            foreach (Model.groupu  mgo in mgroup)
            {
                if (mgo.groupfriendID!=this._me.userID )
                {
                 
                  
                    msg.messageContent = comment;
                    msg.senderID = this._me.userID ;
                    msg.receiverID = mgo.groupfriendID;
                    msg.messageState = 31;
                    msg.sendTime = BLL.NormalOperation.getServerTime();
                    msg.groupID = mgo.groupID;
                         int  res= BllMsgInfo.Add (msg);
                    if (res<=0)
                    {
                        MessageBox.Show("消息发送失败或检查网络连接！！");
                    }
            
                }
               
              
            }
            ShowMsg(msg, false);
         this.txtmessge.Text="";
        }

        public void ShowMsg(Model.groupMessage msg, bool isSendFromME)
        {
            BLL.userInfo bll = new BLL.userInfo();
            Model.userInfo mu = bll.GetModel(msg.senderID);
           
            int startPos = this.txtinfo.Text.Length;
            string title = "";
            Color fColor = Color.Black;
            if (isSendFromME)
            {
                title = mu.userName  + msg.sendTime.ToLongTimeString() + "\r\n\t";
                fColor = Color.Red;
            }
            else
            {
                title = this._me.userName+ msg.sendTime.ToLongTimeString() + "\r\n\t";
                fColor = Color.Blue; ;
            }

            int titlelen = title.Length;
            this.txtinfo.AppendText(title);
            this.txtinfo.SelectionStart = startPos;
            this.txtinfo.SelectionLength = titlelen;
            this.txtinfo.SelectionColor = fColor;
            startPos = this.txtinfo.Text.Length;
            string comment = msg.messageContent + "\r\n";
            int commentlen = comment.Length;
            this.txtinfo.AppendText(comment);
            this.txtinfo.SelectionStart = startPos;
            this.txtinfo.SelectionLength = commentlen;
            this.txtinfo.SelectionColor = Color.Black;
        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            SendMsg();
        }

        private void timergroup_Tick(object sender, EventArgs e)
        {
            BLL.groupMessage bllmsg = new BLL.groupMessage();

            List<Model.groupMessage> msgInfo = bllmsg.GetModelList("receiverID= '" + this._me.userID + "'and messageState=31 and groupID= '"+this._uc.GroupID +"' ");
            foreach (Model.groupMessage m in msgInfo)
            {   
                ShowMsg(m, true);
                BLL.groupMessage BllMsgInfo = new BLL.groupMessage();
                Model.groupMessage msg = new Model.groupMessage();

                msg.messageContent = m.messageContent;
                msg.senderID = m.senderID;
                msg.receiverID = m.receiverID;
                msg.messageState = 32;
                msg.sendTime = m.sendTime;
                msg.ID  = m.ID ;
                msg.groupID = m.groupID;
                BllMsgInfo.Update(msg);
            

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGroupTalk_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < this._ft.Count; i++)
            {
                if (this._ft[i].FriendId == this._uc.GroupID )
                {
                    this._ft[i].IsOpenTalkForm = false;
                    break;
                }
            }
        }
    }
}
