using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online.sql.editor.api.Entity
{
    public class BasicEntity
    {
        public string Query { get; set; }
        public string ServerName { get; set; }
        public string Database { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class ColumnDef
    {
        public string name { get; set; }
        public string field { get; set; }        
        public int width { get; set; }
    }
    public class ResponseEntity
    {
        public List<ColumnDef> columnDefs { get; set; }
        public DataTable data { get; set; }
    }
}
