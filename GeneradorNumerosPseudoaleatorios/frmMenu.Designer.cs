namespace GeneradorNumerosPseudoaleatorios
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnCuadradosMedios = new System.Windows.Forms.Button();
            this.btnProductoMedio = new System.Windows.Forms.Button();
            this.btnCongruencialMixto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCuadradosMedios
            // 
            this.btnCuadradosMedios.AutoSize = true;
            this.btnCuadradosMedios.BackColor = System.Drawing.Color.White;
            this.btnCuadradosMedios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCuadradosMedios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuadradosMedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadradosMedios.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadradosMedios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCuadradosMedios.Location = new System.Drawing.Point(57, 46);
            this.btnCuadradosMedios.Name = "btnCuadradosMedios";
            this.btnCuadradosMedios.Size = new System.Drawing.Size(316, 35);
            this.btnCuadradosMedios.TabIndex = 1;
            this.btnCuadradosMedios.Text = "MÉTODO DE CUADRADOS MEDIOS";
            this.btnCuadradosMedios.UseVisualStyleBackColor = false;
            this.btnCuadradosMedios.Click += new System.EventHandler(this.btnCuadradosMedios_Click);
            // 
            // btnProductoMedio
            // 
            this.btnProductoMedio.AutoSize = true;
            this.btnProductoMedio.BackColor = System.Drawing.Color.White;
            this.btnProductoMedio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProductoMedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoMedio.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProductoMedio.Location = new System.Drawing.Point(57, 107);
            this.btnProductoMedio.Name = "btnProductoMedio";
            this.btnProductoMedio.Size = new System.Drawing.Size(316, 35);
            this.btnProductoMedio.TabIndex = 2;
            this.btnProductoMedio.Text = "MÉTODO DE PRODUCTO MEDIO";
            this.btnProductoMedio.UseVisualStyleBackColor = false;
            this.btnProductoMedio.Click += new System.EventHandler(this.btnProductoMedio_Click);
            // 
            // btnCongruencialMixto
            // 
            this.btnCongruencialMixto.AutoSize = true;
            this.btnCongruencialMixto.BackColor = System.Drawing.Color.White;
            this.btnCongruencialMixto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCongruencialMixto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCongruencialMixto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongruencialMixto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongruencialMixto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCongruencialMixto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongruencialMixto.Location = new System.Drawing.Point(57, 165);
            this.btnCongruencialMixto.Name = "btnCongruencialMixto";
            this.btnCongruencialMixto.Size = new System.Drawing.Size(316, 35);
            this.btnCongruencialMixto.TabIndex = 3;
            this.btnCongruencialMixto.Text = "MÉTODO CONGRUENCIAL MIXTO";
            this.btnCongruencialMixto.UseVisualStyleBackColor = false;
            this.btnCongruencialMixto.Click += new System.EventHandler(this.btnCongruencialMixto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 66;
            this.label6.Text = "Aristeo Ibarra ";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeneradorNumerosPseudoaleatorios.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 287);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCongruencialMixto);
            this.Controls.Add(this.btnProductoMedio);
            this.Controls.Add(this.btnCuadradosMedios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(478, 326);
            this.MinimumSize = new System.Drawing.Size(478, 326);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCuadradosMedios;
        private System.Windows.Forms.Button btnProductoMedio;
        private System.Windows.Forms.Button btnCongruencialMixto;
        private System.Windows.Forms.Label label6;
    }
}