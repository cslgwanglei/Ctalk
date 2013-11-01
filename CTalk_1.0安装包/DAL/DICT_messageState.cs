using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CSLG.CTalk.DAL
{
	/// <summary>
	/// 数据访问类:DICT_messageState
	/// </summary>
	public partial class DICT_messageState
	{
		public DICT_messageState()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("messageStateID", "DICT_messageState"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int messageStateID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DICT_messageState");
			strSql.Append(" where messageStateID=@messageStateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@messageStateID", SqlDbType.TinyInt,1)};
			parameters[0].Value = messageStateID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CSLG.CTalk.Model.DICT_messageState model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DICT_messageState(");
			strSql.Append("messageStateID,messageStateName)");
			strSql.Append(" values (");
			strSql.Append("@messageStateID,@messageStateName)");
			SqlParameter[] parameters = {
					new SqlParameter("@messageStateID", SqlDbType.TinyInt,1),
					new SqlParameter("@messageStateName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.messageStateID;
			parameters[1].Value = model.messageStateName;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(CSLG.CTalk.Model.DICT_messageState model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DICT_messageState set ");
			strSql.Append("messageStateName=@messageStateName");
			strSql.Append(" where messageStateID=@messageStateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@messageStateName", SqlDbType.NVarChar,50),
					new SqlParameter("@messageStateID", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.messageStateName;
			parameters[1].Value = model.messageStateID;

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
		public bool Delete(int messageStateID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DICT_messageState ");
			strSql.Append(" where messageStateID=@messageStateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@messageStateID", SqlDbType.TinyInt,1)};
			parameters[0].Value = messageStateID;

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
		public bool DeleteList(string messageStateIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DICT_messageState ");
			strSql.Append(" where messageStateID in ("+messageStateIDlist + ")  ");
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
		public CSLG.CTalk.Model.DICT_messageState GetModel(int messageStateID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 messageStateID,messageStateName from DICT_messageState ");
			strSql.Append(" where messageStateID=@messageStateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@messageStateID", SqlDbType.TinyInt,1)};
			parameters[0].Value = messageStateID;

			CSLG.CTalk.Model.DICT_messageState model=new CSLG.CTalk.Model.DICT_messageState();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["messageStateID"]!=null && ds.Tables[0].Rows[0]["messageStateID"].ToString()!="")
				{
					model.messageStateID=int.Parse(ds.Tables[0].Rows[0]["messageStateID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["messageStateName"]!=null && ds.Tables[0].Rows[0]["messageStateName"].ToString()!="")
				{
					model.messageStateName=ds.Tables[0].Rows[0]["messageStateName"].ToString();
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
			strSql.Append("select messageStateID,messageStateName ");
			strSql.Append(" FROM DICT_messageState ");
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
			strSql.Append(" messageStateID,messageStateName ");
			strSql.Append(" FROM DICT_messageState ");
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
			parameters[0].Value = "DICT_messageState";
			parameters[1].Value = "messageStateID";
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

