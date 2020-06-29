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
    public partial class FrmSeries : Form
    {
        public FrmSeries()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Series S = Datos.Series.GetSeries("");

                S.ListaSeries[0].Numero = Convert.ToInt32(RemAnumericUpDown.Value);
                S.ListaSeries[0].Bloqueado = false;
                S.ListaSeries[1].Numero = Convert.ToInt32(RemBnumericUpDown.Value);
                S.ListaSeries[1].Bloqueado = false;
                S.ListaSeries[2].Numero = Convert.ToInt32(RecibosnumericUpDown.Value);
                S.ListaSeries[2].Bloqueado = false;

                Datos.Series.SetComillas(S.ListaSeries[0]);
                Datos.Series.SetComillas(S.ListaSeries[1]);
                Datos.Series.SetComillas(S.ListaSeries[2]);
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void FrmSeries_Load(object sender, EventArgs e)
        {
            try
            {
                Datos.Series S = Datos.Series.GetSeries("");

                RemAnumericUpDown.Value = S.ListaSeries[0].Numero;
                RemBnumericUpDown.Value = S.ListaSeries[1].Numero;
                RecibosnumericUpDown.Value = S.ListaSeries[2].Numero;
            }
            catch
            {
                RemAnumericUpDown.Value = 0;
                RemBnumericUpDown.Value = 0;
                RecibosnumericUpDown.Value = 0;
            }
        }
    }
}
