using System;
namespace CSLG.CTalk.Model
{

    /// <summary>
    /// userInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class userInfo
    {
        public userInfo()
        { }
        #region Model
        private int _userid;
        private string _userpwd;
        private string _username;
        private string _usershuoshuo;
        private int _userstate;
        private string _userheadimage;
        private string _usersex;
        private DateTime _userbirthday;
        private string _userdescription;
        /// <summary>
        /// 
        /// </summary>
        public int userID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userPWD
        {
            set { _userpwd = value; }
            get { return _userpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userShuoshuo
        {
            set { _usershuoshuo = value; }
            get { return _usershuoshuo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int userState
        {
            set { _userstate = value; }
            get { return _userstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userHeadImage
        {
            set { _userheadimage = value; }
            get { return _userheadimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userSex
        {
            set { _usersex = value; }
            get { return _usersex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime userBirthDay
        {
            set { _userbirthday = value; }
            get { return _userbirthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userDescription
        {
            set { _userdescription = value; }
            get { return _userdescription; }
        }
        #endregion Model

    }
}

