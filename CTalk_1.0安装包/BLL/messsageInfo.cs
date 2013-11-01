using System;
using System.Data;
using System.Collections.Generic;
using CSLG.CTalk.Model;
namespace CSLG.CTalk.BLL
{
	/// <summary>
	/// messsageInfo
	/// </summary>
	public partial class messsageInfo
	{
		private readonly CSLG.CTalk.DAL.messsageInfo dal=new CSLG.CTalk.DAL.messsageInfo();
		public messsageInfo()
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
		public bool Exists(int messageID)
		{
			return dal.Exists(messageID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(CSLG.CTalk.Model.messsageInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CSLG.CTalk.Model.messsageInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int messageID)
		{
			
			return dal.Delete(messageID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string messageIDlist )
		{
			return dal.DeleteList(messageIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CSLG.CTalk.Model.messsageInfo GetModel(int messageID)
		{
			
			return dal.GetModel(messageID);
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
		public List<CSLG.CTalk.Model.messsageInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CSLG.CTalk.Model.messsageInfo> DataTableToList(DataTable dt)
		{
			List<CSLG.CTalk.Model.messsageInfo> modelList = new List<CSLG.CTalk.Model.messsageInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CSLG.CTalk.Model.messsageInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CSLG.CTalk.Model.messsageInfo();
					if(dt.Rows[n]["messageID"]!=null && dt.Rows[n]["messageID"].ToString()!="")
					{
						model.messageID=int.Parse(dt.Rows[n]["messageID"].ToString());
					}
					if(dt.Rows[n]["senderID"]!=null && dt.Rows[n]["senderID"].ToString()!="")
					{
						model.senderID=int.Parse(dt.Rows[n]["senderID"].ToString());
					}
					if(dt.Rows[n]["receiverID"]!=null && dt.Rows[n]["receiverID"].ToString()!="")
					{
						model.receiverID=int.Parse(dt.Rows[n]["receiverID"].ToString());
					}
					if(dt.Rows[n]["messageContent"]!=null && dt.Rows[n]["messageContent"].ToString()!="")
					{
					model.messageContent=dt.Rows[n]["messageContent"].ToString();
					}
					if(dt.Rows[n]["sendTime"]!=null && dt.Rows[n]["sendTime"].ToString()!="")
					{
						model.sendTime=DateTime.Parse(dt.Rows[n]["sendTime"].ToString());
					}
					if(dt.Rows[n]["messageState"]!=null && dt.Rows[n]["messageState"].ToString()!="")
					{
						model.messageState=int.Parse(dt.Rows[n]["messageState"].ToString());
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

