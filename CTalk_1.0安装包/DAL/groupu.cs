using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CSLG.CTalk.DAL
{
    /// <summary>
    /// 数据访问类:groupu
    /// </summary>
    public partial class groupu
    {
        public groupu()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from groupu");
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
        public int Add(CSLG.CTalk.Model.groupu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into groupu(");
            strSql.Append("groupID,groupuserID,groupfriendID,groupName,groupImage,groupAnnouncement)");
            strSql.Append(" values (");
            strSql.Append("@groupID,@groupuserID,@groupfriendID,@groupName,@groupImage,@groupAnnouncement)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@groupID", SqlDbType.Int,4),
					new SqlParameter("@groupuserID", SqlDbType.Int,4),
					new SqlParameter("@groupfriendID", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,50),
					new SqlParameter("@groupImage", SqlDbType.Int,4),
					new SqlParameter("@groupAnnouncement", SqlDbType.Text)};
            parameters[0].Value = model.groupID;
            parameters[1].Value = model.groupuserID;
            parameters[2].Value = model.groupfriendID;
            parameters[3].Value = model.groupName;
            parameters[4].Value = model.groupImage;
            parameters[5].Value = model.groupAnnouncement;

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
        public bool Update(CSLG.CTalk.Model.groupu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update groupu set ");
            strSql.Append("groupID=@groupID,");
            strSql.Append("groupuserID=@groupuserID,");
            strSql.Append("groupfriendID=@groupfriendID,");
            strSql.Append("groupName=@groupName,");
            strSql.Append("groupImage=@groupImage,");
            strSql.Append("groupAnnouncement=@groupAnnouncement");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@groupID", SqlDbType.Int,4),
					new SqlParameter("@groupuserID", SqlDbType.Int,4),
					new SqlParameter("@groupfriendID", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,50),
					new SqlParameter("@groupImage", SqlDbType.Int,4),
					new SqlParameter("@groupAnnouncement", SqlDbType.Text),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.groupID;
            parameters[1].Value = model.groupuserID;
            parameters[2].Value = model.groupfriendID;
            parameters[3].Value = model.groupName;
            parameters[4].Value = model.groupImage;
            parameters[5].Value = model.groupAnnouncement;
            parameters[6].Value = model.ID;

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
            strSql.Append("delete from groupu ");
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
            strSql.Append("delete from groupu ");
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
        public CSLG.CTalk.Model.groupu GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,groupID,groupuserID,groupfriendID,groupName,groupImage,groupAnnouncement from groupu ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            CSLG.CTalk.Model.groupu model = new CSLG.CTalk.Model.groupu();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["groupID"] != null && ds.Tables[0].Rows[0]["groupID"].ToString() != "")
                {
                    model.groupID = int.Parse(ds.Tables[0].Rows[0]["groupID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["groupuserID"] != null && ds.Tables[0].Rows[0]["groupuserID"].ToString() != "")
                {
                    model.groupuserID = int.Parse(ds.Tables[0].Rows[0]["groupuserID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["groupfriendID"] != null && ds.Tables[0].Rows[0]["groupfriendID"].ToString() != "")
                {
                    model.groupfriendID = int.Parse(ds.Tables[0].Rows[0]["groupfriendID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["groupName"] != null && ds.Tables[0].Rows[0]["groupName"].ToString() != "")
                {
                    model.groupName = ds.Tables[0].Rows[0]["groupName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["groupImage"] != null && ds.Tables[0].Rows[0]["groupImage"].ToString() != "")
                {
                    model.groupImage = int.Parse(ds.Tables[0].Rows[0]["groupImage"].ToString());
                }
                if (ds.Tables[0].Rows[0]["groupAnnouncement"] != null && ds.Tables[0].Rows[0]["groupAnnouncement"].ToString() != "")
                {
                    model.groupAnnouncement = ds.Tables[0].Rows[0]["groupAnnouncement"].ToString();
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
            strSql.Append("select ID,groupID,groupuserID,groupfriendID,groupName,groupImage,groupAnnouncement ");
            strSql.Append(" FROM groupu ");
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
            strSql.Append(" ID,groupID,groupuserID,groupfriendID,groupName,groupImage,groupAnnouncement ");
            strSql.Append(" FROM groupu ");
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
            parameters[0].Value = "groupu";
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

