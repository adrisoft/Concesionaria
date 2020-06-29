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
    public partial class FrmFacturaABM : Form
    {
        int _TipoFactura;
        string TipoComprobanteAnterior = "";
        bool SegundaImpresion = true;

        bool CerrarVentana = false;

        public FrmFacturaABM(int TipoFactura)
        {
            InitializeComponent();
            AcomodarFactura(TipoFactura);
        }

        public FrmFacturaABM(string IdFactura, int TipoFactura)
        {
            InitializeComponent();
            try
            {
                //Desabilito el boton para modificar..
                Btn_Aceptar.Enabled = false;

                //Busco el una unica fila por su id
                Datos.Factura F = Datos.Factura.GetFacturaRelacional(IdFactura, TipoFactura.ToString(), "", "", "", "");

                Txt_Id.Text = IdFactura;
                _TipoFactura = F.ListaFactura[0].Id_Factura_Tipo;

                id_TerceroTextBox.Text = F.ListaFactura[0].Id_Tercero.ToString();
                Txt_NombreTercero.Text = F.ListaFactura[0].Tercero.Razon_Social_Tercero;

                fecha_FacturaDateTimePicker.Value = F.ListaFactura[0].Fecha_Factura;
                fecha_Vencimiento_FacturaDateTimePicker.Value = F.ListaFactura[0].Fecha_Vencimiento_Factura;
                puesto_FacturaTextBox.Text = F.ListaFactura[0].Puesto_Factura.ToString("0000");
                numero_Comprobante_FacturaTextBox.Text = F.ListaFactura[0].Numero_Factura.ToString("00000000");
                clase_FacturacomboBox.Text = F.ListaFactura[0].Clase_Factura;
                neto_FacturaTextBox.Value = F.ListaFactura[0].Neto_Factura;
                iva_1_FacturaTextBox.Value = F.ListaFactura[0].IVA_105_Factura;
                iva_2_FacturaTextBox.Value = F.ListaFactura[0].IVA_21_Factura;
                iva_27_FacturaTextBox.Value = F.ListaFactura[0].IVA_27_Factura;
                percep_FacturaTextBox.Value = F.ListaFactura[0].Percepcion_Factura;
                exentos_FacturaTextBox.Value = F.ListaFactura[0].Exentos_Factura;
                otros_FacturaTextBox.Value = F.ListaFactura[0].Otros_Factura;
                total_FacturaTextBox.Value = F.ListaFactura[0].Total_Factura;
                retencion_FacturaTextBox.Value = F.ListaFactura[0].Retencion_Factura;
                anulado_facturaCheckBox.Checked = F.ListaFactura[0].Anulado_Factura;
                ObservacionestextBox.Text = F.ListaFactura[0].Observaciones_Factura;
                Interes_numericUpDown2.Value = F.ListaFactura[0].Interes_Factura;

                //Leno la grilla de los productos
                Datos.Factura_detalle FD = Datos.Factura_detalle.GetFactura_detalleRelacional("", IdFactura);

                foreach (Datos.Factura_detalle ItemFactura_detalle in FD.ListaFactura_detalle)
                {
                    DG_Productos.Rows.Add();
                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Tag = ItemFactura_detalle.Id_Articulo;

                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Codigo"].Value = ItemFactura_detalle.Articulo.Codigo_Articulo;
                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Descripcion"].Value = ItemFactura_detalle.Articulo.Descripcion_Articulo;
                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Cantidad"].Value = ItemFactura_detalle.Cantidad_Factura_Detalle;
                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_IVA"].Value = ItemFactura_detalle.Articulo.IVA_Articulo.ToString(Config.NumeroDecimales);
                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Precio"].Value = ItemFactura_detalle.Precio_Unitario_Factura_Detalle.ToString(Config.NumeroDecimales);
                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Total"].Value = Common.SumarIVA((ItemFactura_detalle.Cantidad_Factura_Detalle * ItemFactura_detalle.Precio_Unitario_Factura_Detalle), ItemFactura_detalle.Articulo.IVA_Articulo).ToString(Config.NumeroDecimales);
                }

                Datos.Factura_garante FG = Datos.Factura_garante.GetFactura_garanteRelacional("", IdFactura);

                foreach (Datos.Factura_garante itemFactura_garante in FG.ListaFactura_garante)
                {
                    DG_Garantes.Rows.Add();
                    DG_Garantes.Rows[DG_Garantes.Rows.Count - 1].Tag = itemFactura_garante.Tercero.Id_Tercero;
                    DG_Garantes.Rows[DG_Garantes.Rows.Count - 1].Cells["Clm_Nombre"].Value = itemFactura_garante.Tercero.Razon_Social_Tercero;
                }

                Datos.Couta Ctas = Datos.Couta.GetCouta("", IdFactura, "");

                if (Ctas.ListaCouta.Count > 0)
                {
                    dateTimePicker_PrimeraCuotaDesde.Value = Ctas.ListaCouta[0].Fecha_Vencimineto_Couta;
                    NumeroCuotas_numericUpDown1.Value = Ctas.ListaCouta.Count;
                }

                if (!F.ListaFactura[0].Anulado_Factura)
                {
                    CalcularProductos();
                }

                NUD_ValorCuota.Value = F.ListaFactura[0].Total_Factura / NumeroCuotas_numericUpDown1.Value;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            AcomodarFactura(TipoFactura);
        }

        private void AcomodarFactura(int TipoFactura)
        {
            try
            {
                this.Text = Datos.Factura_tipo.GetFactura_tipo(TipoFactura.ToString()).ListaFactura_tipo[0].Descripcion_Factura_Tipo;
            }
            catch
            {
                this.Text = "";
            }
            _TipoFactura = TipoFactura;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ControlValores())
                {
                    return;
                }

                Datos.Factura F = new Datos.Factura();
                Datos.Factura_detalle FD = new Datos.Factura_detalle();
                FD.ListaFactura_detalle = new List<Datos.Factura_detalle>();
                Datos.Couta C = new Datos.Couta();
                C.ListaCouta = new List<Datos.Couta>();
                Datos.Factura_garante G = new Datos.Factura_garante();
                G.ListaFactura_garante = new List<Datos.Factura_garante>();

                F.Id_Factura = (Txt_Id.Text == "") ? 0 : Convert.ToInt32(Txt_Id.Text);
                F.Id_Factura_Tipo = _TipoFactura;
                F.Id_Tercero = Convert.ToInt32(id_TerceroTextBox.Text);

                F.Fecha_Factura = fecha_FacturaDateTimePicker.Value;
                F.Fecha_Vencimiento_Factura = fecha_Vencimiento_FacturaDateTimePicker.Value;
                F.Puesto_Factura = Convert.ToInt32(puesto_FacturaTextBox.Text);
                F.Numero_Factura = Convert.ToInt32(numero_Comprobante_FacturaTextBox.Text);
                F.Clase_Factura = clase_FacturacomboBox.Text;
                F.Neto_Factura = neto_FacturaTextBox.Value;
                F.IVA_105_Factura = iva_1_FacturaTextBox.Value;
                F.IVA_21_Factura = iva_2_FacturaTextBox.Value;
                F.IVA_27_Factura = iva_27_FacturaTextBox.Value;
                F.Percepcion_Factura = percep_FacturaTextBox.Value;
                F.Exentos_Factura = exentos_FacturaTextBox.Value;
                F.Otros_Factura = otros_FacturaTextBox.Value;
                F.Total_Factura = total_FacturaTextBox.Value;
                F.Retencion_Factura = retencion_FacturaTextBox.Value;
                F.Anulado_Factura = anulado_facturaCheckBox.Checked;
                F.Observaciones_Factura = ObservacionestextBox.Text;
                F.Interes_Factura = Interes_numericUpDown2.Value;

                foreach (DataGridViewRow Fila in DG_Productos.Rows)
                {
                    Datos.Factura_detalle TEMP = new Datos.Factura_detalle();
                    TEMP.Id_Articulo = Convert.ToInt32(Fila.Tag);

                    TEMP.Cantidad_Factura_Detalle = Convert.ToInt32(Fila.Cells["Clm_Cantidad"].Value);

                    TEMP.Precio_Unitario_Factura_Detalle = Convert.ToDecimal(Fila.Cells["Clm_Precio"].Value);
                    TEMP.Bonifica_Factura_Detalle = 0;

                    FD.ListaFactura_detalle.Add(TEMP);
                }

                for (int i = 0; i < NumeroCuotas_numericUpDown1.Value; i++)
                {
                    Datos.Couta TEMP = new Datos.Couta();
                    TEMP.Numero_Couta_Couta = i + 1;

                    TEMP.Fecha_Vencimineto_Couta = dateTimePicker_PrimeraCuotaDesde.Value.AddMonths(i);
                    TEMP.Observaciones_Couta = "";

                    TEMP.Importe_Couta = NUD_ValorCuota.Value;
                    C.ListaCouta.Add(TEMP);
                }

                foreach (DataGridViewRow Fila in DG_Garantes.Rows)
                {
                    Datos.Factura_garante TEMP = new Datos.Factura_garante();
                    TEMP.Id_Tercero = Convert.ToInt32(Fila.Tag);

                    G.ListaFactura_garante.Add(TEMP);
                }

                if (Txt_Id.Text == "")
                {
                    AcomodarNumeroComprobante();
                    if (FD.ListaFactura_detalle.Count == 0)
                    {
                        if (MessageBox.Show("Esta agregando una factura sin articulos, ¿Desea continuar?", "Factura sin articulos!", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                        {
                            return;
                        }
                    }

                    MDI.FrmDialogoFactura FDF = new FrmDialogoFactura(TipoComprobanteAnterior, clase_FacturacomboBox.Text, puesto_FacturaTextBox.Text, numero_Comprobante_FacturaTextBox.Text);
                    if (FDF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.numero_Comprobante_FacturaTextBox.Text = FDF._NumeroComprobante;

                        F.Numero_Factura = Convert.ToInt32(FDF._NumeroComprobante);

                        if (Chk_Imprimir.Checked)
                        {
                            ImprimirDocumento.Print();
                        }

                        Datos.Factura.AddFactura_detalle(F, FD, C, G);

                        if (_TipoFactura != 1)
                        {
                            AcomodarNumeroComprobante();
                            Datos.Series.DesbloquearSumar(TipoComprobanteAnterior);
                        }
                        MessageBox.Show("Se ha agregado un nuevo registro.");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (_TipoFactura != 1)
                    {
                        if (MessageBox.Show("Al modificar esta comprobante, borra las cuotas y las creará de nuevo, ¿desea continuar?", "Modificación", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Datos.Factura.SetFactura_detalle(F, FD, C, G);
                            MessageBox.Show("Se ha modificado correctamente el registro.");
                        }
                    }
                    else
                    {
                        Datos.Factura.SetFactura_detalle(F, FD, C, G);
                        MessageBox.Show("Se ha modificado correctamente el registro.");
                    }
                }
                CerrarVentana = true;
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana = true;
            Close();
        }

        private void Btn_BuscarTercero_Click(object sender, EventArgs e)
        {
            int TipoTercero;
            if (_TipoFactura == 1)
            {
                TipoTercero = 1;
            }
            else
            {
                TipoTercero = 2;
            }
            MDI.FrmTercero FrmV = new MDI.FrmTercero(TipoTercero);
            FrmV.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                id_TerceroTextBox.Text = MDI.FrmTercero.ValorReturn;
                Txt_NombreTercero.Text = Datos.Tercero.GetTercero(id_TerceroTextBox.Text, "").ListaTercero[0].Razon_Social_Tercero;
            }

            //if (Datos.Tercero.GetTercero(id_TerceroTextBox.Text, "").ListaTercero[0].Id_Tercero_IVA == 1)
            //{
            //    clase_FacturacomboBox.SelectedIndex = 0;
            //}
            //else
            //{
            //    clase_FacturacomboBox.SelectedIndex = 1;
            //}
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            MDI.FrmArticulos FrmS = new MDI.FrmArticulos();
            FrmS.ShowDialog();
            if (MDI.FrmArticulos.ValorReturn != "")
            {
                bool Existe = false;
                foreach (DataGridViewRow Fila in DG_Productos.Rows)
                {
                    if (Fila.Tag.ToString() == MDI.FrmArticulos.ValorReturn.ToString())
                    {
                        try
                        {
                            DG_Productos.Rows[Fila.Index].Cells["Clm_Cantidad"].Value = Convert.ToInt32(DG_Productos.Rows[Fila.Index].Cells["Clm_Cantidad"].Value) + 1;
                            Existe = true;
                            DG_Productos.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        catch
                        {
                            Existe = true;
                            DG_Productos.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }

                if (!Existe)
                {
                    Datos.Articulo A = Datos.Articulo.GetArticulo(MDI.FrmArticulos.ValorReturn);
                    DG_Productos.Rows.Add();

                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Tag = MDI.FrmArticulos.ValorReturn;

                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Codigo"].Value = A.ListaArticulo[0].Codigo_Articulo;
                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Descripcion"].Value = A.ListaArticulo[0].Descripcion_Articulo;
                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Cantidad"].Value = 1;
                    DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_IVA"].Value = A.ListaArticulo[0].IVA_Articulo.ToString(Config.NumeroDecimales);
                    if (_TipoFactura == 1)
                    {
                        DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Precio"].Value = A.ListaArticulo[0].Precio_Costo_Articulo.ToString(Config.NumeroDecimales);
                        DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Total"].Value = (Common.SumarIVA(A.ListaArticulo[0].Precio_Costo_Articulo, A.ListaArticulo[0].IVA_Articulo)).ToString(Config.NumeroDecimales);
                    }
                    else
                    {
                        DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Precio"].Value = A.ListaArticulo[0].Precio_Venta_Articulo.ToString(Config.NumeroDecimales);
                        DG_Productos.Rows[DG_Productos.Rows.Count - 1].Cells["Clm_Total"].Value = (Common.SumarIVA(A.ListaArticulo[0].Precio_Venta_Articulo, A.ListaArticulo[0].IVA_Articulo)).ToString(Config.NumeroDecimales);
                    }
                }
            }
            CalcularProductos();
        }

        private void Btn_Quitar_Click(object sender, EventArgs e)
        {
            if (DG_Productos.SelectedRows.Count > 0)
            {
                DG_Productos.Rows.RemoveAt(DG_Productos.SelectedRows[0].Index);
                CalcularProductos();
            }
        }

        private void CalcularProductos()
        {
            decimal Total = 0;
            decimal Neto = 0;
            decimal IVA21 = 0;
            decimal IVA105 = 0;
            decimal IVA27 = 0;
            decimal Exentos = 0;
            foreach (DataGridViewRow Fila in DG_Productos.Rows)
            {
                try
                {
                    decimal Cantidad = Convert.ToDecimal(Fila.Cells["Clm_Cantidad"].Value);
                    decimal Precio = Convert.ToDecimal(Fila.Cells["Clm_Precio"].Value);
                    decimal iva = Convert.ToDecimal(Fila.Cells["Clm_IVA"].Value);


                    if (iva == 10.5M)
                    {
                        IVA105 += (Precio / 100 * iva) * Cantidad;
                    }
                    if (iva == 21)
                    {
                        IVA21 += (Precio / 100 * iva) * Cantidad;
                    }
                    if (iva == 27)
                    {
                        IVA27 += (Precio / 100 * iva) * Cantidad;
                    }
                    if (iva == 0)
                    {
                        Exentos += Precio * Cantidad;
                    }
                    else
                    {
                        Neto += Precio * Cantidad;
                    }

                    Total += Cantidad * Common.SumarIVA(Precio, iva);

                    decimal PrecioInteres = System.Math.Round(Common.SumarIVA(Precio, Interes_numericUpDown2.Value),4);
                    decimal PrecioInteresIVA = System.Math.Round(Common.SumarIVA(PrecioInteres, iva), 4);
                    DG_Productos.Rows[Fila.Index].Cells["Clm_Total"].Value = (Cantidad * PrecioInteresIVA).ToString(Config.NumeroDecimales);
                    DG_Productos.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.White;
                }
                catch
                {
                    DG_Productos.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.Red;
                }
            }

            neto_FacturaTextBox.Value = Common.SumarIVA(Neto, Interes_numericUpDown2.Value);
            iva_1_FacturaTextBox.Value = Common.SumarIVA(IVA21, Interes_numericUpDown2.Value);
            iva_2_FacturaTextBox.Value = Common.SumarIVA(IVA105, Interes_numericUpDown2.Value);
            iva_27_FacturaTextBox.Value = Common.SumarIVA(IVA27, Interes_numericUpDown2.Value);
            exentos_FacturaTextBox.Value = Common.SumarIVA(Exentos, Interes_numericUpDown2.Value);
            total_FacturaTextBox.Value = neto_FacturaTextBox.Value + iva_1_FacturaTextBox.Value + iva_2_FacturaTextBox.Value + iva_27_FacturaTextBox.Value + exentos_FacturaTextBox.Value + percep_FacturaTextBox.Value + retencion_FacturaTextBox.Value + otros_FacturaTextBox.Value;

            if (NumeroCuotas_numericUpDown1.Value > 0)
            {
                NUD_ValorCuota.Value = System.Math.Round(System.Math.Round(total_FacturaTextBox.Value,4) / System.Math.Round(NumeroCuotas_numericUpDown1.Value,4),0);
            }
        }

        private void DG_Productos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularProductos();
        }

        private void DG_Productos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalcularProductos();
        }

        private void percep_FacturaTextBox_ValueChanged(object sender, EventArgs e)
        {
            CalcularProductos();
        }

        private void clase_FacturacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcomodarNumeroComprobante();
        }

        private void FrmFacturaABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CerrarVentana)
            {
                e.Cancel = !CerrarVentana;
            }
            else
            {
                if (TipoComprobanteAnterior != "")
                {
                    Datos.Series.Desbloquear(TipoComprobanteAnterior);
                }
            }
        }

        private void AcomodarNumeroComprobante()
        {
            if (Txt_Id.Text == "")
            {
                try
                {
                    if (TipoComprobanteAnterior != "")
                    {
                        Datos.Series.Desbloquear(TipoComprobanteAnterior);
                    }

                    switch (_TipoFactura)
                    {
                        case 2:
                            switch (clase_FacturacomboBox.Text)
                            {
                                case "A":
                                    numero_Comprobante_FacturaTextBox.Text = Datos.Series.Bloquear("REMA").ToString("00000000");
                                    TipoComprobanteAnterior = "REMA";
                                    Datos.Series.Desbloquear("REMA");
                                    break;
                                case "B":
                                    numero_Comprobante_FacturaTextBox.Text = Datos.Series.Bloquear("REMA").ToString("00000000");
                                    TipoComprobanteAnterior = "REMA";
                                    Datos.Series.Desbloquear("REMA");
                                    break;
                            }
                            break;
                    }

                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message);
                }
            }
        }

        private void FrmFacturaABM_Load_1(object sender, EventArgs e)
        {
            if (Txt_Id.Text == "")
            {
                //ACA SE DEBE CARGAR EL NUMERO DE FACTURA, REMITO
                switch (_TipoFactura)
                {
                    case 1:
                        clase_FacturacomboBox.Items.Clear();
                        clase_FacturacomboBox.Items.Add("A");
                        clase_FacturacomboBox.Items.Add("B");
                        clase_FacturacomboBox.Items.Add("C");
                        clase_FacturacomboBox.Items.Add("M");
                        clase_FacturacomboBox.SelectedIndex = 0;
                        break;
                    case 2:
                        clase_FacturacomboBox.Items.Clear();
                        clase_FacturacomboBox.Items.Add("A");
                        clase_FacturacomboBox.Items.Add("B");

                        puesto_FacturaTextBox.Enabled = false;
                        numero_Comprobante_FacturaTextBox.Enabled = false;
                        clase_FacturacomboBox.SelectedIndex = 1;
                        break;
                }
            }

            if (_TipoFactura == 1)
            {
                DG_Garantes.Enabled = false;
                Btn_AgregarGarante.Enabled = false;
                Btn_QuitarGarante.Enabled = false;
                Coutas_groupBox.Enabled = false;
                NUD_ValorCuota.Enabled = false;
                Btn_Opciones.Enabled = false;
                Btn_Papel.Enabled = false;
                Btn_VistaPrevia.Enabled = false;
                Chk_Imprimir.Checked = false;
                Chk_Imprimir.Enabled = false;
            }
            else
            {
                clase_FacturacomboBox.Text = "X";
                clase_FacturacomboBox.Enabled = false;
            }

            if (_TipoFactura == 1)
            {
                Lbl_TipoTercero.Text = "Proveedor:";
            }
            else
            {
                Lbl_TipoTercero.Text = "Cliente:";
            }

            if (Txt_Id.Text == "")
            {
                Btn_BuscarTercero_Click(sender, e);
            }
            else
            {
                clase_FacturacomboBox.Enabled = false;
                puesto_FacturaTextBox.Enabled = false;
                numero_Comprobante_FacturaTextBox.Enabled = false;
            }

            ImprimirDocumento.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            foreach (System.Drawing.Printing.PaperSize itemPaperSize in ImprimirDocumento.PrinterSettings.PaperSizes)
            {
                if (itemPaperSize.PaperName == "A4")
                {
                    ImprimirDocumento.DefaultPageSettings.PaperSize = itemPaperSize;
                    pageSetupDialog1.PageSettings.PaperSize = itemPaperSize;
                }
            }
            printDialog1.Document = ImprimirDocumento;

            //if (Datos.Tercero.GetTercero(id_TerceroTextBox.Text, "").ListaTercero[0].Id_Tercero_IVA == 1)
            //{
            //    clase_FacturacomboBox.SelectedIndex = 0;
            //}
            //else
            //{
            //    clase_FacturacomboBox.SelectedIndex = 1;
            //}

            DG_Productos.Font = new Font(Config.NombreFont, Config.TamañoFont);
            DG_Productos.Columns["Clm_Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Productos.Columns["Clm_Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Productos.Columns["Clm_Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Productos.Columns["Clm_Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Productos.Columns["Clm_IVA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Productos.Columns["Clm_Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DG_Garantes.Font = new Font(Config.NombreFont, Config.TamañoFont);
            DG_Garantes.Columns["Clm_Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void Btn_AgregarGarante_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmS = new MDI.FrmTercero(3);
            FrmS.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                bool Existe = false;
                foreach (DataGridViewRow Fila in DG_Garantes.Rows)
                {
                    if (Fila.Tag.ToString() == MDI.FrmTercero.ValorReturn.ToString())
                    {
                        Existe = true;
                    }
                }

                if (!Existe)
                {
                    Datos.Tercero T = Datos.Tercero.GetTercero(MDI.FrmTercero.ValorReturn, "");
                    DG_Garantes.Rows.Add();

                    DG_Garantes.Rows[DG_Garantes.Rows.Count - 1].Tag = MDI.FrmTercero.ValorReturn;

                    DG_Garantes.Rows[DG_Garantes.Rows.Count - 1].Cells["Clm_Nombre"].Value = T.ListaTercero[0].Razon_Social_Tercero;
                }
            }
        }

        private void Btn_QuitarGarante_Click(object sender, EventArgs e)
        {
            if (DG_Garantes.SelectedRows.Count > 0)
            {
                DG_Garantes.Rows.RemoveAt(DG_Garantes.SelectedRows[0].Index);
            }
        }

        private bool ControlValores()
        {
            bool Retorno = true;
            if (numero_Comprobante_FacturaTextBox.Text.Length != 8)
            {
                ProvError.SetError(numero_Comprobante_FacturaTextBox, "Falta el puesto o número de la factura.");
                Retorno = false;
            }
            else
            {
                ProvError.SetError(numero_Comprobante_FacturaTextBox, "");
            }

            if (id_TerceroTextBox.Text == "")
            {
                ProvError.SetError(Txt_NombreTercero, "Falta elegir a un tercero.");
                Retorno = false;
            }
            else
            {
                ProvError.SetError(Txt_NombreTercero, "");
            }

            if (DG_Productos.Rows.Count > 25)
            {
                MessageBox.Show("La cantidad de artículos no puede superar los 25, por favor borrar algunos artículos y hacer otra factura para los mismos.", "Límite de artículos");
                Retorno = false;
            }

            return Retorno;
        }

        private void Btn_Opciones_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = ImprimirDocumento;
                printDialog1.ShowDialog();
                ImprimirDocumento.PrinterSettings = printDialog1.PrinterSettings;
                ImprimirDocumento.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Papel_Click(object sender, EventArgs e)
        {
            try
            {
                pageSetupDialog1.Document = ImprimirDocumento;
                pageSetupDialog1.ShowDialog();
                ImprimirDocumento.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_VistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ControlValores())
                {
                    return;
                }

                FrmVistaPrevia VP = new FrmVistaPrevia();
                VP.VistaPrevia.Document = ImprimirDocumento;
                VP.ShowDialog();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font Arial16 = new Font("Arial", 16, FontStyle.Bold);
            Font Arial12 = new Font("Arial", 12, FontStyle.Bold);
            Font Arial10 = new Font("Arial", 10);
            Font Arial8 = new Font("Arial", 8);
            int MitadPagina = e.MarginBounds.Width / 2;
            int Y_Reglon = 50;
            float TEMP = 0;
            string Texto = "";

            Datos.Empresa Emp = Datos.Empresa.GetEmpresaRelacional("1").ListaEmpresa[0];
            Datos.Tercero Ter = Datos.Tercero.GetTerceroRelacional(id_TerceroTextBox.Text, "", "").ListaTercero[0];

            Texto = Emp.Razon_Social_Empresa;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = Emp.Direccion_Empresa + " - " + Emp.Localidad.Nombre_Localidad + " - " + Datos.Provincia.GetProvincia(Emp.Localidad.Id_Provincia.ToString()).ListaProvincia[0].Nombre_Provincia;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "Tel.: " + Emp.Telefonos_Empresa;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Email: " + Emp.Email_Empresa;
            TEMP = 170;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "CUIT.: " + Emp.CUIT_Empresa;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "I.V.A.: " + Emp.Tercero_iva.Descripcion_Tercero_IVA; ;
            TEMP = 170;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "Ing. Brutos: " + Emp.Ingresos_Brutos_Empresa;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Inicio Act.: " + Emp.Inicio_Actividades_Empresa.ToString(Config.FechaMySQL2);
            TEMP = 170;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);


            Y_Reglon += 20;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);


            Y_Reglon += 30;
            Texto = "-" + clase_FacturacomboBox.Text + "-";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial16).Width / 2);
            e.Graphics.DrawString(Texto, Arial16, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            if (SegundaImpresion)
            {
                Texto = "REMITO ORIGINAL";
            }
            else
            {
                Texto = "REMITO DUPLICADO";
            }
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial12).Width;
            e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 24;
            Texto = "Nro. : " + puesto_FacturaTextBox.Text + "-" + numero_Comprobante_FacturaTextBox.Text;
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "*** DOCUMENTO NO VALIDO COMO FACTURA ***";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "Fecha : " + fecha_FacturaDateTimePicker.Value.ToString(Config.FechaMySQL2);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Esto no es una factura, sino un remito de su mercadería para su información y verificación.";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "Fecha Ven.: " + fecha_Vencimiento_FacturaDateTimePicker.Value.ToString(Config.FechaMySQL2);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Por favor, no realice ninguna compra ni pago contra este documento.";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 30;
            Texto = "R. Social : " + Ter.Razon_Social_Tercero;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Forma de pago : Cuenta corriente.";
            TEMP = 400;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = "Dirección : " + Ter.Direccion_Tercero;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "CUIT : " + Ter.CUIT_Tercero;
            TEMP = 400;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = "Localidad : " + Ter.Localidad.Nombre_Localidad + " (" + Ter.Localidad.Codigo_Postal_Localidad + ")";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Condición : " + Ter.Tercero_iva.Descripcion_Tercero_IVA;
            TEMP = 400;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = "Email : " + Ter.Email_Tercero;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Tel. : " + Ter.Telefonos_Tercero;
            TEMP = 400;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 30;
            Texto = "DETALLE DEL REMITO";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 10;

            //TITULOS DE LA TABLA DE ARTICULOS (CANTIDAD-CÓDIGO-DESCRIPCION-UNITARIO-IVA-TOTAL)

            for (int i = Y_Reglon + 15; i < 950; i += 15)
            {
                Texto = "|";
                TEMP = 20;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, i);

                TEMP = 98;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, i);

                TEMP = 178;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, i);

                TEMP = 530;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, i);

                TEMP = 622;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, i);

                TEMP = 672;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, i);
            }

            Y_Reglon += 15;
            Texto = "CANTIDAD";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "CÓDIGO";
            TEMP = 100;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "DESCRIPCIÓN";
            TEMP = 180;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "UNITARIO";
            TEMP = (MitadPagina * 2) - 180 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "IVA";
            TEMP = (MitadPagina * 2) - 130 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "TOTAL";
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            int TEMP_Y_Reglon = Y_Reglon;
            foreach (DataGridViewRow Fila in DG_Productos.Rows)
            {
                TEMP_Y_Reglon += 18;
                Texto = Fila.Cells["Clm_Cantidad"].Value.ToString();
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);

                Texto = Fila.Cells["Clm_Codigo"].Value.ToString();
                TEMP = 100;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);

                Texto = Fila.Cells["Clm_Descripcion"].Value.ToString();
                TEMP = 180;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);

                Texto = "$ " + Common.SumarIVA(Convert.ToDecimal(Fila.Cells["Clm_Precio"].Value), Interes_numericUpDown2.Value).ToString(Config.NumeroDecimales);
                TEMP = (MitadPagina * 2) - 180 - e.Graphics.MeasureString(Texto, Arial10).Width;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);

                Texto = Convert.ToDecimal(Fila.Cells["Clm_IVA"].Value).ToString(Config.NumeroDecimales);
                TEMP = (MitadPagina * 2) - 130 - e.Graphics.MeasureString(Texto, Arial10).Width;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);

                Texto = "$ " + Convert.ToDecimal(Common.SumarIVA(Common.SumarIVA(Convert.ToDecimal(Fila.Cells["Clm_Precio"].Value), Interes_numericUpDown2.Value), Convert.ToDecimal(Fila.Cells["Clm_IVA"].Value)) * Convert.ToInt32(Fila.Cells["Clm_Cantidad"].Value)).ToString(Config.NumeroDecimales);
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);

                Datos.Articulo art = Datos.Articulo.GetArticulo(Fila.Tag.ToString()).ListaArticulo[0];

                if (art.Numero_Chasis_Articulo != "")
                {
                    TEMP_Y_Reglon += 18;
                    Texto = "N° CHASIS: " + art.Numero_Chasis_Articulo;
                    TEMP = 180;
                    e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                }

                if (art.Numero_Motor_Articulo != "")
                {
                    TEMP_Y_Reglon += 18;
                    Texto = "N° Motor: " + art.Numero_Motor_Articulo;
                    TEMP = 180;
                    e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                }

                if (ObservacionestextBox.Text != "")
                {
                    if (ObservacionestextBox.Text.Length > 30 )
                    {
                        TEMP_Y_Reglon += 18;
                        Texto = "OBSERVACIONES: " + ObservacionestextBox.Text.Substring(0, 30);
                        TEMP = 180;
                        e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                        if (ObservacionestextBox.Text.Length > 70)
                        {
                            TEMP_Y_Reglon += 18;
                            Texto = ObservacionestextBox.Text.Substring(30, 40);
                            TEMP = 180;
                            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                            if (ObservacionestextBox.Text.Length > 110)
                            {
                                TEMP_Y_Reglon += 18;
                                Texto =  ObservacionestextBox.Text.Substring(70, 40);
                                TEMP = 180;
                                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                                if (ObservacionestextBox.Text.Length > 150)
                                {
                                    TEMP_Y_Reglon += 18;
                                    Texto =  ObservacionestextBox.Text.Substring(110, 40);
                                    TEMP = 180;
                                    e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);

                                    if (ObservacionestextBox.Text.Length > 190)
                                    {
                                        TEMP_Y_Reglon += 18;
                                        Texto = ObservacionestextBox.Text.Substring(150, 40);
                                        TEMP = 180;
                                        e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);

                                        TEMP_Y_Reglon += 18;
                                        Texto = ObservacionestextBox.Text.Substring(190);
                                        TEMP = 180;
                                        e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                                    }
                                    else
                                    {
                                        TEMP_Y_Reglon += 18;
                                        Texto = ObservacionestextBox.Text.Substring(150);
                                        TEMP = 180;
                                        e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                                    }
                                }
                                else
                                {
                                    TEMP_Y_Reglon += 18;
                                    Texto =  ObservacionestextBox.Text.Substring(110);
                                    TEMP = 180;
                                    e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                                }
                            }
                            else
                            {
                                TEMP_Y_Reglon += 18;
                                Texto =  ObservacionestextBox.Text.Substring(70);
                                TEMP = 180;
                                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                            }
                        }
                        else
                        {
                            TEMP_Y_Reglon += 18;
                            Texto =  ObservacionestextBox.Text.Substring(30);
                            TEMP = 180;
                            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                        }
                    }
                    else
                    {
                        TEMP_Y_Reglon += 18;
                        Texto = "OBSERVACIONES: " + ObservacionestextBox.Text;
                        TEMP = 180;
                        e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, TEMP_Y_Reglon);
                    }
                }
            }

            Y_Reglon += 540;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = "NETO GRAVADO :";
            TEMP = 500;
            if (Ter.Id_Tercero_IVA == 1)
            {
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);
            }

            Y_Reglon += 0;
            Texto = "$ " + neto_FacturaTextBox.Value.ToString(Config.NumeroDecimales);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            if (Ter.Id_Tercero_IVA == 1)
            {
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);
            }

            Y_Reglon += 0;
            Texto = "NÚMEROS DE CUOTAS :";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = NumeroCuotas_numericUpDown1.Value.ToString();
            TEMP = (MitadPagina * 2) - 500 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = "IVA (21%) :";
            TEMP = 500;
            if (Ter.Id_Tercero_IVA == 1)
            {
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);
            }

            Y_Reglon += 0;
            Texto = "$ " + iva_1_FacturaTextBox.Value.ToString(Config.NumeroDecimales);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            if (Ter.Id_Tercero_IVA == 1)
            {
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);
            }

            Y_Reglon += 0;
            Texto = "CUOTA :";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "$ " + NUD_ValorCuota.Value.ToString(Config.NumeroDecimales);
            TEMP = (MitadPagina * 2) - 500 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = "IVA (10,5%) :";
            TEMP = 500;
            if (Ter.Id_Tercero_IVA == 1)
            {
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);
            }

            Y_Reglon += 0;
            Texto = "$ " + iva_2_FacturaTextBox.Value.ToString(Config.NumeroDecimales);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            if (Ter.Id_Tercero_IVA == 1)
            {
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);
            }

            Y_Reglon += 20;
            Texto = "TOTAL :";
            TEMP = 500;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "$ " + total_FacturaTextBox.Value.ToString(Config.NumeroDecimales);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 10;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            if (SegundaImpresion)
            {
                e.HasMorePages = true;
                SegundaImpresion = false;
            }
            else
            {
                e.HasMorePages = false;
                SegundaImpresion = true;
            }
        }

        private void NUD_ValorCuota_ValueChanged(object sender, EventArgs e)
        {
            decimal Total = 0;
            decimal Neto = 0;
            decimal IVA21 = 0;
            decimal IVA105 = 0;
            decimal IVA27 = 0;
            decimal Exentos = 0;
            foreach (DataGridViewRow Fila in DG_Productos.Rows)
            {
                try
                {
                    decimal Cantidad = Convert.ToDecimal(Fila.Cells["Clm_Cantidad"].Value);
                    decimal Precio = Convert.ToDecimal(Fila.Cells["Clm_Precio"].Value);
                    decimal iva = Convert.ToDecimal(Fila.Cells["Clm_IVA"].Value);


                    if (iva == 10.5M)
                    {
                        IVA105 += (Precio / 100 * iva) * Cantidad;
                    }
                    if (iva == 21)
                    {
                        IVA21 += (Precio / 100 * iva) * Cantidad;
                    }
                    if (iva == 27)
                    {
                        IVA27 += (Precio / 100 * iva) * Cantidad;
                    }
                    if (iva == 0)
                    {
                        Exentos += Precio * Cantidad;
                    }
                    else
                    {
                        Neto += Precio * Cantidad;
                    }

                    Total += Common.SumarIVA(Precio, iva) * Cantidad;


                    //DG_Productos.Rows[Fila.Index].Cells["Clm_Total"].Value = (Cantidad * Common.SumarIVA(Precio, iva)).ToString(Config.NumeroDecimales);
                    //DG_Productos.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.White;
                }
                catch
                {
                    //DG_Productos.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.Red;
                }
            }

            total_FacturaTextBox.Value = NUD_ValorCuota.Value * NumeroCuotas_numericUpDown1.Value;

            decimal otros = percep_FacturaTextBox.Value + retencion_FacturaTextBox.Value + otros_FacturaTextBox.Value;

            decimal Neto2 = Total + otros;

            decimal diferencia = total_FacturaTextBox.Value - Neto2;

            if (diferencia == 0)
            {
                Interes_numericUpDown2.Value = 0;
            }
            else
            {
                Interes_numericUpDown2.Value = Convert.ToDecimal((total_FacturaTextBox.Value * 100 / Neto2 - 100).ToString("#,##0.0000"));
            }

            total_FacturaTextBox.Value = NUD_ValorCuota.Value * NumeroCuotas_numericUpDown1.Value;
        }

        private void Txt_NombreTercero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
