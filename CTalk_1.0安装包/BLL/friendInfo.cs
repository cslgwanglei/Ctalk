using System;
using System.Data;
using System.Collections.Generic;
using CSLG.CTalk.Model;
namespace CSLG.CTalk.BLL
{
	/// <summary>
	/// friendInfo
	/// </summary>
	public partial class friendInfo
	{
		private readonly CSLG.CTalk.DAL.friendInfo dal=new CSLG.CTalk.DAL.friendInfo();
		public friendInfo()
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
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(CSLG.CTalk.Model.friendInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CSLG.CTalk.Model.friendInfo model)
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
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CSLG.CTalk.Model.friendInfo GetModel(int ID)
		{
			
			return dal.GetModel(ID);
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
		public List<CSLG.CTalk.Model.friendInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CSLG.CTalk.Model.friendInfo> DataTableToList(DataTable dt)
		{
			List<CSLG.CTalk.Model.friendInfo> modelList = new List<CSLG.CTalk.Model.friendInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CSLG.CTalk.Model.friendInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CSLG.CTalk.Model.friendInfo();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["userID"]!=null && dt.Rows[n]["userID"].ToString()!="")
					{
						model.userID=int.Parse(dt.Rows[n]["userID"].ToString());
					}
					if(dt.Rows[n]["friendID"]!=null && dt.Rows[n]["friendID"].ToString()!="")
					{
						model.friendID=int.Parse(dt.Rows[n]["friendID"].ToString());
					}
					if(dt.Rows[n]["friendName"]!=null && dt.Rows[n]["friendName"].ToString()!="")
					{
					model.friendName=dt.Rows[n]["friendName"].ToString();
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

