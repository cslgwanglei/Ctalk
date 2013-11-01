using System;
using System.Data;
using System.Collections.Generic;
using CSLG.CTalk.Model;
namespace CSLG.CTalk.BLL
{/// <summary>
    /// userInfo
    /// </summary>
    public partial class userInfo
    {
        private readonly CSLG.CTalk.DAL.userInfo dal = new CSLG.CTalk.DAL.userInfo();
        public userInfo()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int userID)
        {
            return dal.Exists(userID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CSLG.CTalk.Model.userInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CSLG.CTalk.Model.userInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int userID)
        {

            return dal.Delete(userID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string userIDlist)
        {
            return dal.DeleteList(userIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CSLG.CTalk.Model.userInfo GetModel(int userID)
        {

            return dal.GetModel(userID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
       
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<CSLG.CTalk.Model.userInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<CSLG.CTalk.Model.userInfo> DataTableToList(DataTable dt)
        {
            List<CSLG.CTalk.Model.userInfo> modelList = new List<CSLG.CTalk.Model.userInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                CSLG.CTalk.Model.userInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new CSLG.CTalk.Model.userInfo();
                    if (dt.Rows[n]["userID"] != null && dt.Rows[n]["userID"].ToString() != "")
                    {
                        model.userID = int.Parse(dt.Rows[n]["userID"].ToString());
                    }
                    if (dt.Rows[n]["userPWD"] != null && dt.Rows[n]["userPWD"].ToString() != "")
                    {
                        model.userPWD = dt.Rows[n]["userPWD"].ToString();
                    }
                    if (dt.Rows[n]["userName"] != null && dt.Rows[n]["userName"].ToString() != "")
                    {
                        model.userName = dt.Rows[n]["userName"].ToString();
                    }
                    if (dt.Rows[n]["userShuoshuo"] != null && dt.Rows[n]["userShuoshuo"].ToString() != "")
                    {
                        model.userShuoshuo = dt.Rows[n]["userShuoshuo"].ToString();
                    }
                    if (dt.Rows[n]["userState"] != null && dt.Rows[n]["userState"].ToString() != "")
                    {
                        model.userState = int.Parse(dt.Rows[n]["userState"].ToString());
                    }
                    if (dt.Rows[n]["userHeadImage"] != null && dt.Rows[n]["userHeadImage"].ToString() != "")
                    {
                        model.userHeadImage = dt.Rows[n]["userHeadImage"].ToString();
                    }
                    if (dt.Rows[n]["userSex"] != null && dt.Rows[n]["userSex"].ToString() != "")
                    {
                        model.userSex = dt.Rows[n]["userSex"].ToString();
                    }
                    if (dt.Rows[n]["userBirthDay"] != null && dt.Rows[n]["userBirthDay"].ToString() != "")
                    {
                        model.userBirthDay = DateTime.Parse(dt.Rows[n]["userBirthDay"].ToString());
                    }
                    if (dt.Rows[n]["userDescription"] != null && dt.Rows[n]["userDescription"].ToString() != "")
                    {
                        model.userDescription = dt.Rows[n]["userDescription"].ToString();
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  Method
    }
}

