using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Concesionarias.MDI
{
    public partial class FrmArticulos : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        DataGridViewPrinter MyDataGridViewPrinter;

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            ValorReturn = "";

            Datos.Categoria C = Datos.Categoria.GetCategoria("");

            Cbo_Categoria.Items.Add("- [TODOS]");
            foreach (Datos.Categoria itemCategoria in C.ListaCategoria)
            {
                Cbo_Categoria.Items.Add(itemCategoria.Id_Categoria + "- " + itemCategoria.Descripcion_Categoria);
            }
            Cbo_Categoria.SelectedIndex = 0;

            Datos.Linea L = Datos.Linea.GetLinea("");

            CboLinea.Items.Add("- [TODOS]");
            foreach (Datos.Linea itemLinea in L.ListaLinea)
            {
                CboLinea.Items.Add(itemLinea.Id_Linea + "- " + itemLinea.Descripcion_Linea);
            }
            CboLinea.SelectedIndex = 0;

            Buscar();

            //buscal el total que hay en precio lista y venta + iva's
            Datos.Articulo ARTs = Datos.Articulo.GetArticulo("");

            decimal totalLista = 0;
            decimal totalVenta = 0;
            foreach (Datos.Articulo itemArticulo in ARTs.ListaArticulo)
            {
                totalLista += Common.SumarIVA(itemArticulo.Precio_Costo_Articulo, itemArticulo.IVA_Articulo) * itemArticulo.Stock_Articulo;
                totalVenta += Common.SumarIVA(itemArticulo.Precio_Venta_Articulo, itemArticulo.IVA_Articulo) * itemArticulo.Stock_Articulo;
            }

            Txt_TotalLista.Text = "$ " + totalLista.ToString(Config.NumeroDecimales);
            Txt_TotalVenta.Text = "$ " + totalVenta.ToString(Config.NumeroDecimales);
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmArticulosABM Frm = new FrmArticulosABM();
            Frm.ShowDialog();
            Buscar();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmArticulosABM Frm = new FrmArticulosABM(DG_Datos.SelectedRows[0].Tag.ToString());
                if (Frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Buscar();
                }
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila de la grilla de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscar()
        {
            try
            {
                //Borro todo las filas y columnas anteriores
                DG_Datos.Columns.Clear();
                DG_Datos.Rows.Clear();

                //Busco la lista de datos
                Datos.Articulo A = Datos.Articulo.GetArticuloRelacional(Txt_Id.Text, Txt_Codigo.Text, CboLinea.SelectedItem.ToString().Split(Convert.ToChar("-"))[0], Cbo_Categoria.SelectedItem.ToString().Split(Convert.ToChar("-"))[0], id_TerceroTextBox.Text);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_Codigo_Articulo", "Codigo Articulo");
                DG_Datos.Columns.Add("Clm_Descripcion_Articulo", "Descripcion");
                DG_Datos.Columns.Add("Clm_Stock_Articulo", "Stock");
                DG_Datos.Columns.Add("Clm_Precio_Costo_Articulo", "PrecioCosto");
                DG_Datos.Columns.Add("Clm_Precio_Venta_Articulo", "Precio");
                DG_Datos.Columns.Add("Clm_Observaciones_Articulo", "Observaciones");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_Codigo_Articulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Descripcion_Articulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Stock_Articulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Precio_Costo_Articulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Precio_Venta_Articulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Observaciones_Articulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Configuraciones de las celdas
                DG_Datos.Columns["Clm_Precio_Venta_Articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DG_Datos.Columns["Clm_Precio_Costo_Articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                foreach (Datos.Articulo ItemArticulo in A.ListaArticulo)
                {
                    bool MostrarFila = true;

                    if (!MostrarAnuladoscheckBox2.Checked)
                    {
                        if (ItemArticulo.Anulado_Articulo)
                        {
                            MostrarFila = false;
                        }
                    }

                    if (Stock_ConStock_radioButton2.Checked)
                    {
                        if (ItemArticulo.Stock_Articulo <= 0)
                        {
                            MostrarFila = false;
                        }
                    }

                    if (Stock_Repocicion_radioButton3.Checked)
                    {
                        if (ItemArticulo.Stock_Articulo > ItemArticulo.Stock_Minimo_Articulo)
                        {
                            MostrarFila = false;
                        }
                    }

                    if (MostrarFila)
                    {
                        DG_Datos.Rows.Add();
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemArticulo.Id_Articulo;

                        if (ItemArticulo.Anulado_Articulo)
                        {
                            DG_Datos.Rows[DG_Datos.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                        }

                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Codigo_Articulo"].Value = ItemArticulo.Codigo_Articulo;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Descripcion_Articulo"].Value = ItemArticulo.Descripcion_Articulo;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Stock_Articulo"].Value = ItemArticulo.Stock_Articulo;

                        if (IvaIncluidocheckBox1.Checked)
                        {
                            DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Precio_Costo_Articulo"].Value = "$ " + Common.SumarIVA(ItemArticulo.Precio_Costo_Articulo, ItemArticulo.IVA_Articulo).ToString(Config.NumeroDecimales);
                            DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Precio_Venta_Articulo"].Value = "$ " + Common.SumarIVA(ItemArticulo.Precio_Venta_Articulo, ItemArticulo.IVA_Articulo).ToString(Config.NumeroDecimales);
                        }
                        else
                        {
                            DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Precio_Costo_Articulo"].Value = "$ " + ItemArticulo.Precio_Costo_Articulo.ToString(Config.NumeroDecimales);
                            DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Precio_Venta_Articulo"].Value = "$ " + ItemArticulo.Precio_Venta_Articulo.ToString(Config.NumeroDecimales);
                        }
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Observaciones_Articulo"].Value = ItemArticulo.Observaciones_Articulo;
                    }
                }

                Txt_CantidadRegistros.Text = A.ListaArticulo.Count.ToString();

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
                    Datos.Articulo.Delete(DG_Datos.SelectedRows[0].Tag.ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            id_TerceroTextBox.Text = "";
            Txt_NombreTercero.Text = "";
        }

        private void Btn_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila de la grilla de datos.");
                }

                DialogResult ResultadoDialogo = MessageBox.Show("¿Desea dar de baja este registro? \r\nID: " + DG_Datos.SelectedRows[0].Tag.ToString(), "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (ResultadoDialogo == System.Windows.Forms.DialogResult.OK)
                {
                    Datos.Articulo A = Datos.Articulo.GetArticulo(DG_Datos.SelectedRows[0].Tag.ToString());
                    A.ListaArticulo[0].Anulado_Articulo = true;
                    Datos.Articulo.Set(A.ListaArticulo[0]);
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila de la grilla de datos.");
                }

                DialogResult ResultadoDialogo = MessageBox.Show("¿Desea dar de alta este registro? \r\nID: " + DG_Datos.SelectedRows[0].Tag.ToString(), "Alta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (ResultadoDialogo == System.Windows.Forms.DialogResult.OK)
                {
                    Datos.Articulo A = Datos.Articulo.GetArticulo(DG_Datos.SelectedRows[0].Tag.ToString());
                    A.ListaArticulo[0].Anulado_Articulo = false;
                    Datos.Articulo.Set(A.ListaArticulo[0]);
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_BuscarTercero_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmC = new MDI.FrmTercero(1);
            FrmC.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                id_TerceroTextBox.Text = MDI.FrmTercero.ValorReturn;
                Txt_NombreTercero.Text = Datos.Tercero.GetTercero(id_TerceroTextBox.Text,"").ListaTercero[0].Razon_Social_Tercero;
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
            else
            {
                Btn_Editar_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmHistorialArticulo Frm = new FrmHistorialArticulo(DG_Datos.SelectedRows[0].Tag.ToString());
                Frm.MdiParent = this.ParentForm;
                Frm.Show();
                Buscar();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila de la grilla de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        private void Btn_Papel_Click(object sender, EventArgs e)
        {
            try
            {
                pageSetupDialog1.Document = MyPrintDocument;
                pageSetupDialog1.ShowDialog();
                MyPrintDocument.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Opciones_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = MyPrintDocument;
                printDialog1.ShowDialog();
                MyPrintDocument.PrinterSettings = printDialog1.PrinterSettings;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_VistaPrevia_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = MyPrintDocument;
                MyPrintPreviewDialog.ShowDialog();
            }
            Buscar();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                MyPrintDocument.Print();
            }
            //Close();
        }

        private bool SetupThePrinting()
        {
            //PrintDialog MyPrintDialog = new PrintDialog();
            printDialog1.AllowCurrentPage = false;
            printDialog1.AllowPrintToFile = false;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;
            printDialog1.PrintToFile = false;
            printDialog1.ShowHelp = false;
            printDialog1.ShowNetwork = false;

            if (printDialog1.ShowDialog() != DialogResult.OK)
            {
                return false;
            }

            MyPrintDocument.DocumentName = "Lista de artículos";
            MyPrintDocument.PrinterSettings = printDialog1.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = printDialog1.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(12, 12, 20, 100);

            //DG_Datos.Columns.RemoveAt(2);
            //DG_Datos.Columns.RemoveAt(2);
            //DG_Datos.Columns.RemoveAt(3);

            MyDataGridViewPrinter = new DataGridViewPrinter(DG_Datos, MyPrintDocument, false, true, "Lista de artículos del " + DateTime.Now.ToLongDateString(), new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }
    }
}
