using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CSLG.CTalk.DAL
{
    /// <summary>
    /// 数据访问类:friendRequest
    /// </summary>
    public partial class friendRequest
    {
        public friendRequest()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from friendRequest");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CSLG.CTalk.Model.friendRequest model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into friendRequest(");
            strSql.Append("senderID,receiveID,ValidationInfo,ValidationTime,NumOfSameFriend,Station,NickName)");
            strSql.Append(" values (");
            strSql.Append("@senderID,@receiveID,@ValidationInfo,@ValidationTime,@NumOfSameFriend,@Station,@NickName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@receiveID", SqlDbType.Int,4),
					new SqlParameter("@ValidationInfo", SqlDbType.NVarChar,50),
					new SqlParameter("@ValidationTime", SqlDbType.DateTime),
					new SqlParameter("@NumOfSameFriend", SqlDbType.Int,4),
					new SqlParameter("@Station", SqlDbType.Int,4),
					new SqlParameter("@NickName", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.senderID;
            parameters[1].Value = model.receiveID;
            parameters[2].Value = model.ValidationInfo;
            parameters[3].Value = model.ValidationTime;
            parameters[4].Value = model.NumOfSameFriend;
            parameters[5].Value = model.Station;
            parameters[6].Value = model.NickName;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(CSLG.CTalk.Model.friendRequest model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update friendRequest set ");
            strSql.Append("senderID=@senderID,");
            strSql.Append("receiveID=@receiveID,");
            strSql.Append("ValidationInfo=@ValidationInfo,");
            strSql.Append("ValidationTime=@ValidationTime,");
            strSql.Append("NumOfSameFriend=@NumOfSameFriend,");
            strSql.Append("Station=@Station,");
            strSql.Append("NickName=@NickName");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@receiveID", SqlDbType.Int,4),
					new SqlParameter("@ValidationInfo", SqlDbType.NVarChar,50),
					new SqlParameter("@ValidationTime", SqlDbType.DateTime),
					new SqlParameter("@NumOfSameFriend", SqlDbType.Int,4),
					new SqlParameter("@Station", SqlDbType.Int,4),
					new SqlParameter("@NickName", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.senderID;
            parameters[1].Value = model.receiveID;
            parameters[2].Value = model.ValidationInfo;
            parameters[3].Value = model.ValidationTime;
            parameters[4].Value = model.NumOfSameFriend;
            parameters[5].Value = model.Station;
            parameters[6].Value = model.NickName;
            parameters[7].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from friendRequest ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from friendRequest ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public CSLG.CTalk.Model.friendRequest GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,senderID,receiveID,ValidationInfo,ValidationTime,NumOfSameFriend,Station,NickName from friendRequest ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            CSLG.CTalk.Model.friendRequest model = new CSLG.CTalk.Model.friendRequest();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["senderID"] != null && ds.Tables[0].Rows[0]["senderID"].ToString() != "")
                {
                    model.senderID = int.Parse(ds.Tables[0].Rows[0]["senderID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["receiveID"] != null && ds.Tables[0].Rows[0]["receiveID"].ToString() != "")
                {
                    model.receiveID = int.Parse(ds.Tables[0].Rows[0]["receiveID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ValidationInfo"] != null && ds.Tables[0].Rows[0]["ValidationInfo"].ToString() != "")
                {
                    model.ValidationInfo = ds.Tables[0].Rows[0]["ValidationInfo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ValidationTime"] != null && ds.Tables[0].Rows[0]["ValidationTime"].ToString() != "")
                {
                    model.ValidationTime = DateTime.Parse(ds.Tables[0].Rows[0]["ValidationTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NumOfSameFriend"] != null && ds.Tables[0].Rows[0]["NumOfSameFriend"].ToString() != "")
                {
                    model.NumOfSameFriend = int.Parse(ds.Tables[0].Rows[0]["NumOfSameFriend"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Station"] != null && ds.Tables[0].Rows[0]["Station"].ToString() != "")
                {
                    model.Station = int.Parse(ds.Tables[0].Rows[0]["Station"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NickName"] != null && ds.Tables[0].Rows[0]["NickName"].ToString() != "")
                {
                    model.NickName = ds.Tables[0].Rows[0]["NickName"].ToString();
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,senderID,receiveID,ValidationInfo,ValidationTime,NumOfSameFriend,Station,NickName ");
            strSql.Append(" FROM friendRequest ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,senderID,receiveID,ValidationInfo,ValidationTime,NumOfSameFriend,Station,NickName ");
            strSql.Append(" FROM friendRequest ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            parameters[0].Value = "friendRequest";
            parameters[1].Value = "ID";
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

