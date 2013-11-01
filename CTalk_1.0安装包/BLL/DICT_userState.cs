using System;
using System.Data;
using System.Collections.Generic;
using CSLG.CTalk.Model;
namespace CSLG.CTalk.BLL
{
	/// <summary>
	/// DICT_userState
	/// </summary>
	public partial class DICT_userState
	{
		private readonly CSLG.CTalk.DAL.DICT_userState dal=new CSLG.CTalk.DAL.DICT_userState();
		public DICT_userState()
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
		public bool Exists(int userStateID)
		{
			return dal.Exists(userStateID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CSLG.CTalk.Model.DICT_userState model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CSLG.CTalk.Model.DICT_userState model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int userStateID)
		{
			
			return dal.Delete(userStateID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string userStateIDlist )
		{
			return dal.DeleteList(userStateIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CSLG.CTalk.Model.DICT_userState GetModel(int userStateID)
		{
			
			return dal.GetModel(userStateID);
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
		public List<CSLG.CTalk.Model.DICT_userState> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CSLG.CTalk.Model.DICT_userState> DataTableToList(DataTable dt)
		{
			List<CSLG.CTalk.Model.DICT_userState> modelList = new List<CSLG.CTalk.Model.DICT_userState>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CSLG.CTalk.Model.DICT_userState model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CSLG.CTalk.Model.DICT_userState();
					if(dt.Rows[n]["userStateID"]!=null && dt.Rows[n]["userStateID"].ToString()!="")
					{
						model.userStateID=int.Parse(dt.Rows[n]["userStateID"].ToString());
					}
					if(dt.Rows[n]["userStateName"]!=null && dt.Rows[n]["userStateName"].ToString()!="")
					{
					model.userStateName=dt.Rows[n]["userStateName"].ToString();
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

