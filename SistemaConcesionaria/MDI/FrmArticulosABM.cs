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
    public partial class FrmArticulosABM : Form
    {
        bool CerrarVentana = false;

        public FrmArticulosABM()
        {
            InitializeComponent();
        }

        public FrmArticulosABM(string IdArticulo)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Articulo A = Datos.Articulo.GetArticuloRelacional(IdArticulo,"","","","");

                id_ArticuloNumericUpDown.Value = A.ListaArticulo[0].Id_Articulo;

                id_TerceroNumericUpDown.Value = A.ListaArticulo[0].Id_Tercero;
                TxtNombreTercero.Text = A.ListaArticulo[0].Tercero.Razon_Social_Tercero;

                id_LineaNumericUpDown.Value = A.ListaArticulo[0].Id_Linea;
                TxtNombreLinea.Text = A.ListaArticulo[0].Linea.Descripcion_Linea;

                id_CategoriaNumericUpDown.Value = A.ListaArticulo[0].Id_Categoria;
                TxtNombreCategoria.Text = A.ListaArticulo[0].Categoria.Descripcion_Categoria;

                codigoTextBox.Text = A.ListaArticulo[0].Codigo_Articulo;
                numero_ChasisTextBox.Text = A.ListaArticulo[0].Numero_Chasis_Articulo;
                numero_MotorTextBox.Text = A.ListaArticulo[0].Numero_Motor_Articulo;
                certificado_Fabricacion_ArticuloTextBox.Text = A.ListaArticulo[0].Certificado_Fabricacion_Articulo;
                numero_Aduana_ArticulotextBox1.Text = A.ListaArticulo[0].Numero_Aduana_Articulo;
                descripcionTextBox.Text = A.ListaArticulo[0].Descripcion_Articulo;
                anuladoCheckBox.Checked = A.ListaArticulo[0].Anulado_Articulo;
                stock_MinimoNumericUpDown.Value = A.ListaArticulo[0].Stock_Minimo_Articulo;
                stockNumericUpDown.Value = A.ListaArticulo[0].Stock_Articulo;
                pesoNumericUpDown.Value = A.ListaArticulo[0].Peso_Articulo;
                dia_CompraDateTimePicker.Value = A.ListaArticulo[0].Dia_Compra_Articulo;
                dia_VentaDateTimePicker.Value = A.ListaArticulo[0].Dia_Venta_Articulo;
                precio_CostoNumericUpDown.Value = A.ListaArticulo[0].Precio_Costo_Articulo;
                precio_VentaNumericUpDown.Value = A.ListaArticulo[0].Precio_Venta_Articulo;
                iVANumericUpDown.Value = A.ListaArticulo[0].IVA_Articulo;
                garantiaNumericUpDown.Value = A.ListaArticulo[0].Garantia_Articulo;
                observacionesTextBox.Text = A.ListaArticulo[0].Observaciones_Articulo;

                dominiotextBox1.Text = A.ListaArticulo[0].Dominio_Articulo;
                ExTitulartextBox2.Text = A.ListaArticulo[0].ExTitular;
                CuadrotextBox3.Text = A.ListaArticulo[0].Cuadro;
                ModelotextBox4.Text = A.ListaArticulo[0].Modelo;
                ColortextBox5.Text = A.ListaArticulo[0].Color;
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
                ControlValores();

                Datos.Articulo A = new Datos.Articulo();

                A.Id_Articulo = Convert.ToInt32(id_ArticuloNumericUpDown.Value);

                A.Id_Tercero = Convert.ToInt32(id_TerceroNumericUpDown.Value);
                A.Id_Linea =  Convert.ToInt32(id_LineaNumericUpDown.Value);
                A.Id_Categoria = Convert.ToInt32(id_CategoriaNumericUpDown.Value);
                A.Codigo_Articulo = codigoTextBox.Text;
                A.Numero_Chasis_Articulo = numero_ChasisTextBox.Text;
                A.Numero_Motor_Articulo = numero_MotorTextBox.Text;
                A.Certificado_Fabricacion_Articulo = certificado_Fabricacion_ArticuloTextBox.Text;
                A.Numero_Aduana_Articulo = numero_Aduana_ArticulotextBox1.Text;
                A.Descripcion_Articulo = descripcionTextBox.Text;
                A.Anulado_Articulo = anuladoCheckBox.Checked;
                A.Stock_Minimo_Articulo = Convert.ToInt32(stock_MinimoNumericUpDown.Value);
                A.Stock_Articulo = Convert.ToInt32(stockNumericUpDown.Value);
                A.Peso_Articulo = pesoNumericUpDown.Value;
                A.Dia_Compra_Articulo = dia_CompraDateTimePicker.Value;
                A.Dia_Venta_Articulo = dia_VentaDateTimePicker.Value;
                A.Precio_Costo_Articulo = precio_CostoNumericUpDown.Value;
                A.Precio_Venta_Articulo = precio_VentaNumericUpDown.Value;
                A.IVA_Articulo = iVANumericUpDown.Value;
                A.Garantia_Articulo = Convert.ToInt32(garantiaNumericUpDown.Value);
                A.Observaciones_Articulo = observacionesTextBox.Text;
                A.Dominio_Articulo = dominiotextBox1.Text;
                A.ExTitular = ExTitulartextBox2.Text;
                A.Cuadro = CuadrotextBox3.Text;
                A.Modelo = ModelotextBox4.Text;
                A.Color = ColortextBox5.Text;

                if (id_ArticuloNumericUpDown.Value == 0)
                {
                    Datos.Articulo.Add(A);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Articulo.Set(A);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                CerrarVentana = true;
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_BuscarCategoria_Click(object sender, EventArgs e)
        {
            MDI.FrmCategoria FrmC = new MDI.FrmCategoria();
            FrmC.ShowDialog();
            if (MDI.FrmCategoria.ValorReturn != "")
            {
                id_CategoriaNumericUpDown.Value = Convert.ToInt32(MDI.FrmCategoria.ValorReturn);
                TxtNombreCategoria.Text = Datos.Categoria.GetCategoria(id_CategoriaNumericUpDown.Value.ToString()).ListaCategoria[0].Descripcion_Categoria;
            }
        }

        private void Btn_BuscarLinea_Click(object sender, EventArgs e)
        {
            MDI.FrmLinea FrmC = new MDI.FrmLinea();
            FrmC.ShowDialog();
            if (MDI.FrmLinea.ValorReturn != "")
            {
                id_LineaNumericUpDown.Value = Convert.ToInt32(MDI.FrmLinea.ValorReturn);
                TxtNombreLinea.Text = Datos.Linea.GetLinea(id_LineaNumericUpDown.Value.ToString()).ListaLinea[0].Descripcion_Linea;
            }
        }

        private void Btn_BuscarTercero_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmC = new MDI.FrmTercero(1);
            FrmC.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                id_TerceroNumericUpDown.Value = Convert.ToInt32(MDI.FrmTercero.ValorReturn);
                TxtNombreTercero.Text = Datos.Tercero.GetTercero(id_TerceroNumericUpDown.Value.ToString(),"").ListaTercero[0].Razon_Social_Tercero;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana = true;
            Close();
        }

        private void ControlValores()
        {
            if (id_CategoriaNumericUpDown.Value == 0)
            {
                ProvError.SetError(TxtNombreCategoria, "Falta elegir a una categoría.");
            }
            else
            {
                ProvError.SetError(TxtNombreCategoria, "");
            }

            if (id_LineaNumericUpDown.Value == 0)
            {
                ProvError.SetError(TxtNombreLinea, "Falta elegir a una linea.");
            }
            else
            {
                ProvError.SetError(TxtNombreLinea, "");
            }

            if (id_TerceroNumericUpDown.Value == 0)
            {
                ProvError.SetError(TxtNombreTercero, "Falta elegir a un tercero.");
            }
            else
            {
                ProvError.SetError(TxtNombreTercero, "");
            }
        }

        private void FrmArticulosABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CerrarVentana;
        }
    }
}
