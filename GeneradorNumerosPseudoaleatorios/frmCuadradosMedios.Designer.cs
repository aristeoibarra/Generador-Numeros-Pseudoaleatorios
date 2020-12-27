namespace GeneradorNumerosPseudoaleatorios
{
    partial class frmCuadradosMedios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuadradosMedios));
            this.dbgDatos = new System.Windows.Forms.DataGridView();
            this.ColN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuadrados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGenerador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCentro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDecimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumRep = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgDatos
            // 
            this.dbgDatos.AllowUserToAddRows = false;
            this.dbgDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dbgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dbgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dbgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColN,
            this.ColCuadrados,
            this.ColGenerador,
            this.ColCentro,
            this.ColDecimal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgDatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dbgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.dbgDatos.Location = new System.Drawing.Point(6, 58);
            this.dbgDatos.Name = "dbgDatos";
            this.dbgDatos.ReadOnly = true;
            this.dbgDatos.Size = new System.Drawing.Size(754, 381);
            this.dbgDatos.TabIndex = 4;
            // 
            // ColN
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColN.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColN.FillWeight = 40.74249F;
            this.ColN.HeaderText = "N";
            this.ColN.Name = "ColN";
            this.ColN.ReadOnly = true;
            // 
            // ColCuadrados
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.ColCuadrados.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCuadrados.FillWeight = 162.2151F;
            this.ColCuadrados.HeaderText = "CUADRADOS";
            this.ColCuadrados.Name = "ColCuadrados";
            this.ColCuadrados.ReadOnly = true;
            // 
            // ColGenerador
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.ColGenerador.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColGenerador.FillWeight = 150.762F;
            this.ColGenerador.HeaderText = "GENERADOR";
            this.ColGenerador.Name = "ColGenerador";
            this.ColGenerador.ReadOnly = true;
            // 
            // ColCentro
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCentro.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColCentro.FillWeight = 162.868F;
            this.ColCentro.HeaderText = "DIGITOS CENTRO";
            this.ColCentro.Name = "ColCentro";
            this.ColCentro.ReadOnly = true;
            // 
            // ColDecimal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDecimal.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColDecimal.FillWeight = 152.2681F;
            this.ColDecimal.HeaderText = "DECIMAL";
            this.ColDecimal.Name = "ColDecimal";
            this.ColDecimal.ReadOnly = true;
            // 
            // txtSemilla
            // 
            this.txtSemilla.BackColor = System.Drawing.SystemColors.Window;
            this.txtSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla.Location = new System.Drawing.Point(96, 9);
            this.txtSemilla.MaxLength = 7;
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(109, 31);
            this.txtSemilla.TabIndex = 1;
            this.txtSemilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemilla_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Semilla :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(230, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "N° Rep :";
            // 
            // txtNumRep
            // 
            this.txtNumRep.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRep.Location = new System.Drawing.Point(308, 9);
            this.txtNumRep.MaxLength = 5;
            this.txtNumRep.Name = "txtNumRep";
            this.txtNumRep.Size = new System.Drawing.Size(88, 31);
            this.txtNumRep.TabIndex = 2;
            this.txtNumRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRep_KeyPress);
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSize = true;
            this.btnGenerar.BackColor = System.Drawing.Color.White;
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerar.Image = global::GeneradorNumerosPseudoaleatorios.Properties.Resources.bus;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(432, 7);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(204, 35);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Numeros";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Location = new System.Drawing.Point(664, 7);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 35);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmCuadradosMedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(766, 451);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtNumRep);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbgDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(782, 490);
            this.Name = "frmCuadradosMedios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método Cuadrados Medios";
            ((System.ComponentModel.ISupportInitialize)(this.dbgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgDatos;
        public System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNumRep;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuadrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGenerador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCentro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDecimal;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

