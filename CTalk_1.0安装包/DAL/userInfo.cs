using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CSLG.CTalk.DAL
{
    /// <summary>
    /// 数据访问类:userInfo
    /// </summary>
    public partial class userInfo
    {
        public userInfo()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int userID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from userInfo");
            strSql.Append(" where userID=@userID");
            SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4)
};
            parameters[0].Value = userID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CSLG.CTalk.Model.userInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into userInfo(");
            strSql.Append("userPWD,userName,userShuoshuo,userState,userHeadImage,userSex,userBirthDay,userDescription)");
            strSql.Append(" values (");
            strSql.Append("@userPWD,@userName,@userShuoshuo,@userState,@userHeadImage,@userSex,@userBirthDay,@userDescription)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@userPWD", SqlDbType.VarChar,20),
					new SqlParameter("@userName", SqlDbType.NVarChar,10),
					new SqlParameter("@userShuoshuo", SqlDbType.NVarChar,100),
					new SqlParameter("@userState", SqlDbType.TinyInt,1),
					new SqlParameter("@userHeadImage", SqlDbType.VarChar,50),
					new SqlParameter("@userSex", SqlDbType.NVarChar,50),
					new SqlParameter("@userBirthDay", SqlDbType.SmallDateTime),
					new SqlParameter("@userDescription", SqlDbType.NVarChar,250)};
            parameters[0].Value = model.userPWD;
            parameters[1].Value = model.userName;
            parameters[2].Value = model.userShuoshuo;
            parameters[3].Value = model.userState;
            parameters[4].Value = model.userHeadImage;
            parameters[5].Value = model.userSex;
            parameters[6].Value = model.userBirthDay;
            parameters[7].Value = model.userDescription;

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
        public bool Update(CSLG.CTalk.Model.userInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update userInfo set ");
            strSql.Append("userPWD=@userPWD,");
            strSql.Append("userName=@userName,");
            strSql.Append("userShuoshuo=@userShuoshuo,");
            strSql.Append("userState=@userState,");
            strSql.Append("userHeadImage=@userHeadImage,");
            strSql.Append("userSex=@userSex,");
            strSql.Append("userBirthDay=@userBirthDay,");
            strSql.Append("userDescription=@userDescription");
            strSql.Append(" where userID=@userID");
            SqlParameter[] parameters = {
					new SqlParameter("@userPWD", SqlDbType.VarChar,20),
					new SqlParameter("@userName", SqlDbType.NVarChar,10),
					new SqlParameter("@userShuoshuo", SqlDbType.NVarChar,100),
					new SqlParameter("@userState", SqlDbType.TinyInt,1),
					new SqlParameter("@userHeadImage", SqlDbType.VarChar,50),
					new SqlParameter("@userSex", SqlDbType.NVarChar,50),
					new SqlParameter("@userBirthDay", SqlDbType.SmallDateTime),
					new SqlParameter("@userDescription", SqlDbType.NVarChar,250),
					new SqlParameter("@userID", SqlDbType.Int,4)};
            parameters[0].Value = model.userPWD;
            parameters[1].Value = model.userName;
            parameters[2].Value = model.userShuoshuo;
            parameters[3].Value = model.userState;
            parameters[4].Value = model.userHeadImage;
            parameters[5].Value = model.userSex;
            parameters[6].Value = model.userBirthDay;
            parameters[7].Value = model.userDescription;
            parameters[8].Value = model.userID;

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
        public bool Delete(int userID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from userInfo ");
            strSql.Append(" where userID=@userID");
            SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4)
};
            parameters[0].Value = userID;

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
        public bool DeleteList(string userIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from userInfo ");
            strSql.Append(" where userID in (" + userIDlist + ")  ");
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
        public CSLG.CTalk.Model.userInfo GetModel(int userID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 userID,userPWD,userName,userShuoshuo,userState,userHeadImage,userSex,userBirthDay,userDescription from userInfo ");
            strSql.Append(" where userID=@userID");
            SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4)
};
            parameters[0].Value = userID;

            CSLG.CTalk.Model.userInfo model = new CSLG.CTalk.Model.userInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["userID"] != null && ds.Tables[0].Rows[0]["userID"].ToString() != "")
                {
                    model.userID = int.Parse(ds.Tables[0].Rows[0]["userID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["userPWD"] != null && ds.Tables[0].Rows[0]["userPWD"].ToString() != "")
                {
                    model.userPWD = ds.Tables[0].Rows[0]["userPWD"].ToString();
                }
                if (ds.Tables[0].Rows[0]["userName"] != null && ds.Tables[0].Rows[0]["userName"].ToString() != "")
                {
                    model.userName = ds.Tables[0].Rows[0]["userName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["userShuoshuo"] != null && ds.Tables[0].Rows[0]["userShuoshuo"].ToString() != "")
                {
                    model.userShuoshuo = ds.Tables[0].Rows[0]["userShuoshuo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["userState"] != null && ds.Tables[0].Rows[0]["userState"].ToString() != "")
                {
                    model.userState = int.Parse(ds.Tables[0].Rows[0]["userState"].ToString());
                }
                if (ds.Tables[0].Rows[0]["userHeadImage"] != null && ds.Tables[0].Rows[0]["userHeadImage"].ToString() != "")
                {
                    model.userHeadImage = ds.Tables[0].Rows[0]["userHeadImage"].ToString();
                }
                if (ds.Tables[0].Rows[0]["userSex"] != null && ds.Tables[0].Rows[0]["userSex"].ToString() != "")
                {
                    model.userSex = ds.Tables[0].Rows[0]["userSex"].ToString();
                }
                if (ds.Tables[0].Rows[0]["userBirthDay"] != null && ds.Tables[0].Rows[0]["userBirthDay"].ToString() != "")
                {
                    model.userBirthDay = DateTime.Parse(ds.Tables[0].Rows[0]["userBirthDay"].ToString());
                }
                if (ds.Tables[0].Rows[0]["userDescription"] != null && ds.Tables[0].Rows[0]["userDescription"].ToString() != "")
                {
                    model.userDescription = ds.Tables[0].Rows[0]["userDescription"].ToString();
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
            strSql.Append("select userID,userPWD,userName,userShuoshuo,userState,userHeadImage,userSex,userBirthDay,userDescription ");
            strSql.Append(" FROM userInfo ");
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
            strSql.Append(" userID,userPWD,userName,userShuoshuo,userState,userHeadImage,userSex,userBirthDay,userDescription ");
            strSql.Append(" FROM userInfo ");
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
            parameters[0].Value = "userInfo";
            parameters[1].Value = "userID";
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

