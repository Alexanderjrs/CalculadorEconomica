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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Calculadora
{
    public partial class Anualidades : Form
    {

        public Anualidades()
        {
            
            InitializeComponent();
        }
        
        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void n_TextChanged(object sender, EventArgs e)
        {

        }

        public void i_TextChanged(object sender, EventArgs e)
        {

        }

        public void A_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnualidadOrdinaria()
        {
            try
            {
                // A = Pago Inicial
                // n = Meses/Semestres
                // i = Tasa Interes

                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal

                
                double valorFuturo = PagoInicial * ((Math.Pow(1 + Porcentaje, MesesSemestres) - 1) / Porcentaje);

                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo).ToString("C2"));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }
        //-----------------------------TODO ES EL PRIMER PUNTOOOOO-----------------------------------------
        private void CalcularAnual()
        {
            try
            {
                // A = Pago Inicial
                // n = Meses/Semestres
                // i = Tasa Interes

                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal

                //MesesSemestres = MesesSemestres * 12;
                double valorFuturo = PagoInicial * ((Math.Pow(1 + Porcentaje, MesesSemestres) - 1) / Porcentaje);

                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo).ToString("C2"));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }

        private void CalcularResultadoSemestral()
        {
            try
            {
                // A = Pago Inicial
                // n = Meses/Semestres
                // i = Tasa Interes

                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal

                
                MesesSemestres = MesesSemestres * 6;

                double valorFuturo = PagoInicial * ((Math.Pow(1 + Porcentaje, MesesSemestres) - 1) / Porcentaje);

                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo).ToString("C2"));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }
        private void CalcularResultadoTrimestral()
        {
            try
            {
                
                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal

           
                MesesSemestres = MesesSemestres * 3;
                double valorFuturo = PagoInicial * ((Math.Pow(1 + Porcentaje, MesesSemestres) - 1) / Porcentaje);

                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo).ToString("C2"));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }
        private void CalcularResultadoCuatrimestral()
        {
            try
            {
                // A = Pago Inicial
                // n = Meses/Semestres
                // i = Tasa Interes

                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal

                MesesSemestres = MesesSemestres * 4;

                double valorFuturo = PagoInicial * ((Math.Pow(1 + Porcentaje, MesesSemestres) - 1) / Porcentaje);

                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo).ToString("C2"));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }
        private void CalcularResultadoMensual()
        {
            try
            {
                // A = Pago Inicial
                // n = Meses/Semestres
                // i = Tasa Interes

                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; 



                double valorFuturo = PagoInicial * ((Math.Pow(1 + Porcentaje, MesesSemestres) - 1) / Porcentaje);

                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo).ToString("C2"));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }
        private void CalcularResultadoDiario()
        {
            try
            { 


                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0;


                MesesSemestres = MesesSemestres / 30;
                double valorFuturo = PagoInicial * (Math.Pow(1 + Porcentaje, MesesSemestres) - 1) / Porcentaje;

                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo).ToString("C2"));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }

        //-----------------------------PRIMER PUNTOOOOO FIIIN-----------------------------------------

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Anualidades Ordinarias")
                {
                    if (comboBox4.SelectedItem != null)
                    {
                        string selectedItem = comboBox4.SelectedItem.ToString();
                        switch (selectedItem)
                        {
                            case "Ordinaria":
                                AnualidadOrdinaria();
                                break;
                            case "Diario":
                                CalcularResultadoDiario();
                                break;
                            case "Mensual":
                                CalcularResultadoMensual();
                                break;
                            case "Trimestral":
                                CalcularResultadoTrimestral();
                                break;
                            case "Cuatrimestral":
                                CalcularResultadoCuatrimestral();
                                break;
                            case "Semestral":
                                CalcularResultadoSemestral();
                                break;
                            case "Anual":
                                CalcularAnual();
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
                

                else if (comboBox1.SelectedItem.ToString() == "Inversiones")
                {        
                    InversionSemestral();
                }
                else if (comboBox1.SelectedItem.ToString() == "Inversiones y Renta")
                {
                    InvesionYRenta();
                }
                else if (comboBox1.SelectedItem.ToString() == "Importes")
                {
                    CalcularImporte();

                }
                else if (comboBox1.SelectedItem.ToString() == "Anualidades Vencidas")
                {
                    if (comboBox3.SelectedItem != null)  
                    {
                        string selectedItem = comboBox3.SelectedItem.ToString();
                        switch (selectedItem)
                        {
                            case "Prestamos":
                                CalcularVencimiento1();
                                break;
                            case "Ahorros":
                                CalcularVencimiento();
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
            }
        }

        public void resul_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void InversionSemestral()
        {
            try
            {
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal
                double PagoInicial = double.Parse(A.Text);

                // A = Pago Inicial
                // n = Meses/Semestres
                // i = Tasa Interes

                double valorFuturo = PagoInicial / ((Math.Pow(1 + Porcentaje, MesesSemestres) - 1) / Porcentaje);


                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo));
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }



        

        private void InvesionYRenta()
        {
            try
            {
                

                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal
                

               
                // Calcular el valor futuro de la anualidad
                double valorFuturo = (PagoInicial * (1-(Math.Pow(1 + Porcentaje, -MesesSemestres))) / Porcentaje);

                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo));
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }
        private void A_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void n_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void i_TextChanged_1(object sender, EventArgs e)
        {

        }

        
        private void CalcularImporte()
        {
            try
            {
                // A = Pago Inicial
                // n = Meses/Semestres
                // i = Tasa Interes

                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal
                double Enganche = double.Parse(enganche.Text);


                // Calcular el valor futuro de la anualidad
                double valorFuturo = PagoInicial * (1 - Math.Pow(1 + (Porcentaje / MesesSemestres), -MesesSemestres)) / (Porcentaje / MesesSemestres);

                label1.Text = ("El Resultado es: " + Math.Round(valorFuturo) + "\nMas el enganche: " + Math.Round(valorFuturo + Enganche));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }

        private void CalcularVencimiento1()
        {
            try
            {

                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal


                // Calcular el valor futuro de la anualidad
                double valorFuturoTotal = 0;
                for (double mes = 1; mes <= MesesSemestres; mes++)
                {
                    double valorFuturoMes = PagoInicial / Math.Pow(1 + Porcentaje, mes);
                    valorFuturoTotal += valorFuturoMes;
                }

                label1.Text = "El Resultado es: " + Math.Round(valorFuturoTotal);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }

        private void CalcularVencimiento()
        {
            try
            {
                // A = Pago Inicial
                // n = Meses/Semestres
                // i = Tasa Interes

                double PagoInicial = double.Parse(A.Text);
                double MesesSemestres = double.Parse(n.Text);
                double Porcentaje = double.Parse(i.Text) / 100.0; // Convertir a decimal


                // Calcular el valor futuro de la anualidad
                double valorFuturo = PagoInicial * ((Math.Pow(1 + Porcentaje, MesesSemestres) - 1) / Porcentaje);
                label1.Text = (" El Resultado es: " + Math.Round(valorFuturo));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los TextBox.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La tasa de interés no puede ser cero.");
            }
        }

 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {

                
                if (comboBox1.SelectedItem.ToString() == "Anualidades Ordinarias")
                {
                    // Deshabilita controles u oculta etiquetas según sea necesario

                    comboBox4.Visible = true;
                    TC.Visible = true;
                    
                    enganche.Visible = false;
                    label5.Visible= false;
                    comboBox3.Visible = false;
                    Pa.Visible = false;
                }
                else if (comboBox1.SelectedItem.ToString() == "Inversiones")
                {
                    // Deshabilita controles u oculta etiquetas según sea necesario 
                    comboBox4.Visible = false;
                    TC.Visible = false;
                    
                    enganche.Visible = false;
                    label5.Visible = false;
                    comboBox3.Visible = false;
                    Pa.Visible = false;
                }
                else if (comboBox1.SelectedItem.ToString() == "Inversiones y Renta")
                {
                    // Deshabilita controles u oculta etiquetas según sea necesario 
                    comboBox4.Visible = false;
                    TC.Visible = false;
                    
                    enganche.Visible = false;
                    label5.Visible = false;
                    comboBox3.Visible = false;
                    Pa.Visible = false;
                }
                else if (comboBox1.SelectedItem.ToString() == "Importes")
                {
                    // Deshabilita controles u oculta etiquetas según sea necesario
                    comboBox4.Visible = false;
                    TC.Visible = false;
                    enganche.Visible = true;
                    label5.Visible = true;
                    
                    comboBox3.Visible = false;
                    Pa.Visible = false;
                }
                else if (comboBox1.SelectedItem.ToString() == "Anualidades Vencidas")
                {
                    // Deshabilita controles u oculta etiquetas según sea necesario
                    comboBox4.Visible = false;
                    TC.Visible = false;
                    
                    comboBox3.Visible = true;
                    enganche.Visible = false;
                    label5.Visible = false;
                    Pa.Visible = true;
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            //dataGridView1.SendToBack();
            
            enganche.Visible = false;
            label5.Visible = false;
            Pa.Visible = false;
            TC.Visible = false;          
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;          
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button6_Click(object sender, EventArgs e)
        {
        
            n.Clear();
            i.Clear();
            A.Clear();
            label1.Text = "";
        }

        private void mostrar_Click(object sender, EventArgs e)
        {

        }

        private void enganche_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
