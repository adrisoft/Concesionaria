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
    public partial class FrmCategoriaABM : Form
    {
        public FrmCategoriaABM()
        {
            InitializeComponent();
        }

        public FrmCategoriaABM(string IdCategoria)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Categoria C = Datos.Categoria.GetCategoria(IdCategoria);

                Txt_Id.Text = IdCategoria;

                nombreTextBox.Text = C.ListaCategoria[0].Descripcion_Categoria;
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
                Datos.Categoria C = new Datos.Categoria();
                C.Id_Categoria = (Txt_Id.Text == "") ? 0 : Convert.ToInt32(Txt_Id.Text);
                C.Descripcion_Categoria = nombreTextBox.Text;

                if (Txt_Id.Text == "")
                {
                    Datos.Categoria.Add(C);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Categoria.Set(C);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
