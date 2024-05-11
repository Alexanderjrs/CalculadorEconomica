using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class Tasa_de_Interes : Form
    {
        public Tasa_de_Interes()
        {
            InitializeComponent();
        }

        private void capital_TextChanged(object sender, EventArgs e)
        {

        }

        private void interes_TextChanged(object sender, EventArgs e)
        {

        }

        private void tiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TasaInteres();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            capital.Clear();
            valorF.Clear();
            tiempo.Clear();
        }

        private void TasaInteres()
        {
            double Capital = double.Parse(capital.Text);
            double Valor = double.Parse(valorF.Text);
            double Tiempo = double.Parse(tiempo.Text);

            if (Capital > Valor)
            {
                MessageBox.Show("El valor final tiene que ser mayor al capital inicial");

            }
            else
            {
                double rate = Valor - Capital;
                double rate1 = (rate / (Capital * Tiempo))*100;
                resultado.Text = " La Tasa de interés es: " + rate1+"%";
            }
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Tasa_de_Interes_Load(object sender, EventArgs e)
        {

        }
    }
}
