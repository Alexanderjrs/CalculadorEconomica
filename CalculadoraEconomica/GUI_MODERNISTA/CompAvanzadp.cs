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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class CompAvanzadp : Form
    {
        public CompAvanzadp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Valor final a interés compuesto")
                {
                    if (comboBox2.SelectedItem != null)
                    {
                        string selectedItem = comboBox2.SelectedItem.ToString();

                        switch (selectedItem)
                        {
                            case "Diario":
                                calcularDiario();
                                break;
                            case "Mensual":
                                calcularMensual();
                                break;
                            case "Trimestral":
                                calcularTrimestral();
                                break;
                            case "Cuatrimestral":
                                calcularCuatrimestral();
                                break;
                            case "Semestral":
                                calcularSemestral();
                                break;
                            case "Anual":
                                calcularAnual();
                                break;

                            default:

                                break;
                        }

                    }
                    else
                    {
                        
                        MessageBox.Show("Por favor, selecciona una opción en el ComboBox.");
                    }
                }
                
                else if (comboBox1.SelectedItem.ToString() == "Deposito")
                {
                    calcularDep();

                }
                else if (comboBox1.SelectedItem.ToString() == "Monto con periodo fraccionario")
                {
                    fraccionario();
                }
                else if (comboBox1.SelectedItem.ToString() == "Monto cuando la tasa de interés se cambia")
                {
                    interescambia();
                }
                else if (comboBox1.SelectedItem.ToString() == "Depósito adicional o retiro realizado")
                {
                    DepositoAdicional();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dias.Clear();
            Tiempo.Clear();
            i.Clear();
            C.Clear();
            Meses.Clear();
            semestral.Text = ("");
        }

        private void Tiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void i_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Valor final a interés compuesto")
                {
                    comboBox2.Visible = true;
                    TC.Visible = true;
                    label6.Visible = false;
                    Dias.Visible = false;
                    label1.Visible = false;
                    Meses.Visible = false;
                    Tiempo.Visible = true;
                    label4.Visible = true;
                    incremento.Visible = false;
                    incrementointeres.Visible = false;
                    Retiro.Visible = false; 
                    Retirol.Visible = false;    
                }
                else if (comboBox1.SelectedItem.ToString() == "Deposito")
                {
                    TC.Visible = false;
                    comboBox2.Visible = false;
                    label6.Visible = false;
                    Dias.Visible = false;
                    label1.Visible = false;
                    Meses.Visible = false;
                    Tiempo.Visible = true;
                    label4.Visible = true;
                    incremento.Visible = false;
                    incrementointeres.Visible = false;
                    Retiro.Visible = false;
                    Retirol.Visible = false;
                }
                else if (comboBox1.SelectedItem.ToString() == "Monto con periodo fraccionario")
                {
                    TC.Visible = false;
                    Dias.Visible = true;
                    label6.Visible = true;
                    label1.Visible = true;
                    Meses.Visible = true;
                    comboBox2.Visible = false;
                    Tiempo.Visible = false;
                    label4.Visible = false;
                    incremento.Visible = false;
                    incrementointeres.Visible = false;
                    Retiro.Visible = false;
                    Retirol.Visible = false;
                }
                else if (comboBox1.SelectedItem.ToString() == "Monto cuando la tasa de interés se cambia")
                {
                    TC.Visible = false;
                    comboBox2.Visible = false;
                    label6.Visible = false;
                    Dias.Visible = false;
                    label1.Visible = false;
                    Meses.Visible = false;
                    Tiempo.Visible = true;
                    label4.Visible = true;
                    incremento.Visible = true;
                    incrementointeres.Visible = true;
                    Retiro.Visible = false;
                    Retirol.Visible = false;
                }
                else if (comboBox1.SelectedItem.ToString() == "Depósito adicional o retiro realizado")
                {
                    TC.Visible = false;
                    label6.Visible = false;
                    Dias.Visible = false;
                    label1.Visible = false;
                    Meses.Visible = false;
                    Tiempo.Visible = true;
                    label4.Visible = true;
                    comboBox2.Visible = false;
                    incremento.Visible = false;
                    incrementointeres.Visible = false;
                    Retiro.Visible = true;
                    Retirol.Visible = true;
                }

            }

        }
        //------------------------------diario,mensual,trimestra....
        private void calcularMensual()
        {
            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100;
            double tiempo = double.Parse(Tiempo.Text);
            
            interes = interes / 12;
            double calculo1 = capital * Math.Pow(1 + interes, tiempo);
            semestral.Text = " El Resultado es: " + Math.Round(calculo1).ToString("C2");
        }
        private void calcularAnual()
        {
            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100;
            double tiempo = double.Parse(Tiempo.Text);
        
            double calculo1 = capital * Math.Pow(1 + interes, tiempo);
            semestral.Text = " El Resultado es: " + Math.Round(calculo1).ToString("C2");
        }
        private void calcularTrimestral()
        {
            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100;
            double tiempo = double.Parse(Tiempo.Text);

            tiempo = tiempo * 4;
            interes = interes / 4;        
            double calculo1 = capital * Math.Pow(1 + interes, tiempo);
            semestral.Text = " El Resultado es: " + Math.Round(calculo1).ToString("C2");


            
        }
        private void calcularSemestral()
        {
            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100;
            double tiempo = double.Parse(Tiempo.Text);

            tiempo = tiempo * 2;
            interes = interes / 2;
            double calculo1 = capital * Math.Pow(1 + interes, tiempo);
            semestral.Text = " El Resultado es: " + Math.Round(calculo1).ToString("C2");


        }
        private void calcularCuatrimestral()
        {
            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100;
            double tiempo = double.Parse(Tiempo.Text);

            tiempo = tiempo * 3;
            interes = interes / 3;
            double calculo1 = capital * Math.Pow(1 + interes, tiempo);
            semestral.Text = " El Resultado es: " + Math.Round(calculo1).ToString("C2");


        }
        private void calcularDiario()
        {
            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100;
            double tiempo = double.Parse(Tiempo.Text);

            tiempo = tiempo * 365;
            interes = interes / 365;
            double calculo1 = capital * Math.Pow(1 + interes, tiempo);
            semestral.Text = " El Resultado es: " + Math.Round(calculo1).ToString("C2");


        }
        //------------------------------diario,mensual,trimestra FIN....
        private void calcularDep()
        {
            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100.0;
            double tiempo = double.Parse(Tiempo.Text);
            double a = interes / 12;

            if (tiempo > 12)
            {
                double calculo = capital * (1 + (tiempo * a));
                double calculo1 = capital * Math.Pow(1 + a, tiempo);
                semestral.Text = " Valor final de la tasa de interes simple " + Math.Round(calculo).ToString("C2") + " \n " +
                "Tasa de interes capitalizable mensualmente = " + Math.Round(calculo1).ToString("C2");
            }
            else if (tiempo >= 1 && tiempo <= 12)
            {
                tiempo = tiempo * 12;
                double calculo = capital * (1 + (tiempo * a));
                double calculo1 = capital * Math.Pow(1 + a, tiempo);
                semestral.Text = " Valor final de la tasa de interes simple " + Math.Round(calculo).ToString("C2") + " \n " +
                "Tasa de interes capitalizable mensualmente = " + Math.Round(calculo1).ToString("C2");

            }

        }
        private void fraccionario()
        {
            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100;
            double meses = double.Parse(Meses.Text);
            double dias = double.Parse(Dias.Text);

            double a = interes;
            interes = interes / 12;
            double calculo1 = Math.Pow(1 + interes, meses);
            double calculo2 = capital * calculo1;
            //-------------------------dias------------------------------
            a = a / 360;
            double calculo3 = calculo2 * (1 + dias * (a));

            semestral.Text = " Resultado por los " + meses + " Meses es: " + Math.Round(calculo2).ToString("C2") + "\n" +
                " Resultado por los " + dias + " Dias es: " + Math.Round(calculo3).ToString("C2");
        }

        private void interescambia()
        {

            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100;
            double tiempo = double.Parse(Tiempo.Text);
            double Incrementointeres = double.Parse(incrementointeres.Text) / 100;


            interes = interes / 12;
            double calculo1 = capital * Math.Pow(1 + interes, tiempo);
            double calculo2 = 12 - tiempo;
            double calculo3 = calculo1 * Math.Pow(1 + (Incrementointeres/12),calculo2);
                
            semestral.Text = " El Primer Resultado es: " + Math.Round(calculo1).ToString("C2") + "\n"+ " El Segundo Resultado es: " + Math.Round(calculo3).ToString("C2");
            //-------------------------parte-2------------------------------
        }

        private void DepositoAdicional()
        {
            double capital = double.Parse(C.Text);
            double interes = double.Parse(i.Text) / 100;
            double tiempo = double.Parse(Tiempo.Text);
            double retiro = double.Parse(Retiro.Text);

            interes = interes / 12;

            double calculo1 = capital * Math.Pow(1 + interes, tiempo);
            double calculo2 = 12 - tiempo;

            double calculo3 = (calculo1- retiro) * Math.Pow(1 + interes, calculo2);

            semestral.Text = " El Primer Resultado es: " + Math.Round(calculo1).ToString("C2") + "\n" + " El Segundo Resultado es: " + Math.Round(calculo3).ToString("C2");
        }


            private void Form4_Load(object sender, EventArgs e)
        {

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Visible = false;
            label6.Visible = false;
            Dias.Visible = false;
            label1.Visible = false;
            Meses.Visible = false;
            Retiro.Visible = false;
            Retirol.Visible = false;
            incremento.Visible = false;
            incrementointeres.Visible = false;
            TC.Visible = false;
        }

        private void Meses_TextChanged(object sender, EventArgs e)
        {

        }

        private void incrementointeres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Retiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void semestral_Click(object sender, EventArgs e)
        {

        }
    }
    
}


