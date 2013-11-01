using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSLG.CTalk.Model
{
    public partial class FriendTalkInfo
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
    }
}
