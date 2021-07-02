using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Tabs
{
    public class SiaConfig
    {

        static string cn = "Data Source=64.250.116.210,8334;Initial Catalog=Milanelo_Emp010;User ID=sa;Password=Q1w2e3r4*/*;";

        public static DataTable SqlDT(string _sql)
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection sqlCon = new SqlConnection(cn))
                {
                    using (SqlDataAdapter SqlDa = new SqlDataAdapter(_sql, sqlCon))
                    {
                        SqlDa.Fill(dt);
                    }
                    
                }
            }
            catch (SqlException w)
            {
                Console.WriteLine("erro en sql:" + w);
                dt = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error :" + ex);
                dt = null;
            }
            return dt;
        }




    }
}
