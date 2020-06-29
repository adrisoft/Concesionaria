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
    public partial class FrmLineaABM : Form
    {
        public FrmLineaABM()
        {
            InitializeComponent();
        }

        public FrmLineaABM(string IdLinea)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Linea L = Datos.Linea.GetLinea(IdLinea);

                Txt_Id.Text = IdLinea;
                nombreTextBox.Text = L.ListaLinea[0].Descripcion_Linea;
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

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Linea L = new Datos.Linea();
                L.Id_Linea = (Txt_Id.Text == "") ? 0 : Convert.ToInt32(Txt_Id.Text);
                L.Descripcion_Linea = nombreTextBox.Text;

                if (Txt_Id.Text == "")
                {
                    Datos.Linea.Add(L);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Linea.Set(L);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
