namespace GUI_MODERNISTA
{
    partial class TIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TIR));
            this.label1 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaldoInicial = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.laños = new System.Windows.Forms.Label();
            this.años = new System.Windows.Forms.ComboBox();
            this.c3 = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.c4 = new System.Windows.Forms.TextBox();
            this.l4 = new System.Windows.Forms.Label();
            this.c5 = new System.Windows.Forms.TextBox();
            this.l5 = new System.Windows.Forms.Label();
            this.c6 = new System.Windows.Forms.TextBox();
            this.l6 = new System.Windows.Forms.Label();
            this.c7 = new System.Windows.Forms.TextBox();
            this.l7 = new System.Windows.Forms.Label();
            this.c8 = new System.Windows.Forms.TextBox();
            this.l8 = new System.Windows.Forms.Label();
            this.c9 = new System.Windows.Forms.TextBox();
            this.l9 = new System.Windows.Forms.Label();
            this.c10 = new System.Windows.Forms.TextBox();
            this.l10 = new System.Windows.Forms.Label();
            this.c11 = new System.Windows.Forms.TextBox();
            this.l11 = new System.Windows.Forms.Label();
            this.c12 = new System.Windows.Forms.TextBox();
            this.l12 = new System.Windows.Forms.Label();
            this.ldes = new System.Windows.Forms.Label();
            this.descuento = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(158, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "La TIR es una medida de referencia del tipo de interés mínimo que debe dar una \r\n" +
    "determinada inversión para ser rentable. \r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(404, 258);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(100, 20);
            this.c1.TabIndex = 50;
            this.c1.TextChanged += new System.EventHandler(this.Retiro_TextChanged);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(297, 253);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(77, 25);
            this.l1.TabIndex = 49;
            this.l1.Text = "Flujo 1";
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(628, 259);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(100, 20);
            this.c2.TabIndex = 48;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l2.ForeColor = System.Drawing.Color.White;
            this.l2.Location = new System.Drawing.Point(521, 254);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(77, 25);
            this.l2.TabIndex = 47;
            this.l2.Text = "Flujo 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(370, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Saldo Inicial";
            // 
            // SaldoInicial
            // 
            this.SaldoInicial.Location = new System.Drawing.Point(520, 138);
            this.SaldoInicial.Name = "SaldoInicial";
            this.SaldoInicial.Size = new System.Drawing.Size(100, 20);
            this.SaldoInicial.TabIndex = 45;
            this.SaldoInicial.TextChanged += new System.EventHandler(this.Dias_TextChanged);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.SeaGreen;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.limpiar.ForeColor = System.Drawing.Color.White;
            this.limpiar.Location = new System.Drawing.Point(597, 420);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(98, 36);
            this.limpiar.TabIndex = 44;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.SeaGreen;
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calcular.ForeColor = System.Drawing.Color.White;
            this.calcular.Location = new System.Drawing.Point(375, 420);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(98, 36);
            this.calcular.TabIndex = 43;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = ":";
            // 
            // laños
            // 
            this.laños.AutoSize = true;
            this.laños.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.laños.ForeColor = System.Drawing.Color.White;
            this.laños.Location = new System.Drawing.Point(437, 187);
            this.laños.Name = "laños";
            this.laños.Size = new System.Drawing.Size(61, 25);
            this.laños.TabIndex = 53;
            this.laños.Text = "Años";
            // 
            // años
            // 
            this.años.FormattingEnabled = true;
            this.años.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.años.Location = new System.Drawing.Point(520, 191);
            this.años.Name = "años";
            this.años.Size = new System.Drawing.Size(100, 21);
            this.años.TabIndex = 54;
            this.años.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(404, 284);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(100, 20);
            this.c3.TabIndex = 58;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l3.ForeColor = System.Drawing.Color.White;
            this.l3.Location = new System.Drawing.Point(297, 279);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(77, 25);
            this.l3.TabIndex = 57;
            this.l3.Text = "Flujo 3";
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(628, 284);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(100, 20);
            this.c4.TabIndex = 56;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l4.ForeColor = System.Drawing.Color.White;
            this.l4.Location = new System.Drawing.Point(521, 279);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(77, 25);
            this.l4.TabIndex = 55;
            this.l4.Text = "Flujo 4";
            // 
            // c5
            // 
            this.c5.Location = new System.Drawing.Point(404, 309);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(100, 20);
            this.c5.TabIndex = 62;
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l5.ForeColor = System.Drawing.Color.White;
            this.l5.Location = new System.Drawing.Point(297, 304);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(77, 25);
            this.l5.TabIndex = 61;
            this.l5.Text = "Flujo 5";
            // 
            // c6
            // 
            this.c6.Location = new System.Drawing.Point(628, 308);
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(100, 20);
            this.c6.TabIndex = 60;
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l6.ForeColor = System.Drawing.Color.White;
            this.l6.Location = new System.Drawing.Point(521, 303);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(77, 25);
            this.l6.TabIndex = 59;
            this.l6.Text = "Flujo 6";
            // 
            // c7
            // 
            this.c7.Location = new System.Drawing.Point(404, 334);
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(100, 20);
            this.c7.TabIndex = 66;
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l7.ForeColor = System.Drawing.Color.White;
            this.l7.Location = new System.Drawing.Point(297, 329);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(77, 25);
            this.l7.TabIndex = 65;
            this.l7.Text = "Flujo 7";
            // 
            // c8
            // 
            this.c8.Location = new System.Drawing.Point(628, 333);
            this.c8.Name = "c8";
            this.c8.Size = new System.Drawing.Size(100, 20);
            this.c8.TabIndex = 64;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l8.ForeColor = System.Drawing.Color.White;
            this.l8.Location = new System.Drawing.Point(521, 328);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(77, 25);
            this.l8.TabIndex = 63;
            this.l8.Text = "Flujo 8";
            // 
            // c9
            // 
            this.c9.Location = new System.Drawing.Point(404, 360);
            this.c9.Name = "c9";
            this.c9.Size = new System.Drawing.Size(100, 20);
            this.c9.TabIndex = 70;
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l9.ForeColor = System.Drawing.Color.White;
            this.l9.Location = new System.Drawing.Point(297, 355);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(77, 25);
            this.l9.TabIndex = 69;
            this.l9.Text = "Flujo 9";
            // 
            // c10
            // 
            this.c10.Location = new System.Drawing.Point(628, 359);
            this.c10.Name = "c10";
            this.c10.Size = new System.Drawing.Size(100, 20);
            this.c10.TabIndex = 68;
            // 
            // l10
            // 
            this.l10.AutoSize = true;
            this.l10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l10.ForeColor = System.Drawing.Color.White;
            this.l10.Location = new System.Drawing.Point(521, 353);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(89, 25);
            this.l10.TabIndex = 67;
            this.l10.Text = "Flujo 10";
            // 
            // c11
            // 
            this.c11.Location = new System.Drawing.Point(404, 385);
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(100, 20);
            this.c11.TabIndex = 74;
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l11.ForeColor = System.Drawing.Color.White;
            this.l11.Location = new System.Drawing.Point(297, 380);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(89, 25);
            this.l11.TabIndex = 73;
            this.l11.Text = "Flujo 11";
            // 
            // c12
            // 
            this.c12.Location = new System.Drawing.Point(628, 385);
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(100, 20);
            this.c12.TabIndex = 72;
            // 
            // l12
            // 
            this.l12.AutoSize = true;
            this.l12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.l12.ForeColor = System.Drawing.Color.White;
            this.l12.Location = new System.Drawing.Point(521, 380);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(89, 25);
            this.l12.TabIndex = 71;
            this.l12.Text = "Flujo 12";
            // 
            // ldes
            // 
            this.ldes.AutoSize = true;
            this.ldes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.ldes.ForeColor = System.Drawing.Color.White;
            this.ldes.Location = new System.Drawing.Point(383, 213);
            this.ldes.Name = "ldes";
            this.ldes.Size = new System.Drawing.Size(115, 25);
            this.ldes.TabIndex = 75;
            this.ldes.Text = "Descuento";
            // 
            // descuento
            // 
            this.descuento.Location = new System.Drawing.Point(520, 218);
            this.descuento.Name = "descuento";
            this.descuento.Size = new System.Drawing.Size(100, 20);
            this.descuento.TabIndex = 76;
            this.descuento.TextChanged += new System.EventHandler(this.descuento_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "VAN",
            "TIR"});
            this.comboBox2.Location = new System.Drawing.Point(520, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 77;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(313, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "Tipo de operacion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.resultado);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(284, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 66);
            this.panel1.TabIndex = 79;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultado.ForeColor = System.Drawing.Color.White;
            this.resultado.Location = new System.Drawing.Point(3, 17);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(86, 20);
            this.resultado.TabIndex = 12;
            this.resultado.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(482, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 33);
            this.label4.TabIndex = 80;
            this.label4.Text = "TIR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(655, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 100);
            this.label6.TabIndex = 81;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // TIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1043, 573);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.descuento);
            this.Controls.Add(this.ldes);
            this.Controls.Add(this.c11);
            this.Controls.Add(this.l11);
            this.Controls.Add(this.c12);
            this.Controls.Add(this.l12);
            this.Controls.Add(this.c9);
            this.Controls.Add(this.l9);
            this.Controls.Add(this.c10);
            this.Controls.Add(this.l10);
            this.Controls.Add(this.c7);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.c8);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.c6);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.años);
            this.Controls.Add(this.laños);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaldoInicial);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label1);
            this.Name = "TIR";
            this.Text = "TIR";
            this.Load += new System.EventHandler(this.TIR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SaldoInicial;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laños;
        private System.Windows.Forms.ComboBox años;
        private System.Windows.Forms.TextBox c3;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox c4;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox c5;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.TextBox c6;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox c7;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.TextBox c8;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.TextBox c9;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.TextBox c10;
        private System.Windows.Forms.Label l10;
        private System.Windows.Forms.TextBox c11;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.TextBox c12;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.Label ldes;
        private System.Windows.Forms.TextBox descuento;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}