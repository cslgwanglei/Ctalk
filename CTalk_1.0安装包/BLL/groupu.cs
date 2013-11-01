using System;
using System.Data;
using System.Collections.Generic;

using CSLG.CTalk.Model;
namespace CSLG.CTalk.BLL
{
    /// <summary>
    /// groupu
    /// </summary>
    public partial class groupu
    {
        private readonly CSLG.CTalk.DAL.groupu dal = new CSLG.CTalk.DAL.groupu();
        public groupu()
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
        public int Add(CSLG.CTalk.Model.groupu model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CSLG.CTalk.Model.groupu model)
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
        public CSLG.CTalk.Model.groupu GetModel(int ID)
        {

            return dal.GetModel(ID);
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
        public List<CSLG.CTalk.Model.groupu> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<CSLG.CTalk.Model.groupu> DataTableToList(DataTable dt)
        {
            List<CSLG.CTalk.Model.groupu> modelList = new List<CSLG.CTalk.Model.groupu>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                CSLG.CTalk.Model.groupu model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new CSLG.CTalk.Model.groupu();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["groupID"] != null && dt.Rows[n]["groupID"].ToString() != "")
                    {
                        model.groupID = int.Parse(dt.Rows[n]["groupID"].ToString());
                    }
                    if (dt.Rows[n]["groupuserID"] != null && dt.Rows[n]["groupuserID"].ToString() != "")
                    {
                        model.groupuserID = int.Parse(dt.Rows[n]["groupuserID"].ToString());
                    }
                    if (dt.Rows[n]["groupfriendID"] != null && dt.Rows[n]["groupfriendID"].ToString() != "")
                    {
                        model.groupfriendID = int.Parse(dt.Rows[n]["groupfriendID"].ToString());
                    }
                    if (dt.Rows[n]["groupName"] != null && dt.Rows[n]["groupName"].ToString() != "")
                    {
                        model.groupName = dt.Rows[n]["groupName"].ToString();
                    }
                    if (dt.Rows[n]["groupImage"] != null && dt.Rows[n]["groupImage"].ToString() != "")
                    {
                        model.groupImage = int.Parse(dt.Rows[n]["groupImage"].ToString());
                    }
                    if (dt.Rows[n]["groupAnnouncement"] != null && dt.Rows[n]["groupAnnouncement"].ToString() != "")
                    {
                        model.groupAnnouncement = dt.Rows[n]["groupAnnouncement"].ToString();
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

