namespace GUI_MODERNISTA
{
    partial class Tasa_de_Interes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasa_de_Interes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.capital = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valorF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.resultado);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(244, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 71);
            this.panel1.TabIndex = 65;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Capital";
            // 
            // capital
            // 
            this.capital.Location = new System.Drawing.Point(485, 208);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(100, 20);
            this.capital.TabIndex = 61;
            this.capital.TextChanged += new System.EventHandler(this.capital_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(499, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 56;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(369, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 55;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tiempo
            // 
            this.tiempo.Location = new System.Drawing.Point(485, 234);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(100, 20);
            this.tiempo.TabIndex = 57;
            this.tiempo.TextChanged += new System.EventHandler(this.tiempo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(387, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(355, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "Valor Final";
            // 
            // valorF
            // 
            this.valorF.Location = new System.Drawing.Point(485, 260);
            this.valorF.Name = "valorF";
            this.valorF.Size = new System.Drawing.Size(100, 20);
            this.valorF.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(75, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(891, 75);
            this.label7.TabIndex = 69;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(386, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 33);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tasa de interes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(669, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 175);
            this.label5.TabIndex = 82;
            this.label5.Text = "Formula 1            Formula 2\r\nI = Vf - C              i = I / C * t\r\n\r\nDonde:\r\n" +
    "I = Interes             i = Tasa de interes\r\nC = Capital           t = Tiempo\r\nV" +
    "f = Valor final\r\n";
            // 
            // Tasa_de_Interes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1043, 573);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valorF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.capital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Tasa_de_Interes";
            this.Text = "Tasa_de_Interes";
            this.Load += new System.EventHandler(this.Tasa_de_Interes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capital;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}