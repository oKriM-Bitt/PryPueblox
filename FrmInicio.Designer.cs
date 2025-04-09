namespace PryPueblox
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPlatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarPlatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarYSeleccionarMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryPueblox.Properties.Resources.f861b851_0d67_4392_bb42_a3bf670a6ecf;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarPlatosToolStripMenuItem,
            this.revisarPlatosToolStripMenuItem,
            this.cargarYSeleccionarMesaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cargarPlatosToolStripMenuItem
            // 
            this.cargarPlatosToolStripMenuItem.Name = "cargarPlatosToolStripMenuItem";
            this.cargarPlatosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cargarPlatosToolStripMenuItem.Text = "Cargar  Platos";
            this.cargarPlatosToolStripMenuItem.Click += new System.EventHandler(this.cargarPlatosToolStripMenuItem_Click);
            // 
            // revisarPlatosToolStripMenuItem
            // 
            this.revisarPlatosToolStripMenuItem.Name = "revisarPlatosToolStripMenuItem";
            this.revisarPlatosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.revisarPlatosToolStripMenuItem.Text = "Revisar Platos";
            this.revisarPlatosToolStripMenuItem.Click += new System.EventHandler(this.revisarPlatosToolStripMenuItem_Click);
            // 
            // cargarYSeleccionarMesaToolStripMenuItem
            // 
            this.cargarYSeleccionarMesaToolStripMenuItem.Name = "cargarYSeleccionarMesaToolStripMenuItem";
            this.cargarYSeleccionarMesaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cargarYSeleccionarMesaToolStripMenuItem.Text = "Cargar y Seleccionar mesa";
            this.cargarYSeleccionarMesaToolStripMenuItem.Click += new System.EventHandler(this.cargarYSeleccionarMesaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPlatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarPlatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarYSeleccionarMesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

