namespace Calculadora
{
    partial class CompuestoSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompuestoSimple));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MC = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.i = new System.Windows.Forms.TextBox();
            this.semestral = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Tiempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(322, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Monto Compuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(369, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Capital Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(378, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tasa Interes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MC
            // 
            this.MC.Location = new System.Drawing.Point(527, 320);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(100, 20);
            this.MC.TabIndex = 14;
            this.MC.TextChanged += new System.EventHandler(this.MC_TextChanged);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(527, 350);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 20);
            this.C.TabIndex = 15;
            this.C.TextChanged += new System.EventHandler(this.C_TextChanged);
            // 
            // i
            // 
            this.i.Location = new System.Drawing.Point(527, 376);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(100, 20);
            this.i.TabIndex = 16;
            this.i.TextChanged += new System.EventHandler(this.i_TextChanged);
            // 
            // semestral
            // 
            this.semestral.AutoSize = true;
            this.semestral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.semestral.ForeColor = System.Drawing.Color.White;
            this.semestral.Location = new System.Drawing.Point(3, 21);
            this.semestral.Name = "semestral";
            this.semestral.Size = new System.Drawing.Size(115, 25);
            this.semestral.TabIndex = 18;
            this.semestral.Text = "Resultado:";
            this.semestral.Click += new System.EventHandler(this.semestral_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(396, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monto Compuesto",
            "Tiempo",
            "Tasa de Interes",
            "Capital Inicial"});
            this.comboBox1.Location = new System.Drawing.Point(478, 279);
            this.comboBox1.MaxLength = 50;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Tiempo
            // 
            this.Tiempo.Location = new System.Drawing.Point(527, 403);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(100, 20);
            this.Tiempo.TabIndex = 20;
            this.Tiempo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(426, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tiempo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(555, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(322, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "Calcular Compuesto Simple";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(222, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(731, 175);
            this.label6.TabIndex = 25;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(283, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "Tipo de Operacion\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.semestral);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(227, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 71);
            this.panel1.TabIndex = 52;
            // 
            // CompuestoSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1059, 612);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.i);
            this.Controls.Add(this.C);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompuestoSimple";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MC;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox i;
        private System.Windows.Forms.Label semestral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Tiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}