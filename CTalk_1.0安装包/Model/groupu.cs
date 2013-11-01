using System;
namespace CSLG.CTalk.Model
{
    /// <summary>
    /// groupu:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class groupu
    {
        public groupu()
        { }
        #region Model
        private int _id;
        private int _groupid;
        private int _groupuserid;
        private int _groupfriendid;
        private string _groupname;
        private int _groupimage;
        private string _groupannouncement;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int groupID
        {
            set { _groupid = value; }
            get { return _groupid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int groupuserID
        {
            set { _groupuserid = value; }
            get { return _groupuserid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int groupfriendID
        {
            set { _groupfriendid = value; }
            get { return _groupfriendid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string groupName
        {
            set { _groupname = value; }
            get { return _groupname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int groupImage
        {
            set { _groupimage = value; }
            get { return _groupimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string groupAnnouncement
        {
            set { _groupannouncement = value; }
            get { return _groupannouncement; }
        }
        #endregion Model

    }
}

