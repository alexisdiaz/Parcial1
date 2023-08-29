using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        String[][] TiposConversores = new string[][]
       {
        new string[] {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectareas" }, //Areas
       };


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;
            de = CboDeConversor.SelectedIndex;
            a = CboAConversor.SelectedIndex;

            cantidad = double.Parse(TxtCantidadConversor.Text);

            double[][] Superficie = {
            new double []{0.092903, 0.7, 0.84, 1, 438, 7000, 10000,},//superficies
            };

            respuesta = Superficie[CboxTipo.SelectedIndex][de] / Superficie[CboxTipo.SelectedIndex][a] * cantidad;

            LblRespuesta.Text = "Respuesta: " + Math.Round(respuesta, 2);

        }

        private void CboxTipo_TextChanged(object sender, EventArgs e)
        {
            CboDeConversor.Items.Clear();
            CboDeConversor.Items.AddRange(TiposConversores[CboxTipo.SelectedIndex]);

            CboAConversor.Items.Clear();
            CboAConversor.Items.AddRange(TiposConversores[CboxTipo.SelectedIndex]);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
