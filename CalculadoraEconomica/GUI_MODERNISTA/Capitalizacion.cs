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
    public partial class Capitalizacion : Form
    {
        public Capitalizacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Valor Presente")
                {
                    
                    CalculatePresentValue();

                }
                else if (comboBox1.SelectedItem.ToString() == "Valor Futuro")
                {
                    CalculateFutureValue();


                }
                else if (comboBox1.SelectedItem.ToString() == "Interes")
                {
                    CalculateInterestRate();
                }
                else if (comboBox1.SelectedItem.ToString() == "Periodos")
                {

                    CalculatePeriods();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una opción en el ComboBox.");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
        private void CalculateFutureValue()
        {
            double ValorP = double.Parse(valorP.Text);
            double interes = double.Parse(Interes.Text)/100;
            int periodos = int.Parse(Periodos.Text);

            
            double futureValue = ValorP * Math.Pow(1 + interes, periodos);
            resultado.Text = ("El valor futuro de la inversión es: " + Math.Round(futureValue));
        }

        private void CalculatePresentValue()
        {
            double ValorF = double.Parse(ValorFuturo.Text);
            double interes = double.Parse(Interes.Text) / 100;
            int periodos = int.Parse(Periodos.Text);

            double presentValue = ValorF / Math.Pow(1 + interes, periodos);
            resultado.Text = ("El valor presente de la inversión es: " + Math.Round(presentValue));
        }

        private void CalculateInterestRate()
        {
            double ValorF = double.Parse(ValorFuturo.Text);
            double ValorP = double.Parse(valorP.Text);
            int periodos = int.Parse(Periodos.Text);


            double interestRate = Math.Pow(ValorF / ValorP, 1.0 / periodos) - 1;
            interestRate *= 100; // Convertir la tasa de interés a porcentaje

            resultado.Text = ("La tasa de interés por período es: " + Math.Round(interestRate)+"%");
        }

        private void CalculatePeriods()
        {
            double ValorF = double.Parse(ValorFuturo.Text);
            double ValorP = double.Parse(valorP.Text);
            double interes = double.Parse(Interes.Text) / 100;


            int periods = (int)Math.Ceiling(Math.Log(ValorF / ValorP) / Math.Log(1 + interes));
            resultado.Text = ("El número de períodos de capitalización es: " + periods);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                  
                if (comboBox1.SelectedItem != null)
                {
                    if (comboBox1.SelectedItem.ToString() == "Valor Presente")
                    {
                        futurol.Visible = true;
                        presentel.Visible = false;
                        interesl.Visible = true;
                        periodosl.Visible = true;


                        valorP.Visible = false;
                        Interes.Visible = true;
                        Periodos.Visible = true;
                        ValorFuturo.Visible = true;

                }
                    else if (comboBox1.SelectedItem.ToString() == "Valor Futuro")
                    {
                        futurol.Visible = false;
                        presentel.Visible = true;
                        interesl.Visible = true;
                        periodosl.Visible = true;


                        valorP.Visible = true;
                        Interes.Visible = true;
                        Periodos.Visible = true;
                        ValorFuturo.Visible = false;


                    }
                    else if (comboBox1.SelectedItem.ToString() == "Interes")
                    {
                        valorP.Visible = true;
                        Interes.Visible = false;
                        Periodos.Visible = true;
                        ValorFuturo.Visible = true;

                        futurol.Visible = true;
                        presentel.Visible = true;
                        interesl.Visible = false;
                        periodosl.Visible = true;

                }
                    else if (comboBox1.SelectedItem.ToString() == "Periodos")
                    {
                        valorP.Visible = true;
                        Interes.Visible = true;
                        Periodos.Visible = false;
                        ValorFuturo.Visible = true;

                        futurol.Visible = true;
                        presentel.Visible = true;
                        interesl.Visible = true;
                        periodosl.Visible = false;
                }

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una opción en el ComboBox.");
                }      
        }

        private void Capitalizacion_Load(object sender, EventArgs e)
        {
            
            ValorFuturo.Visible = false;
            futurol.Visible=false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
