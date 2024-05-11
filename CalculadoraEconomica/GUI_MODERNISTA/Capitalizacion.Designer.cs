namespace GUI_MODERNISTA
{
    partial class Capitalizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capitalizacion));
            this.periodosl = new System.Windows.Forms.Label();
            this.Periodos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultado = new System.Windows.Forms.Label();
            this.presentel = new System.Windows.Forms.Label();
            this.valorP = new System.Windows.Forms.TextBox();
            this.interesl = new System.Windows.Forms.Label();
            this.Interes = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.futurol = new System.Windows.Forms.Label();
            this.ValorFuturo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // periodosl
            // 
            this.periodosl.AutoSize = true;
            this.periodosl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.periodosl.ForeColor = System.Drawing.Color.White;
            this.periodosl.Location = new System.Drawing.Point(301, 304);
            this.periodosl.Name = "periodosl";
            this.periodosl.Size = new System.Drawing.Size(97, 25);
            this.periodosl.TabIndex = 77;
            this.periodosl.Text = "Periodos";
            // 
            // Periodos
            // 
            this.Periodos.Location = new System.Drawing.Point(404, 309);
            this.Periodos.Name = "Periodos";
            this.Periodos.Size = new System.Drawing.Size(100, 20);
            this.Periodos.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.resultado);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(149, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 71);
            this.panel1.TabIndex = 75;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultado.ForeColor = System.Drawing.Color.White;
            this.resultado.Location = new System.Drawing.Point(3, 21);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(86, 20);
            this.resultado.TabIndex = 12;
            this.resultado.Text = "Resultado:";
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // presentel
            // 
            this.presentel.AutoSize = true;
            this.presentel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.presentel.ForeColor = System.Drawing.Color.White;
            this.presentel.Location = new System.Drawing.Point(244, 252);
            this.presentel.Name = "presentel";
            this.presentel.Size = new System.Drawing.Size(154, 25);
            this.presentel.TabIndex = 74;
            this.presentel.Text = "Valor Presente";
            // 
            // valorP
            // 
            this.valorP.Location = new System.Drawing.Point(404, 257);
            this.valorP.Name = "valorP";
            this.valorP.Size = new System.Drawing.Size(100, 20);
            this.valorP.TabIndex = 73;
            // 
            // interesl
            // 
            this.interesl.AutoSize = true;
            this.interesl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.interesl.ForeColor = System.Drawing.Color.White;
            this.interesl.Location = new System.Drawing.Point(321, 278);
            this.interesl.Name = "interesl";
            this.interesl.Size = new System.Drawing.Size(77, 25);
            this.interesl.TabIndex = 72;
            this.interesl.Text = "Interes";
            // 
            // Interes
            // 
            this.Interes.Location = new System.Drawing.Point(404, 283);
            this.Interes.Name = "Interes";
            this.Interes.Size = new System.Drawing.Size(100, 20);
            this.Interes.TabIndex = 71;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.SeaGreen;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.limpiar.ForeColor = System.Drawing.Color.White;
            this.limpiar.Location = new System.Drawing.Point(404, 351);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(124, 44);
            this.limpiar.TabIndex = 70;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.SeaGreen;
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calcular.ForeColor = System.Drawing.Color.White;
            this.calcular.Location = new System.Drawing.Point(274, 351);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(124, 44);
            this.calcular.TabIndex = 69;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Valor Presente",
            "Valor Futuro",
            "Interes",
            "Periodos"});
            this.comboBox1.Location = new System.Drawing.Point(404, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 78;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // futurol
            // 
            this.futurol.AutoSize = true;
            this.futurol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.futurol.ForeColor = System.Drawing.Color.White;
            this.futurol.Location = new System.Drawing.Point(268, 226);
            this.futurol.Name = "futurol";
            this.futurol.Size = new System.Drawing.Size(130, 25);
            this.futurol.TabIndex = 80;
            this.futurol.Text = "Valor Futuro";
            // 
            // ValorFuturo
            // 
            this.ValorFuturo.Location = new System.Drawing.Point(405, 231);
            this.ValorFuturo.Name = "ValorFuturo";
            this.ValorFuturo.Size = new System.Drawing.Size(100, 20);
            this.ValorFuturo.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "Elija una Operacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(147, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(398, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 33);
            this.label5.TabIndex = 82;
            this.label5.Text = "Capitalizacion\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(931, 75);
            this.label2.TabIndex = 84;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(573, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 120);
            this.label4.TabIndex = 86;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Capitalizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1043, 573);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.futurol);
            this.Controls.Add(this.ValorFuturo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.periodosl);
            this.Controls.Add(this.Periodos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.presentel);
            this.Controls.Add(this.valorP);
            this.Controls.Add(this.interesl);
            this.Controls.Add(this.Interes);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.calcular);
            this.Name = "Capitalizacion";
            this.Text = "Capitalizacion";
            this.Load += new System.EventHandler(this.Capitalizacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label periodosl;
        private System.Windows.Forms.TextBox Periodos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label presentel;
        private System.Windows.Forms.TextBox valorP;
        private System.Windows.Forms.Label interesl;
        private System.Windows.Forms.TextBox Interes;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label futurol;
        private System.Windows.Forms.TextBox ValorFuturo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}