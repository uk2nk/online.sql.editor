
using online.sql.editor.api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online.sql.editor.api.CommonBL
{
   public static class DbCommon
    {
       public static string getConnection(BasicEntity _entity)
       {
           return "Data Source=" + _entity.ServerName + ";Initial Catalog=" + _entity.Database + ";User ID=" + _entity.UserName + ";Password=" + _entity.Password;
       }

       public static string getSelectEntity()
       {
           return "";
       }
    }
}
