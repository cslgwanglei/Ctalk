using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CSLG.CTalk.DAL
{
	/// <summary>
	/// 数据访问类:DICT_userState
	/// </summary>
	public partial class DICT_userState
	{
		public DICT_userState()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("userStateID", "DICT_userState"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userStateID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DICT_userState");
			strSql.Append(" where userStateID=@userStateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@userStateID", SqlDbType.TinyInt,1)};
			parameters[0].Value = userStateID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CSLG.CTalk.Model.DICT_userState model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DICT_userState(");
			strSql.Append("userStateID,userStateName)");
			strSql.Append(" values (");
			strSql.Append("@userStateID,@userStateName)");
			SqlParameter[] parameters = {
					new SqlParameter("@userStateID", SqlDbType.TinyInt,1),
					new SqlParameter("@userStateName", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.userStateID;
			parameters[1].Value = model.userStateName;

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
		public bool Update(CSLG.CTalk.Model.DICT_userState model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DICT_userState set ");
			strSql.Append("userStateName=@userStateName");
			strSql.Append(" where userStateID=@userStateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@userStateName", SqlDbType.NVarChar,20),
					new SqlParameter("@userStateID", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.userStateName;
			parameters[1].Value = model.userStateID;

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
		public bool Delete(int userStateID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DICT_userState ");
			strSql.Append(" where userStateID=@userStateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@userStateID", SqlDbType.TinyInt,1)};
			parameters[0].Value = userStateID;

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
		public bool DeleteList(string userStateIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DICT_userState ");
			strSql.Append(" where userStateID in ("+userStateIDlist + ")  ");
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
		public CSLG.CTalk.Model.DICT_userState GetModel(int userStateID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 userStateID,userStateName from DICT_userState ");
			strSql.Append(" where userStateID=@userStateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@userStateID", SqlDbType.TinyInt,1)};
			parameters[0].Value = userStateID;

			CSLG.CTalk.Model.DICT_userState model=new CSLG.CTalk.Model.DICT_userState();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["userStateID"]!=null && ds.Tables[0].Rows[0]["userStateID"].ToString()!="")
				{
					model.userStateID=int.Parse(ds.Tables[0].Rows[0]["userStateID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userStateName"]!=null && ds.Tables[0].Rows[0]["userStateName"].ToString()!="")
				{
					model.userStateName=ds.Tables[0].Rows[0]["userStateName"].ToString();
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
			strSql.Append("select userStateID,userStateName ");
			strSql.Append(" FROM DICT_userState ");
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
			strSql.Append(" userStateID,userStateName ");
			strSql.Append(" FROM DICT_userState ");
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
			parameters[0].Value = "DICT_userState";
			parameters[1].Value = "userStateID";
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

