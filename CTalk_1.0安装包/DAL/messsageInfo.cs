using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CSLG.CTalk.DAL
{
	/// <summary>
	/// 数据访问类:messsageInfo
	/// </summary>
	public partial class messsageInfo
	{
		public messsageInfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("messageID", "messsageInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int messageID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from messsageInfo");
			strSql.Append(" where messageID=@messageID");
			SqlParameter[] parameters = {
					new SqlParameter("@messageID", SqlDbType.Int,4)
};
			parameters[0].Value = messageID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(CSLG.CTalk.Model.messsageInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into messsageInfo(");
			strSql.Append("senderID,receiverID,messageContent,sendTime,messageState)");
			strSql.Append(" values (");
			strSql.Append("@senderID,@receiverID,@messageContent,@sendTime,@messageState)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@receiverID", SqlDbType.Int,4),
					new SqlParameter("@messageContent", SqlDbType.NVarChar,500),
					new SqlParameter("@sendTime", SqlDbType.SmallDateTime),
					new SqlParameter("@messageState", SqlDbType.Int,8)};
			parameters[0].Value = model.senderID;
			parameters[1].Value = model.receiverID;
			parameters[2].Value = model.messageContent;
			parameters[3].Value = model.sendTime;
			parameters[4].Value = model.messageState;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CSLG.CTalk.Model.messsageInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update messsageInfo set ");
			strSql.Append("senderID=@senderID,");
			strSql.Append("receiverID=@receiverID,");
			strSql.Append("messageContent=@messageContent,");
			strSql.Append("sendTime=@sendTime,");
			strSql.Append("messageState=@messageState");
			strSql.Append(" where messageID=@messageID");
			SqlParameter[] parameters = {
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@receiverID", SqlDbType.Int,4),
					new SqlParameter("@messageContent", SqlDbType.NVarChar,500),
					new SqlParameter("@sendTime", SqlDbType.SmallDateTime),
					new SqlParameter("@messageState", SqlDbType.Int,8),
					new SqlParameter("@messageID", SqlDbType.Int,4)};
			parameters[0].Value = model.senderID;
			parameters[1].Value = model.receiverID;
			parameters[2].Value = model.messageContent;
			parameters[3].Value = model.sendTime;
			parameters[4].Value = model.messageState;
			parameters[5].Value = model.messageID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int messageID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from messsageInfo ");
			strSql.Append(" where messageID=@messageID");
			SqlParameter[] parameters = {
					new SqlParameter("@messageID", SqlDbType.Int,4)
};
			parameters[0].Value = messageID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string messageIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from messsageInfo ");
			strSql.Append(" where messageID in ("+messageIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CSLG.CTalk.Model.messsageInfo GetModel(int messageID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 messageID,senderID,receiverID,messageContent,sendTime,messageState from messsageInfo ");
			strSql.Append(" where messageID=@messageID");
			SqlParameter[] parameters = {
					new SqlParameter("@messageID", SqlDbType.Int,4)
};
			parameters[0].Value = messageID;

			CSLG.CTalk.Model.messsageInfo model=new CSLG.CTalk.Model.messsageInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["messageID"]!=null && ds.Tables[0].Rows[0]["messageID"].ToString()!="")
				{
					model.messageID=int.Parse(ds.Tables[0].Rows[0]["messageID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["senderID"]!=null && ds.Tables[0].Rows[0]["senderID"].ToString()!="")
				{
					model.senderID=int.Parse(ds.Tables[0].Rows[0]["senderID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["receiverID"]!=null && ds.Tables[0].Rows[0]["receiverID"].ToString()!="")
				{
					model.receiverID=int.Parse(ds.Tables[0].Rows[0]["receiverID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["messageContent"]!=null && ds.Tables[0].Rows[0]["messageContent"].ToString()!="")
				{
					model.messageContent=ds.Tables[0].Rows[0]["messageContent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sendTime"]!=null && ds.Tables[0].Rows[0]["sendTime"].ToString()!="")
				{
					model.sendTime=DateTime.Parse(ds.Tables[0].Rows[0]["sendTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["messageState"]!=null && ds.Tables[0].Rows[0]["messageState"].ToString()!="")
				{
					model.messageState=int.Parse(ds.Tables[0].Rows[0]["messageState"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select messageID,senderID,receiverID,messageContent,sendTime,messageState ");
			strSql.Append(" FROM messsageInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" messageID,senderID,receiverID,messageContent,sendTime,messageState ");
			strSql.Append(" FROM messsageInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "messsageInfo";
			parameters[1].Value = "messageID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

