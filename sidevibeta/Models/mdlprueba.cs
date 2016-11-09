using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace sidevibeta.Models
{
    public class mdlprueba
    {

        DataTable dt = new DataTable();
       

            public mdlprueba(){
            
            }

        public String consulta(){

            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/sidevibeta");
            System.Configuration.ConnectionStringSettings connString;
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["NorthindConnectionString"];

            using (SqlConnection con = new SqlConnection(connString.ConnectionString))
            {   
                String query = "SELECT [id],[descripcion],[idProyecto]FROM [dbo].[CatModulos]";
                using (SqlCommand cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                    Dictionary<string, object> row;
                    foreach (DataRow dr in dt.Rows)
                    {
                        row = new Dictionary<string, object>();
                        foreach (DataColumn col in dt.Columns)
                        {
                            row.Add(col.ColumnName, dr[col]);
                        }
                        rows.Add(row);
                    }
                    return serializer.Serialize(rows);
                }

            }
        
        }



    }
}