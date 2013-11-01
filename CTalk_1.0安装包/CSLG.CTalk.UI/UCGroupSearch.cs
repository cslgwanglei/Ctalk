using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSLG.CTalk.UI
{
    public partial class UCGroupSearch : UserControl
    {
        public UCGroupSearch()
        {
            InitializeComponent();
        }

        private void UCGroupSearch_Load(object sender, EventArgs e)
        {

        }
        private int _groupID;

        public int GroupID
        {
            get { return _groupID; }
            set { _groupID = value;
            this.label1.Text = GroupID.ToString();
            }
        }
        private int _groupuserID;

        public int GroupuserID
        {
            get { return _groupuserID; }
            set { _groupuserID = value; }
        }
        private string _groupName;

        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value;
            this.label2.Text = _groupName;
            }
        }
        private int _groupImage;
        FrmMain frm = new FrmMain();
        public int GroupImage
        {
            get { return _groupImage; }
            set { _groupImage = value; 
            this.pictureBox1.Image=frm.imageList1.Images [_groupImage ];

            }
        }
        private int _friendID;

        public int FriendID
        {
            get { return _friendID; }
            set { _friendID = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BLL.groupu bll = new BLL.groupu();
           List < Model.groupu> mgroup = bll.GetModelList("groupfriendID='"+this.FriendID+"' and groupID='"+this.GroupID +"'");
           if (mgroup.Count  ==0 )
           {
               FRMGoupCheck frm = new FRMGoupCheck(FriendID,GroupImage ,GroupID ,GroupuserID ,GroupName );
               frm.Show();
           }
        }
    }
}
