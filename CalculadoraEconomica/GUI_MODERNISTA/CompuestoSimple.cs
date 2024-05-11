using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CompuestoSimple : Form
    {
        

        public CompuestoSimple()
        {
            
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCalcular_Click_Click(object sender, EventArgs e)
        {
            
        }

        private void CalcularMC()
        {
           
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Monto Compuesto")
                {

                    CalcularMontoCompuesto();
                }
                else if (comboBox1.SelectedItem.ToString() == "Tiempo")
                {
                    CalcularTiempo();

                }
                else if (comboBox1.SelectedItem.ToString() == "Tasa de Interes")
                {
                    CalcularTasaInteres();
                }
                else if (comboBox1.SelectedItem.ToString() == "Capital Inicial")
                {
                    CalcularCapital();
                }
            }
        }

        private void semestral_Click(object sender, EventArgs e)
        {

        }

        private void MC_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_TextChanged(object sender, EventArgs e)
        {

        }

        private void i_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Monto Compuesto")
                {
                    // Deshabilita controles u oculta etiquetas según sea necesario
                    MC.Visible = false;
                    label1.Visible = false;

                    i.Visible = true;
                    C.Visible = true;
                    Tiempo.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;

                }
                else if (comboBox1.SelectedItem.ToString() == "Tiempo")
                {
                    // Deshabilita controles u oculta etiquetas según sea necesario
                    Tiempo.Visible = false;
                    label4.Visible = false;
                   

                    i.Visible = true;
                    C.Visible = true;
                    MC.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    
                }
                else if (comboBox1.SelectedItem.ToString() == "Tasa de Interes")
                {
                    // Deshabilita controles u oculta etiquetas según sea necesario

                    label3.Visible = false;
                    i.Visible = false;
                    

                    Tiempo.Visible = true;
                    label4.Visible = true;         
                    C.Visible = true;
                    MC.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                }
                else if (comboBox1.SelectedItem.ToString() == "Capital Inicial")
                {
                    // Deshabilita controles u oculta etiquetas según sea necesario

                    label2.Visible = false;
                    C.Visible = false;
                    

                    Tiempo.Visible = true;
                    label4.Visible = true;
                    label3.Visible = true;
                    i.Visible = true;
                    MC.Visible = true;
                    label1.Visible = true;
                    
                }

            }
            else
            {

                MessageBox.Show("Por favor, selecciona una opción en el ComboBox.");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void CalcularTasaInteres()
        {
            double montoCompuesto = double.Parse(MC.Text);
            double capital = double.Parse(C.Text);
            double tiempo = double.Parse(Tiempo.Text);

            double tasaInteresCalculada = (montoCompuesto / capital);
            double tasaInteres = Math.Pow(tasaInteresCalculada, 1 / tiempo) - 1;

            semestral.Text = "Tasa de Interés (i) = " + (tasaInteres * 100).ToString("0.00") + "%";        
        }

        private void CalcularMontoCompuesto()
        {
            try
            {
                double tiempo = double.Parse(Tiempo.Text);
                double capital = double.Parse(C.Text);
                double tasaInteres = double.Parse(i.Text) / 100.0;

                // Calcular el tiempo (n)


                double Final = capital * (Math.Pow(1 + tasaInteres, tiempo));

                // Mostrar el resultado
                semestral.Text = "El Monto Compuesto es: " + Math.Round(Final).ToString("C2");
            }
            catch (FormatException)
            {
                // Manejar el caso en que la entrada no sea un número válido
                MessageBox.Show("Por favor, ingrese números válidos en todos los campos.");
            }
            catch (DivideByZeroException)
            {
                // Manejar el caso en que el capital sea cero
                MessageBox.Show("El capital no puede ser cero.");
            }

        }

        private void CalcularCapital()
        {
            try
            {
                double tiempo = double.Parse(Tiempo.Text);
                double montoCompuesto = double.Parse(MC.Text);
                double tasaInteres = double.Parse(i.Text) / 100.0;

                
                double Final = montoCompuesto / (Math.Pow(1 + tasaInteres, tiempo));

                // Mostrar el resultado
                semestral.Text = "El Capital es: " + Math.Round(Final).ToString("C2");
                
            }
            catch (FormatException)
            {
                // Manejar el caso en que la entrada no sea un número válido
                MessageBox.Show("Por favor, ingrese números válidos en todos los campos.");
            }
            catch (DivideByZeroException)
            {
                // Manejar el caso en que el capital sea cero
                MessageBox.Show("El capital no puede ser cero.");
            }
        }


        private void CalcularTiempo()
        {
            try
            {
                double montoCompuesto = double.Parse(MC.Text);
                double capital = double.Parse(C.Text);
                double tasaInteres = double.Parse(i.Text) / 100.0;

                // Calcular el tiempo (n)
                double A = Math.Log(montoCompuesto);
                double B = Math.Log(capital);
                double X = Math.Log(1 + tasaInteres);

                double Final = (A - B) / X;

                // Mostrar el resultado
                semestral.Text = "El tiempo es: " + Math.Round(Final) + " Meses ";
            }
            catch (FormatException)
            {
                // Manejar el caso en que la entrada no sea un número válido
                MessageBox.Show("Por favor, ingrese números válidos en todos los campos.");
            }
            catch (DivideByZeroException)
            {
                // Manejar el caso en que el capital sea cero
                MessageBox.Show("El capital no puede ser cero.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MC.Clear();
            i.Clear();
            C.Clear();
            Tiempo.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

    }
}







