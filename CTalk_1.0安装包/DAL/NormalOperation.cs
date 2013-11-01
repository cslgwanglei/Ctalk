using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;
namespace CSLG.CTalk.DAL
{
   public static  class NormalOperation
    {
       public static DateTime getServerTime()
       {
           string sql = "select top 1  getdate()from userinfo";
           object o = DbHelperSQL.GetSingle(sql);
           return (DateTime)o;
       }


    }
}
