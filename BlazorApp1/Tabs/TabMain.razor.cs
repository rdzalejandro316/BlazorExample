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

        public PopUp TabPopUp;

        public int SelectedTab { get; set; } = 0;
        private bool VisibleProperty { get; set; } = false;

        #region propiedades de la consulta

        public DateTime? fecini { get; set; } = DateTime.Now;
        public DateTime? fecfin { get; set; } = DateTime.Now;

        public string Ref_ini { get; set; } = "";
        public string Ref_fin { get; set; } = "";

        public string Bod_ini { get; set; } = "";
        public string Bod_fin { get; set; } = "";

        public string Cli_ini { get; set; } = "";
        public string Cli_fin { get; set; } = "";

        public string Ven_ini { get; set; } = "";
        public string Ven_fin { get; set; } = "";

        public string Lin_ini { get; set; } = "";
        public string Lin_fin { get; set; } = "";

        public string Gru_ini { get; set; } = "";
        public string Gru_fin { get; set; } = "";

        #endregion


        Pshared sharecls = new Pshared();
        public class Pshared
        {
            public int productoRegistros { get; set; } = 0;
            public List<Producto> producto { get; set; }

            public int bodegaRegistros { get; set; } = 0;
            public List<Bodega> bodega { get; set; }

            public int clienteRegistros { get; set; } = 0;
            public List<Cliente> cliente { get; set; }

            public int vendedoresRegistros { get; set; } = 0;
            public List<Vendedor> vendedores { get; set; }

            public int lineasRegistros { get; set; } = 0;
            public List<Linea> lineas { get; set; }


            public decimal Cantidades { get; set; }
            public decimal Subtotales { get; set; }
            public decimal Descuentos { get; set; }
            public decimal Iva { get; set; }
            public decimal Totales { get; set; }


        }



        string conecction = "Data Source=64.250.116.210,8334;Initial Catalog=Milanelo_SiaApp;User ID=sa;Password=Q1w2e3r4*/*;";

        protected override void OnInitialized()
        {
            //progressBtnObj.IsActive = false;
        }


        private string ArmaWhere()
        {
            try
            {

                string cadenawhere = "";
                string RefI = Ref_ini.Trim();
                string RefF = Ref_fin.Trim();
                string BodI = Bod_ini.Trim();
                string BodF = Bod_fin.Trim();
                string TerI = Cli_ini.Trim();
                string VenI = Cli_fin.Trim();
                string TipI = Lin_ini.Trim();
                string TipF = Lin_fin.Trim();
                string GruI = Gru_ini.Trim();
                string GruF = Gru_fin.Trim();


                //string ImpI = TextBoxImpI.Text.Trim();
                if (!string.IsNullOrEmpty(RefI) && !string.IsNullOrEmpty(RefF))
                {
                    cadenawhere += " and  cue.cod_ref between '" + RefI + "' and '" + RefF + "'";
                }
                if (!string.IsNullOrEmpty(BodI) && !string.IsNullOrEmpty(BodF))
                {
                    cadenawhere += " and  cue.cod_bod between '" + BodI + "' and '" + BodF + "'";
                }
                if (!string.IsNullOrEmpty(TerI))
                {
                    cadenawhere += " and  cab.cod_cli='" + TerI + "'";
                }
                if (!string.IsNullOrEmpty(VenI))
                {
                    cadenawhere += " and  cab.cod_Ven='" + VenI + "'";
                }

                if (!string.IsNullOrEmpty(TipI) && !string.IsNullOrEmpty(TipF))
                {
                    cadenawhere += " and  ref.cod_tip between '" + TipI + "' and '" + TipF + "'";
                }
                if (!string.IsNullOrEmpty(GruI) && !string.IsNullOrEmpty(GruF))
                {
                    cadenawhere += " and  ref.cod_gru between '" + GruI + "' and '" + GruF + "'";
                }

                return cadenawhere;


            }
            catch (Exception w)
            {
                Console.WriteLine("ERRRRROR:" + w);
                return "";
            }

        }

        public void BtnOpenSearch(string tipo)
        {
            try
            {

                Console.WriteLine(tipo);

                string tabla = "";
                string codigo = "";
                string nombre = "";
                string where = "";


                switch (tipo)
                {
                    case "referencia":
                        tabla = "inmae_ref"; codigo = "cod_ref"; nombre = "nom_ref";
                        break;
                    case "bodega":
                        tabla = "inmae_bod"; codigo = "cod_bod"; nombre = "nom_bod";
                        break;
                    case "cliente":
                        tabla = "comae_ter"; codigo = "cod_ter"; nombre = "nom_ter";
                        break;
                }


                //TabPopUp.ClickBtn = ClickLoadMessage("");
                TabPopUp.OpenPopUp(tabla, codigo, nombre, where, tipo);


            }
            catch (Exception w)
            {
                Console.WriteLine("error openSearch:" + w);
            }
        }


        public void ClickLoadMessage(string tipo,string codigo)
        {

            switch (tipo)
            {
                case "referencia":
                    Ref_ini = codigo;
                    Ref_fin = codigo;
                    break;
                case "bodega":
                    Bod_ini = codigo;
                    Bod_fin = codigo;
                    break;
                case "cliente":
                    Ref_ini = codigo;
                    Ref_fin = codigo;
                    break;
            }
            StateHasChanged();
        }


        private async void ClickEvent(MouseEventArgs args)
        {
            try
            {


                VisibleProperty = true;

                string where = ArmaWhere();
                var slowTask = Task<Data>.Factory.StartNew(() => GetAll(fecini.ToString(), fecfin.ToString(), where));
                await slowTask;

                if (slowTask.IsCompleted)
                {
                    sharecls.producto = slowTask.Result.productos;
                    sharecls.productoRegistros = slowTask.Result.productos.Count;

                    sharecls.bodega = slowTask.Result.bodegas;
                    sharecls.bodegaRegistros = slowTask.Result.bodegas.Count;

                    sharecls.cliente = slowTask.Result.clientes;
                    sharecls.clienteRegistros = slowTask.Result.clientes.Count;

                    sharecls.vendedores = slowTask.Result.vendedores;
                    sharecls.vendedoresRegistros = slowTask.Result.vendedores.Count;

                    sharecls.lineas = slowTask.Result.lineas;
                    sharecls.lineasRegistros = slowTask.Result.lineas.Count;

                    sharecls.Cantidades = slowTask.Result.productos.Sum(item => item.neto);
                    sharecls.Subtotales = slowTask.Result.productos.Sum(item => item.subtotal);
                    sharecls.Descuentos = slowTask.Result.productos.Sum(item => item.val_des);
                    sharecls.Iva = slowTask.Result.productos.Sum(item => item.val_iva);
                    sharecls.Totales = slowTask.Result.productos.Sum(item => item.total);

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



        public Data GetAll(string fec_ini, string fec_fin, string where)
        {
            using (SqlConnection cnn = new SqlConnection(conecction))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("_EmpSpConsultaInAnalisisDeVentas", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaIni", fec_ini);
                cmd.Parameters.AddWithValue("@FechaFin", fec_fin);
                cmd.Parameters.AddWithValue("@Where", where);
                cmd.Parameters.AddWithValue("@codemp", "010");
                da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandTimeout = 0;
                da.Fill(ds);


                List<Producto> lproducto = new List<Producto>();
                List<Bodega> lbodegas = new List<Bodega>();
                List<Cliente> lcliente = new List<Cliente>();
                List<Vendedor> lvendedor = new List<Vendedor>();
                List<Linea> llinea = new List<Linea>();

                Data data = new Data();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Producto producto = new Producto();
                    producto.cod_ref = dr["cod_ref"].ToString().Trim();
                    producto.nom_ref = dr["nom_ref"].ToString().Trim();
                    producto.cantidad = Convert.ToDecimal(dr["cantidad"]);
                    producto.can_dev = Convert.ToDecimal(dr["can_dev"]);
                    producto.neto = Convert.ToDecimal(dr["neto"]);
                    producto.subtotal = Convert.ToDecimal(dr["subtotal"]);
                    producto.val_des = Convert.ToDecimal(dr["val_des"]);
                    producto.val_iva = Convert.ToDecimal(dr["val_iva"]);
                    producto.total = Convert.ToDecimal(dr["total"]);
                    lproducto.Add(producto);
                }

                foreach (DataRow dr in ds.Tables[1].Rows)
                {
                    Bodega bodega = new Bodega();
                    bodega.cod_bod = dr["cod_bod"].ToString().Trim();
                    bodega.nom_bod = dr["nom_bod"].ToString().Trim();
                    bodega.cantidad = Convert.ToDecimal(dr["cantidad"]);
                    bodega.can_dev = Convert.ToDecimal(dr["can_dev"]);
                    bodega.neto = Convert.ToDecimal(dr["neto"]);
                    bodega.subtotal = Convert.ToDecimal(dr["subtotal"]);
                    bodega.val_des = Convert.ToDecimal(dr["val_des"]);
                    bodega.val_iva = Convert.ToDecimal(dr["val_iva"]);
                    bodega.total = Convert.ToDecimal(dr["total"]);
                    lbodegas.Add(bodega);
                }

                foreach (DataRow dr in ds.Tables[2].Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.cod_cli = dr["cod_cli"].ToString().Trim();
                    cliente.nom_cli = dr["nom_cli"].ToString().Trim();
                    cliente.cantidad = Convert.ToDecimal(dr["cantidad"]);
                    cliente.can_dev = Convert.ToDecimal(dr["can_dev"]);
                    cliente.neto = Convert.ToDecimal(dr["neto"]);
                    cliente.subtotal = Convert.ToDecimal(dr["subtotal"]);
                    cliente.val_des = Convert.ToDecimal(dr["val_des"]);
                    cliente.val_iva = Convert.ToDecimal(dr["val_iva"]);
                    cliente.total = Convert.ToDecimal(dr["total"]);
                    lcliente.Add(cliente);
                }

                foreach (DataRow dr in ds.Tables[3].Rows)
                {
                    Vendedor vendedor = new Vendedor();
                    vendedor.cod_ven = dr["cod_ven"].ToString().Trim();
                    vendedor.nom_ven = dr["nom_ven"].ToString().Trim();
                    vendedor.cantidad = Convert.ToDecimal(dr["cantidad"]);
                    vendedor.can_dev = Convert.ToDecimal(dr["can_dev"]);
                    vendedor.neto = Convert.ToDecimal(dr["neto"]);
                    vendedor.subtotal = Convert.ToDecimal(dr["subtotal"]);
                    vendedor.val_des = Convert.ToDecimal(dr["val_des"]);
                    vendedor.val_iva = Convert.ToDecimal(dr["val_iva"]);
                    vendedor.total = Convert.ToDecimal(dr["total"]);
                    lvendedor.Add(vendedor);
                }

                foreach (DataRow dr in ds.Tables[4].Rows)
                {
                    Linea linea = new Linea();
                    linea.cod_tip = dr["cod_mar"].ToString().Trim();
                    linea.nom_tip = dr["nom_mar"].ToString().Trim();
                    linea.cantidad = Convert.ToDecimal(dr["cantidad"]);
                    linea.can_dev = Convert.ToDecimal(dr["can_dev"]);
                    linea.neto = Convert.ToDecimal(dr["neto"]);
                    linea.subtotal = Convert.ToDecimal(dr["subtotal"]);
                    linea.val_des = Convert.ToDecimal(dr["val_des"]);
                    linea.val_iva = Convert.ToDecimal(dr["val_iva"]);
                    linea.total = Convert.ToDecimal(dr["total"]);
                    llinea.Add(linea);
                }

                data.productos = lproducto;
                data.bodegas = lbodegas;
                data.clientes = lcliente;
                data.vendedores = lvendedor;
                data.lineas = llinea;

                cnn.Close();
                return data;
            }
        }



        public class Data
        {
            public List<Producto> productos { get; set; }
            public List<Bodega> bodegas { get; set; }
            public List<Cliente> clientes { get; set; }
            public List<Vendedor> vendedores { get; set; }
            public List<Linea> lineas { get; set; }

        }

        public class Ventas
        {
            public decimal cantidad { get; set; }
            public decimal can_dev { get; set; }
            public decimal neto { get; set; }
            public decimal subtotal { get; set; }
            public decimal val_des { get; set; }
            public decimal val_iva { get; set; }
            public decimal total { get; set; }

        }

        public class Producto : Ventas
        {
            public string cod_ref { get; set; }
            public string nom_ref { get; set; }
        }

        public class Bodega : Ventas
        {
            public string cod_bod { get; set; }
            public string nom_bod { get; set; }

        }

        public class Cliente : Ventas
        {
            public string cod_cli { get; set; }
            public string nom_cli { get; set; }

        }

        public class Vendedor : Ventas
        {
            public string cod_ven { get; set; }
            public string nom_ven { get; set; }

        }

        public class Linea : Ventas
        {
            public string cod_tip { get; set; }
            public string nom_tip { get; set; }

        }


    }
}
