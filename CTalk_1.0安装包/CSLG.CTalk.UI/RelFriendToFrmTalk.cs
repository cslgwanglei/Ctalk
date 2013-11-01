using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSLG.CTalk.UI
{
   public  class RelFriendToFrmTalk
    {
        private int friendId;

        public int FriendId
        {
            get { return friendId; }
            set { friendId = value; }
        }
        private bool isOpenTalkForm;

        public bool IsOpenTalkForm
        {
            get { return isOpenTalkForm; }
            set { isOpenTalkForm = value; }
        }
        private FrmTalk frm;

        public FrmTalk Frm
        {
            get { return frm; }
            set { frm = value; }
        }
    }
}
