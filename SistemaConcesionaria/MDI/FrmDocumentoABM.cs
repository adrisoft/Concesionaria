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
    public partial class FrmDocumentoABM : Form
    {
        bool SegundaImpresion = true;

        Datos.Factura_detalle FD_Global;
        Datos.Tercero TerceroGlobal;

        public FrmDocumentoABM()
        {
            InitializeComponent();
        }

        private void Btn_BuscarFactura_Click(object sender, EventArgs e)
        {
            MDI.FrmFactura FrmC = new MDI.FrmFactura(2);
            FrmC.ShowDialog();
            if (MDI.FrmFactura.ValorReturn != "")
            {
                id_FacturaTextBox.Text = MDI.FrmFactura.ValorReturn;
                TerceroGlobal = Datos.Factura.GetFacturaRelacional(id_FacturaTextBox.Text, "", "", "", "","").ListaFactura[0].Tercero;
                Txt_NombreTercero.Text = TerceroGlobal.Razon_Social_Tercero;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //e.Graphics.PageUnit = GraphicsUnit.Millimeter;
                Font Arial12 = new Font("Arial", 12);
                Font Arial10 = new Font("Arial", 10);
                Font Arial8 = new Font("Arial", 8);
                int MitadPagina = e.MarginBounds.Width / 2;
                int Y_Reglon = 50;
                float TEMP = 0;
                string Texto = "";

                Datos.Empresa Emp = Datos.Empresa.GetEmpresaRelacional("1").ListaEmpresa[0];
                int UltimoID = Datos.Documento.UltimoID();
                Datos.Factura_detalle FD = FD_Global;

                Texto = Emp.Razon_Social_Empresa;
                TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial12).Width / 2);
                e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = Emp.Direccion_Empresa + " - " + Emp.Localidad.Codigo_Postal_Localidad.ToString() + "    " + Emp.Localidad.Nombre_Localidad + " - " + Datos.Provincia.GetProvincia(Emp.Localidad.Id_Provincia.ToString()).ListaProvincia[0].Nombre_Provincia + " - " + Datos.Provincia.GetProvinciaRelacional(Emp.Localidad.Id_Provincia.ToString()).ListaProvincia[0].Pais.Nombre_Pais + " - TEL.: " + Emp.Telefonos_Empresa;
                TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);


                Y_Reglon += 12;
                Texto = "______________________________________________________________________________________________";
                TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);


                Y_Reglon += 28;
                Texto = "ENTREGA DE DOCUMENTACIÓN N° : " + UltimoID.ToString();
                TEMP = 22;//MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 3;
                Texto = "_______________________________";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = "FECHA : " + DateTime.Now.ToString(Config.FechaMySQL2);
                TEMP = (MitadPagina * 2) - 15 - e.Graphics.MeasureString(Texto, Arial10).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = "______";
                //TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "TÍTULO DE LA PROPIEDAD Y CÉDULA DE INDENTIFICACIÓN (EN TRIPLICADO)";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "CERTIFICADO DE FABRICACIÓN N° : " + FD.Articulo.Certificado_Fabricacion_Articulo + "    ADUANA N° : " + FD.Articulo.Numero_Aduana_Articulo + "    DOMINIO : " + Txt_Dominio.Text;
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                //Nombre y apellido del tercero
                //Y_Reglon += 20;
                Texto = "Nombre y Apellido : " + TerceroGlobal.Razon_Social_Tercero;
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "FORMULARIO 01 N° :";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                //Domiciolio
                //Y_Reglon += 20;
                Texto = "Domicilio : " + TerceroGlobal.Direccion_Tercero;
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "FACTURA N° :";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                //DNI
                //Y_Reglon += 20;
                Texto = "D.N.I. : " + TerceroGlobal.DNI_Tercero;
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Y_Reglon += 20;
                Texto = "DATOS DE LA UNIDAD";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 3;
                Texto = "___________________";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);


                Y_Reglon += 20;
                Texto = "MODELO : " + FD.Articulo.Descripcion_Articulo;
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);


                Y_Reglon += 20;
                Texto = "MOTOR N° : " + FD.Articulo.Numero_Motor_Articulo;
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "CHASIS N° : " + FD.Articulo.Numero_Chasis_Articulo;
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Y_Reglon += 20;
                Texto = "\tPOR LA PRESENTE RECIBO LA TOTALIDAD DE LA DOCUMENTACIÓN CORRESPONDIENTE AL MOTOVEHICULO ANTERIORMENTE MENCIONADO, COMPROMETIENDOME A SU PATENTAMIENTO DENTRO DE LOS 10 DIAS POSTERIORES A LA FECHA.\r\n \tA PARTIR DE LA FECHA, EL COMPRADOR SE HACE RESPONSABLE EXPRESAMENTE DE TODAS LAS RESPONSABILIDADES CIVILES Y PENALES QUE ACARREA EL USO DEL MOTOVEHICULO VENDIDO, SIENDO TODA LA TRAMITACIÓN CONFECCION Y COSTO DE TRANSFERENCIA Y/O PATENTAMIENTO Y/O INSCRIPCION EN LOS REGISTROS PERTINENTES A SU EXCLUSIVO CARGO. EXIMIENDO EXPRESAMENTE AL VENDEDOR DE TODA RESPONSABILIDAD, SE DEJA CONSTANCIA QUE EL MOTOVEHICULO VENDIDO, NO PUEDE CIRCULAR, SIN ESTAR DEBIDAMENTE PATENTADO E INSCRIPTO A NOMBRE DEL ADQUIRIENTE, SALVO LAS EXCEPCIONES PREVISTAS EN LAS NORMATIVAS VIGENTES ASIMISMO EL COMPRADOR ASUME LOS RIESGOS DE LA COSA Y TODAS CARGAS TRIBUTARIAS QUE LA MISMA GENERE.";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, new RectangleF(TEMP, Y_Reglon, (MitadPagina * 2) - 10, 150));


                Y_Reglon += 150;
                Texto = "RECIBI CONFORME : _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                TEMP = (MitadPagina * 2) - 10 - e.Graphics.MeasureString(Texto, Arial10).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "ACLARACIÓN : _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "DOCUMENTO : _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ";
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                //###############################################################################################################################################################

                Y_Reglon += 20;
                Texto = "_  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  ";
                TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

                //###############################################################################################################################################################

                Y_Reglon += 20;
                Texto = Emp.Razon_Social_Empresa;
                TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial12).Width / 2);
                e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = Emp.Direccion_Empresa + " - " + Emp.Localidad.Codigo_Postal_Localidad.ToString() + "    " + Emp.Localidad.Nombre_Localidad + " - " + Datos.Provincia.GetProvincia(Emp.Localidad.Id_Provincia.ToString()).ListaProvincia[0].Nombre_Provincia + " - " + Datos.Provincia.GetProvinciaRelacional(Emp.Localidad.Id_Provincia.ToString()).ListaProvincia[0].Pais.Nombre_Pais + " - TEL.: " + Emp.Telefonos_Empresa;
                TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);


                Y_Reglon += 12;
                Texto = "______________________________________________________________________________________________";
                TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);


                Y_Reglon += 28;
                Texto = "ENTREGA DE DOCUMENTACIÓN N° : " + UltimoID.ToString();
                TEMP = 22;//MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 3;
                Texto = "_______________________________";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = "FECHA : " + DateTime.Now.ToString(Config.FechaMySQL2);
                TEMP = (MitadPagina * 2) - 15 - e.Graphics.MeasureString(Texto, Arial10).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = "______";
                //TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "TÍTULO DE LA PROPIEDAD Y CÉDULA DE INDENTIFICACIÓN (EN TRIPLICADO)";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "CERTIFICADO DE FABRICACIÓN N° : " + FD.Articulo.Certificado_Fabricacion_Articulo + "    ADUANA N° : " + FD.Articulo.Numero_Aduana_Articulo + "    DOMINIO : " + Txt_Dominio.Text;
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                //Nombre y apellido del tercero
                //Y_Reglon += 20;
                Texto = "Nombre y Apellido : " + TerceroGlobal.Razon_Social_Tercero;
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "FORMULARIO 01 N° :";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                //Domiciolio
                //Y_Reglon += 20;
                Texto = "Domicilio : " + TerceroGlobal.Direccion_Tercero;
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "FACTURA N° :";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                //DNI
                //Y_Reglon += 20;
                Texto = "D.N.I. : " + TerceroGlobal.DNI_Tercero;
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Y_Reglon += 20;
                Texto = "DATOS DE LA UNIDAD";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 3;
                Texto = "___________________";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);


                Y_Reglon += 20;
                Texto = "MODELO : " + FD.Articulo.Descripcion_Articulo;
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);


                Y_Reglon += 20;
                Texto = "MOTOR N° : " + FD.Articulo.Numero_Motor_Articulo;
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "CHASIS N° : " + FD.Articulo.Numero_Chasis_Articulo;
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Y_Reglon += 20;
                Texto = "\tPOR LA PRESENTE RECIBO LA TOTALIDAD DE LA DOCUMENTACIÓN CORRESPONDIENTE AL MOTOVEHICULO ANTERIORMENTE MENCIONADO, COMPROMETIENDOME A SU PATENTAMIENTO DENTRO DE LOS 10 DIAS POSTERIORES A LA FECHA.\r\n \tA PARTIR DE LA FECHA, EL COMPRADOR SE HACE RESPONSABLE EXPRESAMENTE DE TODAS LAS RESPONSABILIDADES CIVILES Y PENALES QUE ACARREA EL USO DEL MOTOVEHICULO VENDIDO, SIENDO TODA LA TRAMITACIÓN CONFECCION Y COSTO DE TRANSFERENCIA Y/O PATENTAMIENTO Y/O INSCRIPCION EN LOS REGISTROS PERTINENTES A SU EXCLUSIVO CARGO. EXIMIENDO EXPRESAMENTE AL VENDEDOR DE TODA RESPONSABILIDAD, SE DEJA CONSTANCIA QUE EL MOTOVEHICULO VENDIDO, NO PUEDE CIRCULAR, SIN ESTAR DEBIDAMENTE PATENTADO E INSCRIPTO A NOMBRE DEL ADQUIRIENTE, SALVO LAS EXCEPCIONES PREVISTAS EN LAS NORMATIVAS VIGENTES ASIMISMO EL COMPRADOR ASUME LOS RIESGOS DE LA COSA Y TODAS CARGAS TRIBUTARIAS QUE LA MISMA GENERE.";
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, new RectangleF(TEMP, Y_Reglon, (MitadPagina * 2) - 10, 150));


                Y_Reglon += 150;
                Texto = "RECIBI CONFORME : _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                TEMP = (MitadPagina * 2) - 10 - e.Graphics.MeasureString(Texto, Arial10).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "ACLARACIÓN : _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "DOCUMENTO : _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ";
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                //if (SegundaImpresion)
                //{
                //    e.HasMorePages = true;
                //    SegundaImpresion = false;
                //}
                //else
                //{
                e.HasMorePages = false;
                //}
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ControlValores())
                {
                    throw new Exception("Falta elegir el remito valorizado.");
                }

                Datos.Documento D = new Datos.Documento();

                D.Id_Factura = Convert.ToInt32(id_FacturaTextBox.Text);
                D.Fecha_Entrega_Documento = FechaEntregaDateTimePicker.Value;
                D.Observaciones_Documento = ObservacionesTextBox.Text;
                D.Dominio_Documento = Txt_Dominio.Text;

                Datos.Documento.Add(D);

                Datos.Factura_detalle temp = Datos.Factura_detalle.GetFactura_detalleRelacional("", id_FacturaTextBox.Text);

                foreach (Datos.Factura_detalle itemFactura_detalle in temp.ListaFactura_detalle)
                {
                    FD_Global = itemFactura_detalle;
                    ImprimirDocumento.Print();
                }

                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private bool ControlValores()
        {
            if (id_FacturaTextBox.Text == "")
            {
                ProvError.SetError(Txt_NombreTercero, "Falta elegir a un remito valorizado.");
                return false;
            }
            else
            {
                ProvError.SetError(Txt_NombreTercero, "");
                return true;
            }
        }

        private void Btn_VistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ControlValores())
                {
                    throw new Exception("Falta elegir el remito valorizado.");
                }

                Datos.Factura_detalle temp = Datos.Factura_detalle.GetFactura_detalleRelacional("", id_FacturaTextBox.Text);

                foreach (Datos.Factura_detalle itemFactura_detalle in temp.ListaFactura_detalle)
                {
                    FD_Global = itemFactura_detalle;
                    FrmVistaPrevia VP = new FrmVistaPrevia();
                    VP.VistaPrevia.Document = ImprimirDocumento;
                    VP.ShowDialog();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void FrmDocumentoABM_Load(object sender, EventArgs e)
        {
            ObservacionesTextBox.Font = new Font(Config.NombreFont, Config.TamañoFont);

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

            Btn_BuscarFactura_Click(sender, e);
        }
    }
}
