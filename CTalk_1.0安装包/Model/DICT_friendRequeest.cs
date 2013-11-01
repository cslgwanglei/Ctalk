using System;
namespace CSLG.CTalk.Model
{
    /// <summary>
    /// DICT_friendRequeest:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class DICT_friendRequeest
    {
        public DICT_friendRequeest()
        { }
        #region Model
        private int _id;
        private string _statename;
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
        public string StateName
        {
            set { _statename = value; }
            get { return _statename; }
        }
        #endregion Model

    }
}

