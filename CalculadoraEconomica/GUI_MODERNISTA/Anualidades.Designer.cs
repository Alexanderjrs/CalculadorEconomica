namespace Calculadora
{
    partial class Anualidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anualidades));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.enganche = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pa = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.TC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(331, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capital o Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(368, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Porcentaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(411, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiempo";
            // 
            // i
            // 
            this.i.Location = new System.Drawing.Point(500, 386);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(100, 20);
            this.i.TabIndex = 11;
            this.i.TextChanged += new System.EventHandler(this.i_TextChanged_1);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(500, 350);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 20);
            this.n.TabIndex = 12;
            this.n.TextChanged += new System.EventHandler(this.n_TextChanged_1);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(500, 314);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 13;
            this.A.TextChanged += new System.EventHandler(this.A_TextChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Anualidades Ordinarias",
            "Inversiones",
            "Inversiones y Renta",
            "Importes",
            "Anualidades Vencidas"});
            this.comboBox1.Location = new System.Drawing.Point(470, 240);
            this.comboBox1.MaxLength = 50;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.SeaGreen;
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Limpiar.ForeColor = System.Drawing.Color.White;
            this.Limpiar.Location = new System.Drawing.Point(510, 463);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(150, 46);
            this.Limpiar.TabIndex = 19;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(328, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enganche
            // 
            this.enganche.Location = new System.Drawing.Point(500, 423);
            this.enganche.Name = "enganche";
            this.enganche.Size = new System.Drawing.Size(100, 20);
            this.enganche.TabIndex = 21;
            this.enganche.TextChanged += new System.EventHandler(this.enganche_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(385, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Enganche";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Prestamos",
            "Ahorros"});
            this.comboBox3.Location = new System.Drawing.Point(470, 277);
            this.comboBox3.MaxLength = 50;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(130, 21);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Resultado = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(287, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 33);
            this.label7.TabIndex = 45;
            this.label7.Text = "Calcular Anualidades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(151, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(725, 125);
            this.label6.TabIndex = 46;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // Pa
            // 
            this.Pa.AutoSize = true;
            this.Pa.BackColor = System.Drawing.Color.Transparent;
            this.Pa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Pa.ForeColor = System.Drawing.Color.White;
            this.Pa.Location = new System.Drawing.Point(251, 277);
            this.Pa.Name = "Pa";
            this.Pa.Size = new System.Drawing.Size(213, 25);
            this.Pa.TabIndex = 47;
            this.Pa.Text = "Prestamos o Ahorros";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Ordinaria",
            "Diario",
            "Mensual",
            "Trimestral",
            "Cuatrimestral",
            "Semestral",
            "Anual"});
            this.comboBox4.Location = new System.Drawing.Point(839, 240);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(180, 21);
            this.comboBox4.TabIndex = 48;
            this.comboBox4.Text = "Tiempo de la Operacion";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // TC
            // 
            this.TC.AutoSize = true;
            this.TC.BackColor = System.Drawing.Color.Transparent;
            this.TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TC.ForeColor = System.Drawing.Color.White;
            this.TC.Location = new System.Drawing.Point(620, 236);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(213, 25);
            this.TC.TabIndex = 49;
            this.TC.Text = "Tiempo Capitalizable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(275, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tipo de Operacion\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(215, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 71);
            this.panel1.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(323, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(362, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "Formula P = A [(1+i)^n - 1 / i (1+i)^n ]\r\n";
            // 
            // Anualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1059, 612);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.Pa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enganche);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.A);
            this.Controls.Add(this.n);
            this.Controls.Add(this.i);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anualidades";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox i;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox enganche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Pa;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label TC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}