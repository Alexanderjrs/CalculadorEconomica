namespace GUI_MODERNISTA
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnCompuestoAvanzado = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCompuestoSimple = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCompuesto = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SubmenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1221, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1180, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1221, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1262, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.button4);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.SubmenuReportes);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.btnsalir);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.panel7);
            this.MenuVertical.Controls.Add(this.btnCompuesto);
            this.MenuVertical.Controls.Add(this.panel6);
            this.MenuVertical.Controls.Add(this.button6);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.btninicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(241, 612);
            this.MenuVertical.TabIndex = 1;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 40);
            this.panel3.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 40);
            this.button4.TabIndex = 20;
            this.button4.Text = "Capitalizacion";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(-1, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 18;
            // 
            // SubmenuReportes
            // 
            this.SubmenuReportes.Controls.Add(this.panel10);
            this.SubmenuReportes.Controls.Add(this.btnCompuestoAvanzado);
            this.SubmenuReportes.Controls.Add(this.panel9);
            this.SubmenuReportes.Controls.Add(this.btnCompuestoSimple);
            this.SubmenuReportes.Location = new System.Drawing.Point(40, 408);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.Size = new System.Drawing.Size(179, 67);
            this.SubmenuReportes.TabIndex = 15;
            this.SubmenuReportes.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(0, 34);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 28);
            this.panel10.TabIndex = 19;
            // 
            // btnCompuestoAvanzado
            // 
            this.btnCompuestoAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCompuestoAvanzado.FlatAppearance.BorderSize = 0;
            this.btnCompuestoAvanzado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCompuestoAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompuestoAvanzado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompuestoAvanzado.ForeColor = System.Drawing.Color.White;
            this.btnCompuestoAvanzado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompuestoAvanzado.Location = new System.Drawing.Point(3, 34);
            this.btnCompuestoAvanzado.Name = "btnCompuestoAvanzado";
            this.btnCompuestoAvanzado.Size = new System.Drawing.Size(176, 28);
            this.btnCompuestoAvanzado.TabIndex = 18;
            this.btnCompuestoAvanzado.Text = "Compuesto Avanzado";
            this.btnCompuestoAvanzado.UseVisualStyleBackColor = false;
            this.btnCompuestoAvanzado.Click += new System.EventHandler(this.btnCompuestoAvanzado_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 28);
            this.panel9.TabIndex = 17;
            // 
            // btnCompuestoSimple
            // 
            this.btnCompuestoSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCompuestoSimple.FlatAppearance.BorderSize = 0;
            this.btnCompuestoSimple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCompuestoSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompuestoSimple.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompuestoSimple.ForeColor = System.Drawing.Color.White;
            this.btnCompuestoSimple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompuestoSimple.Location = new System.Drawing.Point(3, 0);
            this.btnCompuestoSimple.Name = "btnCompuestoSimple";
            this.btnCompuestoSimple.Size = new System.Drawing.Size(176, 28);
            this.btnCompuestoSimple.TabIndex = 16;
            this.btnCompuestoSimple.Text = "Compuesto Simple";
            this.btnCompuestoSimple.UseVisualStyleBackColor = false;
            this.btnCompuestoSimple.Click += new System.EventHandler(this.btnCompuestoSimple_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "TIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 48);
            this.button2.TabIndex = 19;
            this.button2.Text = "Tasa de Interes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(3, 549);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(55, 60);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 16;
            this.btnsalir.TabStop = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 40);
            this.panel1.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(-1, 362);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 40);
            this.panel7.TabIndex = 14;
            // 
            // btnCompuesto
            // 
            this.btnCompuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCompuesto.FlatAppearance.BorderSize = 0;
            this.btnCompuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCompuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompuesto.ForeColor = System.Drawing.Color.White;
            this.btnCompuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnCompuesto.Image")));
            this.btnCompuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompuesto.Location = new System.Drawing.Point(3, 362);
            this.btnCompuesto.Name = "btnCompuesto";
            this.btnCompuesto.Size = new System.Drawing.Size(238, 40);
            this.btnCompuesto.TabIndex = 13;
            this.btnCompuesto.Text = "Interes Compuesto";
            this.btnCompuesto.UseVisualStyleBackColor = false;
            this.btnCompuesto.Click += new System.EventHandler(this.btnCompuesto_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(-1, 316);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 40);
            this.panel6.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(10, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(238, 40);
            this.button6.TabIndex = 11;
            this.button6.Text = "Anualidades";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(-1, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 40);
            this.panel4.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(10, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Interes Simple";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btninicio
            // 
            this.btninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(0, 0);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(220, 102);
            this.btninicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btninicio.TabIndex = 0;
            this.btninicio.TabStop = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(241, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1059, 612);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.SubmenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btninicio;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCompuesto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel SubmenuReportes;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnCompuestoAvanzado;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCompuestoSimple;
        private System.Windows.Forms.PictureBox btnsalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
    }
}

