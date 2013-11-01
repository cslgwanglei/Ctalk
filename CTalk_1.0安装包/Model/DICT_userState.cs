using System;
namespace CSLG.CTalk.Model
{
	/// <summary>
	/// DICT_userState:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DICT_userState
	{
		public DICT_userState()
		{}
		#region Model
		private int _userstateid;
		private string _userstatename;
		/// <summary>
		/// 
		/// </summary>
		public int userStateID
		{
			set{ _userstateid=value;}
			get{return _userstateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userStateName
		{
			set{ _userstatename=value;}
			get{return _userstatename;}
		}
		#endregion Model

	}
}

