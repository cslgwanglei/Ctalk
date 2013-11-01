using System;
namespace CSLG.CTalk.Model
{
    /// <summary>
    /// friendRequest:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class friendRequest
    {
        public friendRequest()
        { }
        #region Model
        private int _id;
        private int _senderid;
        private int _receiveid;
        private string _validationinfo;
        private DateTime _validationtime;
        private int _numofsamefriend;
        private int _station;
        private string _nickname;
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
        public int senderID
        {
            set { _senderid = value; }
            get { return _senderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int receiveID
        {
            set { _receiveid = value; }
            get { return _receiveid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ValidationInfo
        {
            set { _validationinfo = value; }
            get { return _validationinfo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ValidationTime
        {
            set { _validationtime = value; }
            get { return _validationtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int NumOfSameFriend
        {
            set { _numofsamefriend = value; }
            get { return _numofsamefriend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Station
        {
            set { _station = value; }
            get { return _station; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NickName
        {
            set { _nickname = value; }
            get { return _nickname; }
        }
        #endregion Model

    }
}

