using System;
using System.Data;
using System.Collections.Generic;

using CSLG.CTalk.Model;
namespace CSLG.CTalk.BLL
{
    /// <summary>
    /// friendRequest
    /// </summary>
    public partial class friendRequest
    {
        private readonly CSLG.CTalk.DAL.friendRequest dal = new CSLG.CTalk.DAL.friendRequest();
        public friendRequest()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CSLG.CTalk.Model.friendRequest model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CSLG.CTalk.Model.friendRequest model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            return dal.Delete(ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CSLG.CTalk.Model.friendRequest GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
 
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
        public List<CSLG.CTalk.Model.friendRequest> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<CSLG.CTalk.Model.friendRequest> DataTableToList(DataTable dt)
        {
            List<CSLG.CTalk.Model.friendRequest> modelList = new List<CSLG.CTalk.Model.friendRequest>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                CSLG.CTalk.Model.friendRequest model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new CSLG.CTalk.Model.friendRequest();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["senderID"] != null && dt.Rows[n]["senderID"].ToString() != "")
                    {
                        model.senderID = int.Parse(dt.Rows[n]["senderID"].ToString());
                    }
                    if (dt.Rows[n]["receiveID"] != null && dt.Rows[n]["receiveID"].ToString() != "")
                    {
                        model.receiveID = int.Parse(dt.Rows[n]["receiveID"].ToString());
                    }
                    if (dt.Rows[n]["ValidationInfo"] != null && dt.Rows[n]["ValidationInfo"].ToString() != "")
                    {
                        model.ValidationInfo = dt.Rows[n]["ValidationInfo"].ToString();
                    }
                    if (dt.Rows[n]["ValidationTime"] != null && dt.Rows[n]["ValidationTime"].ToString() != "")
                    {
                        model.ValidationTime = DateTime.Parse(dt.Rows[n]["ValidationTime"].ToString());
                    }
                    if (dt.Rows[n]["NumOfSameFriend"] != null && dt.Rows[n]["NumOfSameFriend"].ToString() != "")
                    {
                        model.NumOfSameFriend = int.Parse(dt.Rows[n]["NumOfSameFriend"].ToString());
                    }
                    if (dt.Rows[n]["Station"] != null && dt.Rows[n]["Station"].ToString() != "")
                    {
                        model.Station = int.Parse(dt.Rows[n]["Station"].ToString());
                    }
                    if (dt.Rows[n]["NickName"] != null && dt.Rows[n]["NickName"].ToString() != "")
                    {
                        model.NickName = dt.Rows[n]["NickName"].ToString();
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

