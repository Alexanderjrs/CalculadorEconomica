using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Calculadora;

namespace GUI_MODERNISTA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null ,e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCompuesto_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnCompuestoSimple_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new CompuestoSimple());
        }

        private void btnCompuestoAvanzado_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new CompAvanzadp());
        }

        
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
           
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new productos());
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Anualidades());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Simple());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TIR());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Tasa_de_Interes());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Capitalizacion());
        }
    }
}
