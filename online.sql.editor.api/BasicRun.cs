
using online.sql.editor.api.CommonBL;
using online.sql.editor.api.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online.sql.editor.api
{
   public class BasicRun
    {       
       public ResponseEntity getBasicRun(BasicEntity _bEntity)
       {
           SqlConnection myConnection = new SqlConnection();
           myConnection.ConnectionString = DbCommon.getConnection(_bEntity);
           DataSet ds = new DataSet();
           SqlDataAdapter adapter = new SqlDataAdapter(_bEntity.Query, myConnection);
           myConnection.Open();
           adapter.Fill(ds);
           adapter.Dispose();
           myConnection.Close();
           ResponseEntity _rEntity = new ResponseEntity();
           _rEntity.columnDefs = new List<ColumnDef>();

           for (int i = 0; i <= ds.Tables[0].Columns.Count - 1; i++)
           {
               _rEntity.columnDefs.Add(new ColumnDef { field = ds.Tables[0].Columns[i].ColumnName.ToUpper().ToString(), 
                   name = ds.Tables[0].Columns[i].ColumnName.ToString(),
                                                       width=150
               });             

           }
           
           _rEntity.data = ds.Tables[0];
           return _rEntity;
           
       }
       public string InsertRecord(BasicEntity _bEntity)
       {
           SqlConnection myConnection = new SqlConnection();
           myConnection.ConnectionString = DbCommon.getConnection(_bEntity);
           DataSet ds = new DataSet();
           SqlDataAdapter adapter = new SqlDataAdapter(_bEntity.Query, myConnection);
           SqlCommand comm;
           myConnection.Open();
           comm = new SqlCommand(_bEntity.Query, myConnection);
           try
           {
               comm.ExecuteNonQuery();
               return "Inserted Successfully";
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               myConnection.Close();
           }
       }
    }
}
