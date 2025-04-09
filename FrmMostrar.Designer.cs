namespace PryPueblox
{
    partial class FrmMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrar));
            this.Grlm1 = new System.Windows.Forms.DataGridView();
            this.BtnMostrarSegun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.GrlM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grlm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrlM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grlm1
            // 
            this.Grlm1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(211)))), ((int)(((byte)(168)))));
            this.Grlm1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grlm1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grlm1.Location = new System.Drawing.Point(19, 193);
            this.Grlm1.Margin = new System.Windows.Forms.Padding(6);
            this.Grlm1.Name = "Grlm1";
            this.Grlm1.Size = new System.Drawing.Size(382, 296);
            this.Grlm1.TabIndex = 44;
            // 
            // BtnMostrarSegun
            // 
            this.BtnMostrarSegun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(211)))), ((int)(((byte)(168)))));
            this.BtnMostrarSegun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarSegun.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarSegun.Location = new System.Drawing.Point(449, 76);
            this.BtnMostrarSegun.Margin = new System.Windows.Forms.Padding(6);
            this.BtnMostrarSegun.Name = "BtnMostrarSegun";
            this.BtnMostrarSegun.Size = new System.Drawing.Size(162, 52);
            this.BtnMostrarSegun.TabIndex = 43;
            this.BtnMostrarSegun.Text = "Mostrar Todo";
            this.BtnMostrarSegun.UseVisualStyleBackColor = false;
            this.BtnMostrarSegun.Click += new System.EventHandler(this.BtnMostrarSegun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(211)))), ((int)(((byte)(168)))));
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mostrar Según";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(19, 81);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(401, 47);
            this.CmbCategoria.TabIndex = 41;
            this.CmbCategoria.SelectedIndexChanged += new System.EventHandler(this.CmbCategoria_SelectedIndexChanged);
            // 
            // GrlM
            // 
            this.GrlM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(211)))), ((int)(((byte)(168)))));
            this.GrlM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrlM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GrlM.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GrlM.Location = new System.Drawing.Point(19, 193);
            this.GrlM.Margin = new System.Windows.Forms.Padding(6);
            this.GrlM.Name = "GrlM";
            this.GrlM.Size = new System.Drawing.Size(382, 296);
            this.GrlM.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdCategoria";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(211)))), ((int)(((byte)(168)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(27, 519);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(143, 50);
            this.BtnVolver.TabIndex = 39;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryPueblox.Properties.Resources.f861b851_0d67_4392_bb42_a3bf670a6ecf;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1387, 1063);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 796);
            this.Controls.Add(this.Grlm1);
            this.Controls.Add(this.BtnMostrarSegun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbCategoria);
            this.Controls.Add(this.GrlM);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grlm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrlM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grlm1;
        private System.Windows.Forms.Button BtnMostrarSegun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.DataGridView GrlM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}