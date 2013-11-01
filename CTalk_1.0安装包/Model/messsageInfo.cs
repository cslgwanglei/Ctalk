using System;
namespace CSLG.CTalk.Model
{
	/// <summary>
	/// messsageInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class messsageInfo
	{
		public messsageInfo()
		{}
		#region Model
		private int _messageid;
		private int _senderid;
		private int _receiverid;
		private string _messagecontent;
		private DateTime _sendtime;
		private int _messagestate;
		/// <summary>
		/// 
		/// </summary>
		public int messageID
		{
			set{ _messageid=value;}
			get{return _messageid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int senderID
		{
			set{ _senderid=value;}
			get{return _senderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int receiverID
		{
			set{ _receiverid=value;}
			get{return _receiverid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string messageContent
		{
			set{ _messagecontent=value;}
			get{return _messagecontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime sendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int messageState
		{
			set{ _messagestate=value;}
			get{return _messagestate;}
		}
		#endregion Model

	}
}

