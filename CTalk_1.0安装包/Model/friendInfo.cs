using System;
namespace CSLG.CTalk.Model
{
	/// <summary>
	/// friendInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class friendInfo
	{
		public friendInfo()
		{}
		#region Model
		private int _id;
		private int _userid;
		private int _friendid;
		private string _friendname;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int userID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int friendID
		{
			set{ _friendid=value;}
			get{return _friendid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string friendName
		{
			set{ _friendname=value;}
			get{return _friendname;}
		}
		#endregion Model

	}
}

