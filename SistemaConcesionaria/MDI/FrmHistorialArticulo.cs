using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concesionarias.MDI
{
    public partial class FrmHistorialArticulo : Form
    {
        string _IdArticulo= "";

        public FrmHistorialArticulo(string IdArticulo)
        {
            InitializeComponent();
            this._IdArticulo = IdArticulo;
        }

        private void FrmHistorialArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                //Borro todo las filas y columnas anteriores
                DG_Datos.Columns.Clear();
                DG_Datos.Rows.Clear();

                //Busco la lista de datos
                Datos.Articulo A = Datos.Articulo.GetArticulo(_IdArticulo).ListaArticulo[0];
                this.Text = "Historial de: " + A.Descripcion_Articulo + " - " + "(Código: " + A.Codigo_Articulo + ")";

                DataSet DS = Datos.Articulo.HistorialArticulo(A.Numero_Motor_Articulo, A.Numero_Chasis_Articulo);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_RSocial", "Razón Social");
                DG_Datos.Columns.Add("Clm_Fecha", "Fecha");
                DG_Datos.Columns.Add("Clm_TipoTransaccion", "Tipo");
                DG_Datos.Columns.Add("Clm_NumeroFactura", "N° Factura");
                DG_Datos.Columns.Add("Clm_PrecioUnitarioIVA", "Precio unitario/I.V.A. inc.");
                DG_Datos.Columns.Add("Clm_Cantidad", "Cantidad");
                DG_Datos.Columns.Add("Clm_NumeroCuotas", "N° Cuotas");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_RSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_TipoTransaccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_NumeroFactura"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_PrecioUnitarioIVA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_NumeroCuotas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Configuraciones de las celdas
                DG_Datos.Columns["Clm_PrecioUnitarioIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DG_Datos.Columns["Clm_Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DG_Datos.Columns["Clm_NumeroCuotas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                foreach (DataRow ItemFila in DS.Tables[0].Rows)
                {
                    DG_Datos.Rows.Add();

                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_RSocial"].Value = ItemFila["razon_social_tercero"];
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Fecha"].Value = ItemFila["fecha_factura"];
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_TipoTransaccion"].Value = ItemFila["descripcion_factura_tipo"];
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_NumeroFactura"].Value = ItemFila["clase_factura"].ToString() + " " + Convert.ToInt32(ItemFila["puesto_factura"]).ToString("0000") + "-" + Convert.ToInt32(ItemFila["numero_factura"]).ToString("00000000");
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_PrecioUnitarioIVA"].Value = "$ " +  Common.SumarIVA(Convert.ToDecimal(ItemFila["precio_unitario_factura_detalle"]), Convert.ToDecimal(ItemFila["iva_articulo"])).ToString(Config.NumeroDecimales);
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Cantidad"].Value = ItemFila["cantidad_factura_detalle"];
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_NumeroCuotas"].Value = ItemFila["CantidadCuotas"];
                }
                BarraEstado.Items[0].Text = "Cantidad de registros: " + DS.Tables[0].Rows.Count.ToString();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
