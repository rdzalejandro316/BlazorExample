using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.ProgressBar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Tabs
{
    public partial class TabMain
    {
        public int SelectedTab { get; set; } = 0;
        private bool VisibleProperty { get; set; } = false;


        #region propiedades logicas        

        DateTime fecact = DateTime.Now;

        Pshared sharecls = new Pshared();

        public class Pshared
        {
            public List<Cuentas> cuentas { get; set; }
        }
        #endregion

       

        string conecction = "Data Source=64.250.116.210,8334;Initial Catalog=Aluwork_Emp010;User ID=sa;Password=Q1w2e3r4*/*;";

        protected override void OnInitialized()
        {            
            //progressBtnObj.IsActive = false;
        }


        private async void ClickEvent(MouseEventArgs args)
        {
            try
            {
                VisibleProperty = true;

                var slowTask = Task<List<Cuentas>>.Factory.StartNew(() => GetAll());
                await slowTask;

                if (slowTask.IsCompleted)
                {
                    sharecls.cuentas = slowTask.Result;
                    VisibleProperty = false;
                    SelectedTab = 1;
                    StateHasChanged();
                }
                                
            }
            catch (Exception e)
            {
                Console.WriteLine("error en el click:" + e);
            }
        }

        public List<Cuentas> GetAll()
        {
            using (SqlConnection cnn = new SqlConnection(conecction))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT cod_cta,nom_cta FROM comae_cta";

                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Cuentas> employees = new List<Cuentas>();
                while (reader.Read())
                {
                    Cuentas item = new Cuentas();
                    item.cod_cta = reader.GetString(0);
                    item.nom_cta = reader.GetString(1);
                    employees.Add(item);
                }
                reader.Close();
                cnn.Close();
                return employees;
            }
        }




        public class Cuentas
        {
            public string cod_cta { get; set; }
            public string nom_cta { get; set; }
        }


    }
}
