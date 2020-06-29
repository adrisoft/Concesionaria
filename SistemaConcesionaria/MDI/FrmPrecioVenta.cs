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
    public partial class FrmPrecioVenta : Form
    {
        public FrmPrecioVenta()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrecioVenta_Load(object sender, EventArgs e)
        {
            Datos.Categoria C = Datos.Categoria.GetCategoria("");

            Cbo_Categoria.Items.Add("- [TODOS]");
            Cbo_Categoria2.Items.Add("- [TODOS]");
            foreach (Datos.Categoria itemCategoria in C.ListaCategoria)
            {
                Cbo_Categoria.Items.Add(itemCategoria.Id_Categoria + "- " + itemCategoria.Descripcion_Categoria);
                Cbo_Categoria2.Items.Add(itemCategoria.Id_Categoria + "- " + itemCategoria.Descripcion_Categoria);
            }
            Cbo_Categoria.SelectedIndex = 0;
            Cbo_Categoria2.SelectedIndex = 0;

            Datos.Linea L = Datos.Linea.GetLinea("");

            CboLinea.Items.Add("- [TODOS]");
            CboLinea2.Items.Add("- [TODOS]");
            foreach (Datos.Linea itemLinea in L.ListaLinea)
            {
                CboLinea.Items.Add(itemLinea.Id_Linea + "- " + itemLinea.Descripcion_Linea);
                CboLinea2.Items.Add(itemLinea.Id_Linea + "- " + itemLinea.Descripcion_Linea);
            }
            CboLinea.SelectedIndex = 0;
            CboLinea2.SelectedIndex = 0;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Articulo A = Datos.Articulo.GetArticuloRelacional("", "", CboLinea.SelectedItem.ToString().Split(Convert.ToChar("-"))[0], Cbo_Categoria.SelectedItem.ToString().Split(Convert.ToChar("-"))[0], (id_TerceroNumericUpDown.Value != 0) ? id_TerceroNumericUpDown.Value.ToString() : "");

                Progreso.Maximum = A.ListaArticulo.Count + 1;
                Progreso.Value = 0;
                foreach (Datos.Articulo itemArticulo in A.ListaArticulo)
                {
                    itemArticulo.Precio_Venta_Articulo = Common.SumarIVA(itemArticulo.Precio_Venta_Articulo, PorcentajenumericUpDown1.Value);
                    Datos.Articulo.Set(itemArticulo);
                    Progreso.Value++;
                }
                Progreso.Value = Progreso.Maximum;
                MessageBox.Show("Se ha completado el proseso, fueron afectados " + A.ListaArticulo.Count.ToString() + " artículos.");
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
                groupBox1.Controls["id_TerceroNumericUpDown"].Text = MDI.FrmTercero.ValorReturn;
                groupBox1.Controls["TxtNombreTercero"].Text = Datos.Tercero.GetTercero(groupBox1.Controls["id_TerceroNumericUpDown"].Text, "").ListaTercero[0].Razon_Social_Tercero;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Controls["id_TerceroNumericUpDown"].Text = "";
            id_TerceroNumericUpDown.Value = 0;
            groupBox1.Controls["TxtNombreTercero"].Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmC = new MDI.FrmTercero(1);
            FrmC.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                groupBox2.Controls["numericUpDown1"].Text = MDI.FrmTercero.ValorReturn;
                groupBox2.Controls["textBox1"].Text = Datos.Tercero.GetTercero(groupBox2.Controls["numericUpDown1"].Text, "").ListaTercero[0].Razon_Social_Tercero;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Controls["numericUpDown1"].Text = "";
            numericUpDown1.Value = 0;
            groupBox2.Controls["textBox1"].Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Articulo A = Datos.Articulo.GetArticuloRelacional("", "", CboLinea2.SelectedItem.ToString().Split(Convert.ToChar("-"))[0], Cbo_Categoria2.SelectedItem.ToString().Split(Convert.ToChar("-"))[0], (numericUpDown1.Value != 0) ? numericUpDown1.Value.ToString() : "");

                progressBar1.Maximum = A.ListaArticulo.Count + 1;
                progressBar1.Value = 0;
                foreach (Datos.Articulo itemArticulo in A.ListaArticulo)
                {
                    itemArticulo.Precio_Costo_Articulo = Common.SumarIVA(itemArticulo.Precio_Costo_Articulo, numericUpDown2.Value);
                    Datos.Articulo.Set(itemArticulo);
                    progressBar1.Value++;
                }
                progressBar1.Value = progressBar1.Maximum;
                MessageBox.Show("Se ha completado el proseso, fueron afectados " + A.ListaArticulo.Count.ToString() + " artículos.");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
