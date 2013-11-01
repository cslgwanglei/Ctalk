using System;
using System.Data;
using System.Collections.Generic;

using CSLG.CTalk.Model;
namespace CSLG.CTalk.BLL
{
    /// <summary>
    /// DICT_friendRequeest
    /// </summary>
    public partial class DICT_friendRequeest
    {
        private readonly CSLG.CTalk.DAL.DICT_friendRequeest dal = new CSLG.CTalk.DAL.DICT_friendRequeest();
        public DICT_friendRequeest()
        { }
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

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
        public bool Add(CSLG.CTalk.Model.DICT_friendRequeest model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CSLG.CTalk.Model.DICT_friendRequeest model)
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
        public CSLG.CTalk.Model.DICT_friendRequeest GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
   
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
        public List<CSLG.CTalk.Model.DICT_friendRequeest> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<CSLG.CTalk.Model.DICT_friendRequeest> DataTableToList(DataTable dt)
        {
            List<CSLG.CTalk.Model.DICT_friendRequeest> modelList = new List<CSLG.CTalk.Model.DICT_friendRequeest>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                CSLG.CTalk.Model.DICT_friendRequeest model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new CSLG.CTalk.Model.DICT_friendRequeest();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["StateName"] != null && dt.Rows[n]["StateName"].ToString() != "")
                    {
                        model.StateName = dt.Rows[n]["StateName"].ToString();
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

