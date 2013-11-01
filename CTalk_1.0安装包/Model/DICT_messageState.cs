using System;
namespace CSLG.CTalk.Model
{
	/// <summary>
	/// DICT_messageState:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DICT_messageState
	{
		public DICT_messageState()
		{}
		#region Model
		private int _messagestateid;
		private string _messagestatename;
		/// <summary>
		/// 
		/// </summary>
		public int messageStateID
		{
			set{ _messagestateid=value;}
			get{return _messagestateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string messageStateName
		{
			set{ _messagestatename=value;}
			get{return _messagestatename;}
		}
		#endregion Model

	}
}

