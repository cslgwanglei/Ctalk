using System;
using System.Data;
using System.Collections.Generic;

using CSLG.CTalk.Model;
namespace CSLG.CTalk.BLL
{
    /// <summary>
    /// groupMessage
    /// </summary>
    public partial class groupMessage
    {
        private readonly CSLG.CTalk.DAL.groupMessage dal = new CSLG.CTalk.DAL.groupMessage();
        public groupMessage()
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
        public int Add(CSLG.CTalk.Model.groupMessage model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CSLG.CTalk.Model.groupMessage model)
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
        public CSLG.CTalk.Model.groupMessage GetModel(int ID)
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
        public List<CSLG.CTalk.Model.groupMessage> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<CSLG.CTalk.Model.groupMessage> DataTableToList(DataTable dt)
        {
            List<CSLG.CTalk.Model.groupMessage> modelList = new List<CSLG.CTalk.Model.groupMessage>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                CSLG.CTalk.Model.groupMessage model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new CSLG.CTalk.Model.groupMessage();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["groupID"] != null && dt.Rows[n]["groupID"].ToString() != "")
                    {
                        model.groupID = int.Parse(dt.Rows[n]["groupID"].ToString());
                    }
                    if (dt.Rows[n]["senderID"] != null && dt.Rows[n]["senderID"].ToString() != "")
                    {
                        model.senderID = int.Parse(dt.Rows[n]["senderID"].ToString());
                    }
                    if (dt.Rows[n]["receiverID"] != null && dt.Rows[n]["receiverID"].ToString() != "")
                    {
                        model.receiverID = int.Parse(dt.Rows[n]["receiverID"].ToString());
                    }
                    if (dt.Rows[n]["messageContent"] != null && dt.Rows[n]["messageContent"].ToString() != "")
                    {
                        model.messageContent = dt.Rows[n]["messageContent"].ToString();
                    }
                    if (dt.Rows[n]["sendTime"] != null && dt.Rows[n]["sendTime"].ToString() != "")
                    {
                        model.sendTime = DateTime.Parse(dt.Rows[n]["sendTime"].ToString());
                    }
                    if (dt.Rows[n]["messageState"] != null && dt.Rows[n]["messageState"].ToString() != "")
                    {
                        model.messageState = int.Parse(dt.Rows[n]["messageState"].ToString());
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

