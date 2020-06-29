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
    public partial class FrmTerceroABM : Form
    {
        int _TipoTercero;
        public FrmTerceroABM(int TipoTercero)
        {
            InitializeComponent();
            AcomodarClienteProveedor(TipoTercero);
        }

        public FrmTerceroABM(string IdTercero,int TipoTercero)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Tercero T = Datos.Tercero.GetTerceroRelacional(IdTercero, TipoTercero.ToString(),"");

                id_TerceroNumericUpDown.Value = Convert.ToInt32(IdTercero);
                _TipoTercero = T.ListaTercero[0].Id_Tercero_Tipo;

                id_LocalidadNumericUpDown.Value = T.ListaTercero[0].Id_Localidad;
                Txt_NombreLocalidad.Text = T.ListaTercero[0].Localidad.Nombre_Localidad;

                Datos.Tercero_iva TI = Datos.Tercero_iva.GetTercero_iva("");

                foreach (Datos.Tercero_iva itemTercero_iva in TI.ListaTercero_iva)
                {
                    CboCondicion.Items.Add(itemTercero_iva.Id_Tercero_IVA.ToString() + "- " + itemTercero_iva.Descripcion_Tercero_IVA);
                }

                CboCondicion.SelectedIndex = T.ListaTercero[0].Id_Tercero_IVA - 1;

                razon_Social_TerceroTextBox.Text = T.ListaTercero[0].Razon_Social_Tercero;
                direccion_TerceroTextBox.Text = T.ListaTercero[0].Direccion_Tercero;
                fecha_Nacimiento_TerceroDateTimePicker.Value = T.ListaTercero[0].Fecha_Nacimiento_Tercero;
                cUIT_TerceroTextBox.Text = T.ListaTercero[0].CUIT_Tercero;
                telefonos_TerceroTextBox.Text = T.ListaTercero[0].Telefonos_Tercero;
                fax_TerceroTextBox.Text = T.ListaTercero[0].Fax_Tercero;
                dNI_TerceroNumericUpDown.Value = T.ListaTercero[0].DNI_Tercero;
                email_TerceroTextBox.Text = T.ListaTercero[0].Email_Tercero;
                fecha_Alta_TerceroDateTimePicker.Value = T.ListaTercero[0].Fecha_Alta_Tercero;
                fecha_Baja_TerceroDateTimePicker.Value = T.ListaTercero[0].Fecha_Baja_Tercero;
                aulado_TerceroCheckBox.Checked = T.ListaTercero[0].Anulado_Tercero;
                observaciones_TerceroTextBox.Text = T.ListaTercero[0].Observaciones_Tercero;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            AcomodarClienteProveedor(TipoTercero);
        }

        private void AcomodarClienteProveedor(int TipoTercero)
        {
            this.Text = "Nuevo/Modificar " + Datos.Tercero_tipo.GetTercero_tipo(TipoTercero.ToString()).ListaTercero_tipo[0].Descripcion_Tercero_Tipo;
            _TipoTercero = TipoTercero;
        }

        private void Btn_BuscarLocalidad_Click(object sender, EventArgs e)
        {
            MDI.FrmLocalidad FrmL = new MDI.FrmLocalidad();
            FrmL.ShowDialog();
            if (MDI.FrmLocalidad.ValorReturn != "")
            {
                id_LocalidadNumericUpDown.Value = Convert.ToInt32(MDI.FrmLocalidad.ValorReturn);
                Txt_NombreLocalidad.Text = Datos.Localidad.GetLocalidad(id_LocalidadNumericUpDown.Value.ToString()).ListaLocalidad[0].Nombre_Localidad;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlValores();

                Datos.Tercero T = new Datos.Tercero();
                     
                T.Id_Tercero = Convert.ToInt32(id_TerceroNumericUpDown.Value);
                T.Id_Tercero_Tipo = _TipoTercero;

                T.Id_Localidad = Convert.ToInt32(id_LocalidadNumericUpDown.Value);

                T.Id_Tercero_IVA = Convert.ToInt32(CboCondicion.SelectedItem.ToString().Split(Convert.ToChar("-"))[0]);

                T.Razon_Social_Tercero = razon_Social_TerceroTextBox.Text;
                T.Direccion_Tercero = direccion_TerceroTextBox.Text;
                T.Fecha_Nacimiento_Tercero = fecha_Nacimiento_TerceroDateTimePicker.Value;
                T.CUIT_Tercero = cUIT_TerceroTextBox.Text;
                T.Telefonos_Tercero = telefonos_TerceroTextBox.Text;
                T.Fax_Tercero = fax_TerceroTextBox.Text;
                T.DNI_Tercero = Convert.ToInt32(dNI_TerceroNumericUpDown.Value);
                T.Email_Tercero = email_TerceroTextBox.Text;
                T.Fecha_Alta_Tercero = fecha_Alta_TerceroDateTimePicker.Value;
                T.Fecha_Baja_Tercero = fecha_Baja_TerceroDateTimePicker.Value;
                T.Anulado_Tercero = aulado_TerceroCheckBox.Checked;
                T.Observaciones_Tercero = observaciones_TerceroTextBox.Text;

                if (id_TerceroNumericUpDown.Value == 0)
                {
                    Datos.Tercero.Add(T);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Tercero.Set(T);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void FrmTerceroABM_Load(object sender, EventArgs e)
        {
            if (CboCondicion.Items.Count == 0)
            {
                Datos.Tercero_iva TI = Datos.Tercero_iva.GetTercero_iva("");

                foreach (Datos.Tercero_iva itemTercero_iva in TI.ListaTercero_iva)
                {
                    CboCondicion.Items.Add(itemTercero_iva.Id_Tercero_IVA.ToString() + "- " + itemTercero_iva.Descripcion_Tercero_IVA);
                }

                if (_TipoTercero == 1)
                {
                    CboCondicion.SelectedIndex = 5;
                }
                else
                {
                    CboCondicion.SelectedIndex = 3;
                }
            }
        }

        private void ControlValores()
        {
            if (id_LocalidadNumericUpDown.Value == 0)
            {
                ProvError.SetError(Txt_NombreLocalidad, "Falta elegir a una localidad.");
            }
            else
            {
                ProvError.SetError(Txt_NombreLocalidad, "");
            }
        }

        private void cUIT_TerceroTextBox_Leave(object sender, EventArgs e)
        {
            if (cUIT_TerceroTextBox.Text.Split(Convert.ToChar("-")).Length == 3)
            {
                dNI_TerceroNumericUpDown.Value = Convert.ToInt32(cUIT_TerceroTextBox.Text.Split(Convert.ToChar("-"))[1]);
            }
        }
    }
}
