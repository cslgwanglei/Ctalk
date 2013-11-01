using System;
using System.Data;
using System.Collections.Generic;
using CSLG.CTalk.Model;
namespace CSLG.CTalk.BLL
{
	/// <summary>
	/// DICT_messageState
	/// </summary>
	public partial class DICT_messageState
	{
		private readonly CSLG.CTalk.DAL.DICT_messageState dal=new CSLG.CTalk.DAL.DICT_messageState();
		public DICT_messageState()
		{}
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
		public bool Exists(int messageStateID)
		{
			return dal.Exists(messageStateID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CSLG.CTalk.Model.DICT_messageState model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CSLG.CTalk.Model.DICT_messageState model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int messageStateID)
		{
			
			return dal.Delete(messageStateID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string messageStateIDlist )
		{
			return dal.DeleteList(messageStateIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CSLG.CTalk.Model.DICT_messageState GetModel(int messageStateID)
		{
			
			return dal.GetModel(messageStateID);
		}

		

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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CSLG.CTalk.Model.DICT_messageState> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CSLG.CTalk.Model.DICT_messageState> DataTableToList(DataTable dt)
		{
			List<CSLG.CTalk.Model.DICT_messageState> modelList = new List<CSLG.CTalk.Model.DICT_messageState>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CSLG.CTalk.Model.DICT_messageState model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CSLG.CTalk.Model.DICT_messageState();
					if(dt.Rows[n]["messageStateID"]!=null && dt.Rows[n]["messageStateID"].ToString()!="")
					{
						model.messageStateID=int.Parse(dt.Rows[n]["messageStateID"].ToString());
					}
					if(dt.Rows[n]["messageStateName"]!=null && dt.Rows[n]["messageStateName"].ToString()!="")
					{
					model.messageStateName=dt.Rows[n]["messageStateName"].ToString();
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

