namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btRestaurar = new System.Windows.Forms.PictureBox();
            this.btMinimizar = new System.Windows.Forms.PictureBox();
            this.btMaximizar = new System.Windows.Forms.PictureBox();
            this.btCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.subMenuReportes = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Reportes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Empleados = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Compras = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Clientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ventas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Productos = new System.Windows.Forms.Button();
            this.panelCont = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panel8.SuspendLayout();
            this.subMenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Peru;
            this.BarraTitulo.Controls.Add(this.btRestaurar);
            this.BarraTitulo.Controls.Add(this.btMinimizar);
            this.BarraTitulo.Controls.Add(this.btMaximizar);
            this.BarraTitulo.Controls.Add(this.btCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(800, 35);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btRestaurar
            // 
            this.btRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btRestaurar.Image")));
            this.btRestaurar.Location = new System.Drawing.Point(732, 4);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btRestaurar.TabIndex = 3;
            this.btRestaurar.TabStop = false;
            this.btRestaurar.Visible = false;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btMinimizar.Image")));
            this.btMinimizar.Location = new System.Drawing.Point(701, 4);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMinimizar.TabIndex = 2;
            this.btMinimizar.TabStop = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btMaximizar
            // 
            this.btMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btMaximizar.Image")));
            this.btMaximizar.Location = new System.Drawing.Point(732, 4);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMaximizar.TabIndex = 1;
            this.btMaximizar.TabStop = false;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btCerrar.Image")));
            this.btCerrar.Location = new System.Drawing.Point(763, 4);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(25, 25);
            this.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCerrar.TabIndex = 0;
            this.btCerrar.TabStop = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Tan;
            this.panelContenedor.Controls.Add(this.panel8);
            this.panelContenedor.Controls.Add(this.panel7);
            this.panelContenedor.Controls.Add(this.Reportes);
            this.panelContenedor.Controls.Add(this.panel5);
            this.panelContenedor.Controls.Add(this.panel4);
            this.panelContenedor.Controls.Add(this.Empleados);
            this.panelContenedor.Controls.Add(this.panel3);
            this.panelContenedor.Controls.Add(this.Compras);
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Controls.Add(this.Clientes);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.Ventas);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Controls.Add(this.Productos);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(200, 415);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.subMenuReportes);
            this.panel8.Location = new System.Drawing.Point(60, 328);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(140, 84);
            this.panel8.TabIndex = 0;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // subMenuReportes
            // 
            this.subMenuReportes.BackColor = System.Drawing.Color.Tan;
            this.subMenuReportes.Controls.Add(this.panel9);
            this.subMenuReportes.Controls.Add(this.button1);
            this.subMenuReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subMenuReportes.Location = new System.Drawing.Point(0, 0);
            this.subMenuReportes.Name = "subMenuReportes";
            this.subMenuReportes.Size = new System.Drawing.Size(140, 84);
            this.subMenuReportes.TabIndex = 6;
            this.subMenuReportes.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Peru;
            this.panel9.Location = new System.Drawing.Point(0, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 28);
            this.panel9.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Peru;
            this.panel7.Location = new System.Drawing.Point(0, 290);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 32);
            this.panel7.TabIndex = 5;
            // 
            // Reportes
            // 
            this.Reportes.FlatAppearance.BorderSize = 0;
            this.Reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Reportes.Location = new System.Drawing.Point(3, 290);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(197, 32);
            this.Reportes.TabIndex = 6;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Peru;
            this.panel5.Location = new System.Drawing.Point(0, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Peru;
            this.panel4.Location = new System.Drawing.Point(0, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 5;
            // 
            // Empleados
            // 
            this.Empleados.FlatAppearance.BorderSize = 0;
            this.Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleados.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Empleados.Location = new System.Drawing.Point(3, 252);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(197, 32);
            this.Empleados.TabIndex = 6;
            this.Empleados.Text = "Empleados";
            this.Empleados.UseVisualStyleBackColor = true;
            this.Empleados.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Peru;
            this.panel3.Location = new System.Drawing.Point(0, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 5;
            // 
            // Compras
            // 
            this.Compras.FlatAppearance.BorderSize = 0;
            this.Compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compras.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Compras.Location = new System.Drawing.Point(3, 214);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(197, 32);
            this.Compras.TabIndex = 6;
            this.Compras.Text = "Compras";
            this.Compras.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 5;
            // 
            // Clientes
            // 
            this.Clientes.FlatAppearance.BorderSize = 0;
            this.Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Clientes.Location = new System.Drawing.Point(3, 176);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(197, 32);
            this.Clientes.TabIndex = 6;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Ventas
            // 
            this.Ventas.FlatAppearance.BorderSize = 0;
            this.Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ventas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ventas.Location = new System.Drawing.Point(3, 138);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(197, 32);
            this.Ventas.TabIndex = 6;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Productos
            // 
            this.Productos.BackColor = System.Drawing.Color.Tan;
            this.Productos.FlatAppearance.BorderSize = 0;
            this.Productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Productos.Location = new System.Drawing.Point(3, 100);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(197, 32);
            this.Productos.TabIndex = 4;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = false;
            this.Productos.Click += new System.EventHandler(this.btProductos_Click);
            // 
            // panelCont
            // 
            this.panelCont.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCont.Location = new System.Drawing.Point(200, 35);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(600, 415);
            this.panelCont.TabIndex = 1;
            this.panelCont.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCont_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCont);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.subMenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btMinimizar;
        private System.Windows.Forms.PictureBox btMaximizar;
        private System.Windows.Forms.PictureBox btCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.PictureBox btRestaurar;
        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Empleados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Compras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Ventas;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Reportes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel subMenuReportes;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;
    }
}

