using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;

namespace online.sql.editor.api.CommonBL
{
    public static class WebCommon
    {
        public static Dictionary<string, string> GetBasicDetails(this HttpActionContext context)
        {           
           
            var basicDetails = new Dictionary<string, string>();
          
            return basicDetails;
        }

    }
}
