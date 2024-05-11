using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_MODERNISTA
{
    public partial class TIR : Form
    {
        public TIR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaldoInicial.Clear();
            c1.Clear();
            c2.Clear();
            descuento.Clear();
            ldes.Text = " ";
            label3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {

                if (comboBox2.SelectedItem.ToString() == "VAN")
                {
                    CALCULO();
                }
                else if (comboBox2.SelectedItem.ToString() == "TIR")
                {
                    Calculo2();
                }

                
            }
        }

        private void Dias_TextChanged(object sender, EventArgs e)
        {

        }

        private void Retiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void CALCULO()
        {         
            double saldo = double.Parse(SaldoInicial.Text);            
            if (años.SelectedItem != null)
            {
                //---------------------INICIO-----TIR------------------------------
                if (años.SelectedItem.ToString() == "2")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    des = des / 100;

                    double tasaInteresCalculada = (-saldo + (Caja1 / 1 + des) + (Caja2 / (Math.Pow(1 + des, 2))));
                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");

                   
                //---------------------FIN-----TIR------------------------------
                }
                else if (años.SelectedItem.ToString() == "3")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    des = des / 100;
                    double tasaInteresCalculada = ( - saldo + (Caja1/1+des) + (Caja2 / (Math.Pow(1 + des,2))) + (Caja3 / (Math.Pow(1 + des, 3))));
                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");
                }
                else if (años.SelectedItem.ToString() == "4")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    double Caja4 = double.Parse(c4.Text);
                    des = des / 100;
                    double tasaInteresCalculada = ((-saldo + (Caja1 / 1 + des)) + ((Caja2 / (Math.Pow(1 + des, 2)))) + ((Caja3 / (Math.Pow(1 + des, 3)))) + ((Caja4 / (Math.Pow(1 + des, 4)))));
                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");
                }
                else if (años.SelectedItem.ToString() == "5")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    double Caja4 = double.Parse(c4.Text);
                    double Caja5 = double.Parse(c5.Text);
                    des = des / 100;
                    double tasaInteresCalculada = ((-saldo + (Caja1 / 1 + des)) + ((Caja2 / (Math.Pow(1 + des, 2)))) + ((Caja3 / (Math.Pow(1 + des, 3)))) + 
                        ((Caja4 / (Math.Pow(1 + des, 4)))) + ((Caja5 / (Math.Pow(1 + des, 5)))));

                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");
                }
                else if (años.SelectedItem.ToString() == "6")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    double Caja4 = double.Parse(c4.Text);
                    double Caja5 = double.Parse(c5.Text);
                    double Caja6 = double.Parse(c6.Text);
                    des = des / 100;
                    double tasaInteresCalculada = ((-saldo + (Caja1 / 1 + des)) + ((Caja2 / (Math.Pow(1 + des, 2)))) + ((Caja3 / (Math.Pow(1 + des, 3)))) +
                    ((Caja4 / (Math.Pow(1 + des, 4)))) + ((Caja5 / (Math.Pow(1 + des, 5)))));

                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");

                }
                else if (años.SelectedItem.ToString() == "7")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    double Caja4 = double.Parse(c4.Text);
                    double Caja5 = double.Parse(c5.Text);
                    double Caja6 = double.Parse(c6.Text);
                    double Caja7 = double.Parse(c7.Text);
                    des = des / 100;

                    double tasaInteresCalculada = ((-saldo + (Caja1 / 1 + des)) + ((Caja2 / (Math.Pow(1 + des, 2)))) + ((Caja3 / (Math.Pow(1 + des, 3)))) +
                    ((Caja4 / (Math.Pow(1 + des, 4)))) + ((Caja5 / (Math.Pow(1 + des, 5)))) + ((Caja6 / (Math.Pow(1 + des, 6)))) + ((Caja7 / (Math.Pow(1 + des, 7)))));

                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");
                }
                else if (años.SelectedItem.ToString() == "8")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    double Caja4 = double.Parse(c4.Text);
                    double Caja5 = double.Parse(c5.Text);
                    double Caja6 = double.Parse(c6.Text);
                    double Caja7 = double.Parse(c7.Text);
                    double Caja8 = double.Parse(c8.Text);
                    des = des / 100;

                    double tasaInteresCalculada = ((-saldo + (Caja1 / 1 + des)) + ((Caja2 / (Math.Pow(1 + des, 2)))) + ((Caja3 / (Math.Pow(1 + des, 3)))) +
                    ((Caja4 / (Math.Pow(1 + des, 4)))) + ((Caja5 / (Math.Pow(1 + des, 5)))) + ((Caja6 / (Math.Pow(1 + des, 6)))) + ((Caja7 / (Math.Pow(1 + des, 7)))) +
                    ((Caja8 / (Math.Pow(1 + des, 8)))));

                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");
                }
                else if (años.SelectedItem.ToString() == "9")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    double Caja4 = double.Parse(c4.Text);
                    double Caja5 = double.Parse(c5.Text);
                    double Caja6 = double.Parse(c6.Text);
                    double Caja7 = double.Parse(c7.Text);
                    double Caja8 = double.Parse(c8.Text);
                    double Caja9 = double.Parse(c9.Text);
                    des = des / 100;

                    double tasaInteresCalculada = ((-saldo + (Caja1 / 1 + des)) + ((Caja2 / (Math.Pow(1 + des, 2)))) + ((Caja3 / (Math.Pow(1 + des, 3)))) +
                    ((Caja4 / (Math.Pow(1 + des, 4)))) + ((Caja5 / (Math.Pow(1 + des, 5)))) + ((Caja6 / (Math.Pow(1 + des, 6)))) + ((Caja7 / (Math.Pow(1 + des, 7)))) +
                    ((Caja8 / (Math.Pow(1 + des, 8)))) + ((Caja9 / (Math.Pow(1 + des, 9)))));

                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");
                }
                else if (años.SelectedItem.ToString() == "10")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    double Caja4 = double.Parse(c4.Text);
                    double Caja5 = double.Parse(c5.Text);
                    double Caja6 = double.Parse(c6.Text);
                    double Caja7 = double.Parse(c7.Text);
                    double Caja8 = double.Parse(c8.Text);
                    double Caja9 = double.Parse(c9.Text);
                    double Caja10 = double.Parse(c10.Text);
                    des = des / 100;

                    double tasaInteresCalculada = ((-saldo + (Caja1 / 1 + des)) + ((Caja2 / (Math.Pow(1 + des, 2)))) + ((Caja3 / (Math.Pow(1 + des, 3)))) +
                    ((Caja4 / (Math.Pow(1 + des, 4)))) + ((Caja5 / (Math.Pow(1 + des, 5)))) + ((Caja6 / (Math.Pow(1 + des, 6)))) + ((Caja7 / (Math.Pow(1 + des, 7)))) +
                    ((Caja8 / (Math.Pow(1 + des, 8)))) + ((Caja9 / (Math.Pow(1 + des, 9)))) + ((Caja10 / (Math.Pow(1 + des, 10)))));

                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");
                }
                else if (años.SelectedItem.ToString() == "11")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    double Caja4 = double.Parse(c4.Text);
                    double Caja5 = double.Parse(c5.Text);
                    double Caja6 = double.Parse(c6.Text);
                    double Caja7 = double.Parse(c7.Text);
                    double Caja8 = double.Parse(c8.Text);
                    double Caja9 = double.Parse(c9.Text);
                    double Caja10 = double.Parse(c10.Text);
                    double Caja11 = double.Parse(c11.Text);
                    des = des / 100;

                    double tasaInteresCalculada = ((-saldo + (Caja1 / 1 + des)) + ((Caja2 / (Math.Pow(1 + des, 2)))) + ((Caja3 / (Math.Pow(1 + des, 3)))) +
                    ((Caja4 / (Math.Pow(1 + des, 4)))) + ((Caja5 / (Math.Pow(1 + des, 5)))) + ((Caja6 / (Math.Pow(1 + des, 6)))) + ((Caja7 / (Math.Pow(1 + des, 7)))) +
                    ((Caja8 / (Math.Pow(1 + des, 8)))) + ((Caja9 / (Math.Pow(1 + des, 9)))) + ((Caja10 / (Math.Pow(1 + des, 10)))) + ((Caja11 / (Math.Pow(1 + des, 11)))));

                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");

                }
                else if (años.SelectedItem.ToString() == "12")
                {
                    double des = double.Parse(descuento.Text);
                    double Caja1 = double.Parse(c1.Text);
                    double Caja2 = double.Parse(c2.Text);
                    double Caja3 = double.Parse(c3.Text);
                    double Caja4 = double.Parse(c4.Text);
                    double Caja5 = double.Parse(c5.Text);
                    double Caja6 = double.Parse(c6.Text);
                    double Caja7 = double.Parse(c7.Text);
                    double Caja8 = double.Parse(c8.Text);
                    double Caja9 = double.Parse(c9.Text);
                    double Caja10 = double.Parse(c10.Text);
                    double Caja11 = double.Parse(c11.Text);
                    double Caja12 = double.Parse(c12.Text);
                    des = des / 100;

                    double tasaInteresCalculada = ((-saldo + (Caja1 / 1 + des)) + ((Caja2 / (Math.Pow(1 + des, 2)))) + ((Caja3 / (Math.Pow(1 + des, 3)))) +
                    ((Caja4 / (Math.Pow(1 + des, 4)))) + ((Caja5 / (Math.Pow(1 + des, 5)))) + ((Caja6 / (Math.Pow(1 + des, 6)))) + ((Caja7 / (Math.Pow(1 + des, 7)))) +
                    ((Caja8 / (Math.Pow(1 + des, 8)))) + ((Caja9 / (Math.Pow(1 + des, 9)))) + ((Caja10 / (Math.Pow(1 + des, 10)))) + ((Caja11 / (Math.Pow(1 + des, 11)))) +
                    ((Caja12 / (Math.Pow(1 + des, 12)))));

                    resultado.Text = "Rentabilidad de la inversion = " + (tasaInteresCalculada).ToString("C");


                }
            }
        }

        private void Visibles()
        {
            ldes.Visible = false;
            descuento.Visible = false;
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            l11.Visible = false;
            l12.Visible = false;
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            c8.Visible = false;
            c9.Visible = false;
            c10.Visible = false;
            c11.Visible = false;
            c12.Visible = false;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (años.SelectedItem != null)
            {
                
                if (años.SelectedItem.ToString() == "2")
                {
                    Visibles();  
                    l1.Visible = true;
                    l2.Visible = true;
                    c1.Visible = true;
                    c2.Visible = true;
                    
                }
                else if (años.SelectedItem.ToString() == "3")
                {
                    Visibles();
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    
                }
                else if (años.SelectedItem.ToString() == "4")
                {
                    Visibles();
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    l4.Visible = true;
                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    c4.Visible = true;
                    
                }
                else if (años.SelectedItem.ToString() == "5")
                {
                    Visibles();
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    l4.Visible = true;
                    l5.Visible = true;
                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    c4.Visible = true;
                    c5.Visible = true;
                }
                else if (años.SelectedItem.ToString() == "6")
                {
                    Visibles();
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    l4.Visible = true;
                    l5.Visible = true;
                    l6.Visible = true;
                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    c4.Visible = true;
                    c5.Visible = true;
                    c6.Visible = true;
                }
                else if (años.SelectedItem.ToString() == "7")
                {
                    Visibles();
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    l4.Visible = true;
                    l5.Visible = true;
                    l6.Visible = true;
                    l7.Visible = true;
                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    c4.Visible = true;
                    c5.Visible = true;
                    c6.Visible = true;
                    c7.Visible = true;

                }
                else if (años.SelectedItem.ToString() == "8")
                {
                    Visibles();
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    l4.Visible = true;
                    l5.Visible = true;
                    l6.Visible = true;
                    l7.Visible = true;
                    l8.Visible = true;
                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    c4.Visible = true;
                    c5.Visible = true;
                    c6.Visible = true;
                    c7.Visible = true;
                    c8.Visible = true;

                }
                else if (años.SelectedItem.ToString() == "9")
                {
                    Visibles();
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    l4.Visible = true;
                    l5.Visible = true;
                    l6.Visible = true;
                    l7.Visible = true;
                    l8.Visible = true;
                    l9.Visible = true;

                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    c4.Visible = true;
                    c5.Visible = true;
                    c6.Visible = true;
                    c7.Visible = true;
                    c8.Visible = true;
                    c9.Visible = true;

                }
                else if (años.SelectedItem.ToString() == "10")
                {
                    Visibles();
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    l4.Visible = true;
                    l5.Visible = true;
                    l6.Visible = true;
                    l7.Visible = true;
                    l8.Visible = true;
                    l9.Visible = true;
                    l10.Visible = true;
                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    c4.Visible = true;
                    c5.Visible = true;
                    c6.Visible = true;
                    c7.Visible = true;
                    c8.Visible = true;
                    c9.Visible = true;
                    c10.Visible = true;
                }
                else if (años.SelectedItem.ToString() == "11")
                {
                    Visibles();
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    l4.Visible = true;
                    l5.Visible = true;
                    l6.Visible = true;
                    l7.Visible = true;
                    l8.Visible = true;
                    l9.Visible = true;
                    l10.Visible = true;
                    l11.Visible = true;
                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    c4.Visible = true;
                    c5.Visible = true;
                    c6.Visible = true;
                    c7.Visible = true;
                    c8.Visible = true;
                    c9.Visible = true;
                    c10.Visible = true;
                    c11.Visible = true;
                }
                else if (años.SelectedItem.ToString() == "12")
                {
                    ldes.Visible = true;
                    descuento.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                    l3.Visible = true;
                    l4.Visible = true;
                    l5.Visible = true;
                    l6.Visible = true;
                    l7.Visible = true;
                    l8.Visible = true;
                    l9.Visible = true;
                    l10.Visible = true;
                    l11.Visible = true;
                    l12.Visible = true;

                    c1.Visible = true;
                    c2.Visible = true;
                    c3.Visible = true;
                    c4.Visible = true;
                    c5.Visible = true;
                    c6.Visible = true;
                    c7.Visible = true;
                    c8.Visible = true;
                    c9.Visible = true;
                    c10.Visible = true;
                    c11.Visible = true;
                    c12.Visible = true;
                }
            }

            }

        private void TIR_Load(object sender, EventArgs e)
        {

            ldes.Visible = false;
            descuento.Visible = false;

            l2.Visible = true;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            l11.Visible = false;
            l12.Visible = false;

            
            c2.Visible = true;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            c8.Visible = false;
            c9.Visible = false;
            c10.Visible = false;
            c11.Visible = false;
            c12.Visible = false;
        }

        private void descuento_TextChanged(object sender, EventArgs e)
        {

        }
        private void Calculo2()
        {

                double saldo = double.Parse(SaldoInicial.Text);
                double Caja1 = double.Parse(c1.Text);
                double Caja2 = double.Parse(c2.Text);

                double tasaInteresCalculada = (-Caja1 - Math.Sqrt(Math.Pow(Caja1, 2) - 4 * (-saldo) * Caja2));
                double coño = 2 * (-saldo);
                double juntar = ((tasaInteresCalculada / coño) - 1);
                

                 resultado.Text = "Rentabilidad de la inversion = " + Math.Round(juntar*100)+"%"+
                    "\nTasa interna de retorno = " + (juntar).ToString("N3");
               
            }


            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {

                if (comboBox2.SelectedItem.ToString() == "VAN")
                {              
                   ldes.Visible = true;
                    descuento.Visible = true;
                }
                else if (comboBox2.SelectedItem.ToString() == "TIR")
                {                  
                    ldes.Visible = false;
                    descuento.Visible = false;
                }
             
            }
            }
    }
    }

