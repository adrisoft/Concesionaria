using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concesionarias
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmAcercaDe Frm = new MDI.FrmAcercaDe();
            Frm.ShowDialog();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmArticulos Frm = new MDI.FrmArticulos();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmPais Frm = new MDI.FrmPais();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmCategoria Frm = new MDI.FrmCategoria();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmLinea Frm = new MDI.FrmLinea();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmProvincia Frm = new MDI.FrmProvincia();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmLocalidad Frm = new MDI.FrmLocalidad();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero Frm = new MDI.FrmTercero(1);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero Frm = new MDI.FrmTercero(2);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmFacturaABM Frm = new MDI.FrmFacturaABM(1);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmFactura Frm = new MDI.FrmFactura(1);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void saldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmSaldos Frm = new MDI.FrmSaldos(1);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void saldosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MDI.FrmSaldos Frm = new MDI.FrmSaldos(2);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void resumenDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmResumenCuenta Frm = new MDI.FrmResumenCuenta(true);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void resumenDeCuentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MDI.FrmResumenCuenta Frm = new MDI.FrmResumenCuenta(false);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void nuevaFacturaRemitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmFacturaABM Frm = new MDI.FrmFacturaABM(2);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void facturasRemitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmFactura Frm = new MDI.FrmFactura(2);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void cuotasPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmCuotasPorMes Frm = new MDI.FrmCuotasPorMes();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmCaja Frm = new MDI.FrmCaja();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void nuevoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmOrdenPagoABM Frm = new MDI.FrmOrdenPagoABM(2);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmFactura Frm = new MDI.FrmFactura(3);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void carteraDeChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmCarteraCheques Frm = new MDI.FrmCarteraCheques();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void garantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero Frm = new MDI.FrmTercero(3);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void listaDeDocumentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmDocumento Frm = new MDI.FrmDocumento();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void datosDeLaEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MDI.FrmEmpresaABM Frm = new MDI.FrmEmpresaABM();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void modificarPrecioDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmPrecioVenta Frm = new MDI.FrmPrecioVenta();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void seriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmSeries Frm = new MDI.FrmSeries();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void documentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("manual.pdf");
        }

        private void organizarIconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form itemForm in this.MdiChildren)
            {
                itemForm.Close();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                Datos.Empresa emp = Datos.Empresa.GetEmpresa("").ListaEmpresa[0];
                toolStripStatusLabel1.Text = emp.Razon_Social_Empresa;
            }
            catch
            {
                toolStripStatusLabel1.Text = "";
            }

            Lbl_Version.Text = "(Versión: " + Application.ProductVersion + ")";

            MenuPrincipal.Font = new Font(Config.NombreFont, Config.TamañoFont);
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            catch
            {

            }
        }

        private void imprimirNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmDocumentoABM Frm = new MDI.FrmDocumentoABM();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void volumenesDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmVolVentas Frm = new MDI.FrmVolVentas();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void backupBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmBackup Frm = new MDI.FrmBackup();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void link_Pagina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.adriansosa.com.ar");
        }

        private void contarLaCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.FrmContarCaja Frm = new MDI.FrmContarCaja();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MDI.FrmArticulos Frm = new MDI.FrmArticulos();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero Frm = new MDI.FrmTercero(2);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MDI.FrmFacturaABM Frm = new MDI.FrmFacturaABM(1);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MDI.FrmFacturaABM Frm = new MDI.FrmFacturaABM(2);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MDI.FrmCuotasPorMes Frm = new MDI.FrmCuotasPorMes();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MDI.FrmCaja Frm = new MDI.FrmCaja();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            MDI.FrmOrdenPagoABM Frm = new MDI.FrmOrdenPagoABM(2);
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MDI.FrmDocumentoABM Frm = new MDI.FrmDocumentoABM();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void foroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.adriansosa.com.ar/");
        }
    }
}
