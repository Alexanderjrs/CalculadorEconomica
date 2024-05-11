namespace Calculadora
{
    partial class CompAvanzadp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompAvanzadp));
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.semestral = new System.Windows.Forms.Label();
            this.Dias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Meses = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.incrementointeres = new System.Windows.Forms.TextBox();
            this.incremento = new System.Windows.Forms.Label();
            this.Retirol = new System.Windows.Forms.Label();
            this.Retiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(546, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 43);
            this.button2.TabIndex = 30;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(419, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tiempo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.Location = new System.Drawing.Point(516, 316);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(100, 20);
            this.Tiempo.TabIndex = 28;
            this.Tiempo.TextChanged += new System.EventHandler(this.Tiempo_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(388, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // i
            // 
            this.i.Location = new System.Drawing.Point(516, 342);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(100, 20);
            this.i.TabIndex = 26;
            this.i.TextChanged += new System.EventHandler(this.i_TextChanged);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(516, 290);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 20);
            this.C.TabIndex = 25;
            this.C.TextChanged += new System.EventHandler(this.C_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(379, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tasa Interes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(423, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Capital";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Valor final a interés compuesto",
            "Deposito",
            "Monto con periodo fraccionario",
            "Monto cuando la tasa de interés se cambia",
            "Depósito adicional o retiro realizado"});
            this.comboBox1.Location = new System.Drawing.Point(442, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Tipo de Operaciones";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // semestral
            // 
            this.semestral.AutoSize = true;
            this.semestral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.semestral.ForeColor = System.Drawing.Color.White;
            this.semestral.Location = new System.Drawing.Point(3, 21);
            this.semestral.Name = "semestral";
            this.semestral.Size = new System.Drawing.Size(115, 25);
            this.semestral.TabIndex = 32;
            this.semestral.Text = "Resultado:";
            this.semestral.Click += new System.EventHandler(this.semestral_Click);
            // 
            // Dias
            // 
            this.Dias.Location = new System.Drawing.Point(516, 394);
            this.Dias.Name = "Dias";
            this.Dias.Size = new System.Drawing.Size(100, 20);
            this.Dias.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Dias";
            // 
            // Meses
            // 
            this.Meses.Location = new System.Drawing.Point(516, 368);
            this.Meses.Name = "Meses";
            this.Meses.Size = new System.Drawing.Size(100, 20);
            this.Meses.TabIndex = 36;
            this.Meses.TextChanged += new System.EventHandler(this.Meses_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(426, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Meses";
            // 
            // incrementointeres
            // 
            this.incrementointeres.Location = new System.Drawing.Point(516, 446);
            this.incrementointeres.Name = "incrementointeres";
            this.incrementointeres.Size = new System.Drawing.Size(100, 20);
            this.incrementointeres.TabIndex = 40;
            this.incrementointeres.TextChanged += new System.EventHandler(this.incrementointeres_TextChanged);
            // 
            // incremento
            // 
            this.incremento.AutoSize = true;
            this.incremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.incremento.ForeColor = System.Drawing.Color.White;
            this.incremento.Location = new System.Drawing.Point(267, 440);
            this.incremento.Name = "incremento";
            this.incremento.Size = new System.Drawing.Size(243, 25);
            this.incremento.TabIndex = 39;
            this.incremento.Text = "Incremento Tasa Interes";
            // 
            // Retirol
            // 
            this.Retirol.AutoSize = true;
            this.Retirol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Retirol.ForeColor = System.Drawing.Color.White;
            this.Retirol.Location = new System.Drawing.Point(433, 415);
            this.Retirol.Name = "Retirol";
            this.Retirol.Size = new System.Drawing.Size(69, 25);
            this.Retirol.TabIndex = 41;
            this.Retirol.Text = "Retiro";
            this.Retirol.Click += new System.EventHandler(this.label7_Click);
            // 
            // Retiro
            // 
            this.Retiro.Location = new System.Drawing.Point(516, 420);
            this.Retiro.Name = "Retiro";
            this.Retiro.Size = new System.Drawing.Size(100, 20);
            this.Retiro.TabIndex = 42;
            this.Retiro.TextChanged += new System.EventHandler(this.Retiro_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(295, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 33);
            this.label5.TabIndex = 44;
            this.label5.Text = "Calcular Compuesto Avanzado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(160, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(731, 200);
            this.label7.TabIndex = 45;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Diario",
            "Mensual",
            "Trimestral",
            "Cuatrimestral",
            "Semestral",
            "Anual"});
            this.comboBox2.Location = new System.Drawing.Point(856, 251);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 21);
            this.comboBox2.TabIndex = 46;
            this.comboBox2.Text = "Tiempo de la Operacion";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(247, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "Tipo de Operacion\r\n";
            // 
            // TC
            // 
            this.TC.AutoSize = true;
            this.TC.BackColor = System.Drawing.Color.Transparent;
            this.TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TC.ForeColor = System.Drawing.Color.White;
            this.TC.Location = new System.Drawing.Point(637, 247);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(213, 25);
            this.TC.TabIndex = 52;
            this.TC.Text = "Tiempo Capitalizable";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.semestral);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(264, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 71);
            this.panel1.TabIndex = 53;
            // 
            // CompAvanzadp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1059, 612);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Retiro);
            this.Controls.Add(this.Retirol);
            this.Controls.Add(this.incrementointeres);
            this.Controls.Add(this.incremento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Meses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dias);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.i);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompAvanzadp";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tiempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox i;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label semestral;
        private System.Windows.Forms.TextBox Dias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Meses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox incrementointeres;
        private System.Windows.Forms.Label incremento;
        private System.Windows.Forms.Label Retirol;
        private System.Windows.Forms.TextBox Retiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TC;
        private System.Windows.Forms.Panel panel1;
    }
}