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
    public partial class FrmDocumento : Form
    {

        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmDocumento()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmDocumentoABM FrmCABM = new FrmDocumentoABM();
            FrmCABM.ShowDialog();
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                //Borro todo las filas y columnas anteriores
                DG_Datos.Columns.Clear();
                DG_Datos.Rows.Clear();

                //Busco la lista de datos
                Datos.Documento D = Datos.Documento.GetDocumentoRelacional(Txt_Id.Text, razon_social_textBox1.Text);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_Numero", "N° de entrega");
                DG_Datos.Columns.Add("Clm_Nombre", "Nombre");
                DG_Datos.Columns.Add("Clm_Unidad", "Unidad");
                DG_Datos.Columns.Add("Clm_Fecha", "Fecha");
                DG_Datos.Columns.Add("Clm_Domicilio", "Dominio");
                DG_Datos.Columns.Add("Clm_Observaciones", "Observaciones");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_Numero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Unidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Domicilio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Observaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Agrego las filas
                foreach (Datos.Documento ItemDocumento in D.ListaDocumento)
                {
                    DG_Datos.Rows.Add();
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemDocumento.Id_Documento;

                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Numero"].Value = ItemDocumento.Id_Documento;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Nombre"].Value = Datos.Factura.GetFacturaRelacional(ItemDocumento.Id_Factura.ToString(), "", "", "", "","").ListaFactura[0].Tercero.Razon_Social_Tercero;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Unidad"].Value = Datos.Factura_detalle.GetFactura_detalleRelacional("", ItemDocumento.Id_Factura.ToString()).ListaFactura_detalle[0].Articulo.Descripcion_Articulo;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Fecha"].Value = ItemDocumento.Fecha_Entrega_Documento;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Domicilio"].Value = ItemDocumento.Dominio_Documento;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Observaciones"].Value = ItemDocumento.Observaciones_Documento;

                }

                Txt_CantidadRegistros.Text = D.ListaDocumento.Count.ToString();

                if (NumeroFilaUltimaSeleccion != 0 && DG_Datos.Rows.Count > NumeroFilaUltimaSeleccion)
                {
                    DG_Datos.Rows[NumeroFilaUltimaSeleccion].Selected = true;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            ValorReturn = "";
            Close();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila de la grilla de datos.");
                }

                DialogResult ResultadoDialogo = MessageBox.Show("¿Desea eliminar este registro? \r\nID: " + DG_Datos.SelectedRows[0].Tag.ToString(), "Borrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (ResultadoDialogo == System.Windows.Forms.DialogResult.OK)
                {
                    Datos.Documento.Delete(DG_Datos.SelectedRows[0].Tag.ToString());
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (DG_Datos.SelectedRows.Count == 0)
            {
                ValorReturn = "";
            }
            else
            {
                ValorReturn = DG_Datos.SelectedRows[0].Tag.ToString();
            }
            Close();
        }

        private void FrmCategoria_Load_1(object sender, EventArgs e)
        {
            Buscar();
        }

        private void DG_Datos_Click(object sender, EventArgs e)
        {
            try
            {
                NumeroFilaUltimaSeleccion = DG_Datos.SelectedRows[0].Index;
            }
            catch
            {
                NumeroFilaUltimaSeleccion = 0;
            }
        }

        private void DG_Datos_DoubleClick(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    ValorReturn = "";
                }
                else
                {
                    ValorReturn = DG_Datos.SelectedRows[0].Tag.ToString();
                }
                Close();
            }
        }
    }
}
