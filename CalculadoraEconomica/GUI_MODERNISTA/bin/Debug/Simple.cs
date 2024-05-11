using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Calculadora
{
    public partial class Simple : Form
    {
        public Simple()
        {
            InitializeComponent();
        }

        private void Simple_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void CalCapital()
        {
            double Tiempo = double.Parse(tiempo.Text);
            double Monto  = double.Parse(monto.Text);           
            double Interes = double.Parse(interes.Text) / 100;

            
            double principal = Math.Round(Monto / (1 + (Interes * Tiempo)), 1);         
            label5.Text = " El monto final es: " + principal;
        }
        private void CalTiempo()
        {
            double Capital = double.Parse(capital.Text);
            double Monto = double.Parse(monto.Text);                  
            double Interes = double.Parse(interes.Text) / 100;

            

            double time = Math.Round((Monto - Capital) / (Capital * Interes), 1);

            label5.Text = " El tiempo necesario es: " + time;

        }
        private void CalInteres()
        {
            double Capital = double.Parse(capital.Text);
            double Monto = double.Parse(monto.Text);
            double Tiempo = double.Parse(tiempo.Text);

            double rate = Math.Round((Monto - Capital) / (Capital * Tiempo) * 100, 1);
            
            label5.Text = " El interés es: " + rate;
        }
        private void Calinteréssimple()
        {
            double Capital = double.Parse(capital.Text);
            double porcentaje = double.Parse(interes.Text)/100;
            double Tiempo = double.Parse(tiempo.Text);


            double simpleInterest = Math.Round(Capital * porcentaje * Tiempo, 1);
            double amount = Math.Round(Capital + simpleInterest, 1);
            label5.Text = " El interés simple es: " + simpleInterest + " El monto final es: " + amount;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem != null)
                {
                    if (comboBox1.SelectedItem.ToString() == "Calcular tiempo")
                    {
                        capital.Visible = true;
                        interes.Visible = true;
                        monto.Visible = true;
                        label1.Visible = true;
                        label.Visible = false;
                        label3.Visible = true;
                        tiempo.Visible = false;
                        label4.Visible = true;

                    }
                    else if (comboBox1.SelectedItem.ToString() == "Calcular principal")
                    {
                        capital.Visible = false;
                        interes.Visible = true;
                        monto.Visible = true;
                        label1.Visible = false;
                        label.Visible = true;
                        label3.Visible = true;
                        tiempo.Visible = true;
                        label4.Visible = true;


                    }
                    else if (comboBox1.SelectedItem.ToString() == "Calcular tasa de interés")
                    {
                        capital.Visible = true;
                        interes.Visible = false;
                        monto.Visible = true;
                        label1.Visible = true;
                        label.Visible = true;
                        label3.Visible = false;
                        tiempo.Visible = true;
                        label4.Visible = true;



                    }
                    else if (comboBox1.SelectedItem.ToString() == "Calcular interés simple")
                    {
                        capital.Visible = true;
                        interes.Visible = true;
                        monto.Visible = false;
                        label1.Visible = true;
                        label.Visible = true;
                        label3.Visible = true;
                        tiempo.Visible = true;
                        label4.Visible = false;



                    }

                }
                else
                {

                    MessageBox.Show("Por favor, selecciona una opción en el ComboBox.");
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Calcular tiempo")
                {
                    CalTiempo();
                    
                }
                else if (comboBox1.SelectedItem.ToString() == "Calcular principal")
                {
                    CalCapital();
                }
                else if (comboBox1.SelectedItem.ToString() == "Calcular tasa de interés")
                {
                    CalInteres();
                }
                else if (comboBox1.SelectedItem.ToString() == "Calcular interés simple")
                {
                    Calinteréssimple();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tiempo.Clear();
            interes.Clear();           
            capital.Clear();
            monto.Clear();
        }

        private void tiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void monto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
