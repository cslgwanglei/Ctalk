using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSLG.CTalk.BLL
{
   public static  class NormalOperation
    {
       public static DateTime getServerTime()
       {
           return DAL.NormalOperation.getServerTime();
       }
    }
}
