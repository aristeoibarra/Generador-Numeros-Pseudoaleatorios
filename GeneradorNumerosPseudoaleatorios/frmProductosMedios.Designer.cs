namespace GeneradorNumerosPseudoaleatorios
{
    partial class frmProductosMedios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosMedios));
            this.dbgDatos = new System.Windows.Forms.DataGridView();
            this.ColN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCentro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtSemilla1 = new System.Windows.Forms.TextBox();
            this.txtSemilla2 = new System.Windows.Forms.TextBox();
            this.txtNumRep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.ColX0,
            this.ColX1,
            this.ColY0,
            this.ColLargo,
            this.ColCentro,
            this.ColRi});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgDatos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dbgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.dbgDatos.Location = new System.Drawing.Point(6, 81);
            this.dbgDatos.Name = "dbgDatos";
            this.dbgDatos.ReadOnly = true;
            this.dbgDatos.RowHeadersWidth = 25;
            this.dbgDatos.Size = new System.Drawing.Size(844, 364);
            this.dbgDatos.TabIndex = 5;
            // 
            // ColN
            // 
            this.ColN.FillWeight = 61.21967F;
            this.ColN.HeaderText = "N";
            this.ColN.Name = "ColN";
            this.ColN.ReadOnly = true;
            // 
            // ColX0
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.ColX0.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColX0.FillWeight = 121.2011F;
            this.ColX0.HeaderText = "X0";
            this.ColX0.Name = "ColX0";
            this.ColX0.ReadOnly = true;
            // 
            // ColX1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.ColX1.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColX1.FillWeight = 116.9484F;
            this.ColX1.HeaderText = "X1";
            this.ColX1.Name = "ColX1";
            this.ColX1.ReadOnly = true;
            // 
            // ColY0
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColY0.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColY0.FillWeight = 176.4174F;
            this.ColY0.HeaderText = "Y0 = X0 * Y0";
            this.ColY0.Name = "ColY0";
            this.ColY0.ReadOnly = true;
            // 
            // ColLargo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColLargo.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColLargo.FillWeight = 102.4061F;
            this.ColLargo.HeaderText = "LARGO";
            this.ColLargo.Name = "ColLargo";
            this.ColLargo.ReadOnly = true;
            // 
            // ColCentro
            // 
            this.ColCentro.FillWeight = 123.0513F;
            this.ColCentro.HeaderText = "CENTRO";
            this.ColCentro.Name = "ColCentro";
            this.ColCentro.ReadOnly = true;
            // 
            // ColRi
            // 
            this.ColRi.FillWeight = 167.6117F;
            this.ColRi.HeaderText = "RI";
            this.ColRi.Name = "ColRi";
            this.ColRi.ReadOnly = true;
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
            this.btnGenerar.Location = new System.Drawing.Point(501, 28);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(204, 35);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Numeros";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtSemilla1
            // 
            this.txtSemilla1.BackColor = System.Drawing.SystemColors.Window;
            this.txtSemilla1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla1.Location = new System.Drawing.Point(55, 32);
            this.txtSemilla1.MaxLength = 7;
            this.txtSemilla1.Name = "txtSemilla1";
            this.txtSemilla1.Size = new System.Drawing.Size(97, 31);
            this.txtSemilla1.TabIndex = 1;
            this.txtSemilla1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemilla1_KeyPress);
            // 
            // txtSemilla2
            // 
            this.txtSemilla2.BackColor = System.Drawing.SystemColors.Window;
            this.txtSemilla2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla2.Location = new System.Drawing.Point(203, 32);
            this.txtSemilla2.MaxLength = 7;
            this.txtSemilla2.Name = "txtSemilla2";
            this.txtSemilla2.Size = new System.Drawing.Size(97, 31);
            this.txtSemilla2.TabIndex = 2;
            this.txtSemilla2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemilla2_KeyPress);
            // 
            // txtNumRep
            // 
            this.txtNumRep.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRep.Location = new System.Drawing.Point(351, 32);
            this.txtNumRep.MaxLength = 5;
            this.txtNumRep.Name = "txtNumRep";
            this.txtNumRep.Size = new System.Drawing.Size(88, 31);
            this.txtNumRep.TabIndex = 3;
            this.txtNumRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRep_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(199, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "Semilla 2 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(51, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 63;
            this.label6.Text = "Semilla 1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(347, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = "N° Rep :";
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
            this.btnLimpiar.Location = new System.Drawing.Point(732, 28);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 35);
            this.btnLimpiar.TabIndex = 72;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmProductosMedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumRep);
            this.Controls.Add(this.txtSemilla2);
            this.Controls.Add(this.txtSemilla1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dbgDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(792, 489);
            this.Name = "frmProductosMedios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método de Productos Medios";
            ((System.ComponentModel.ISupportInitialize)(this.dbgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dbgDatos;
        private System.Windows.Forms.Button btnGenerar;
        public System.Windows.Forms.TextBox txtSemilla1;
        public System.Windows.Forms.TextBox txtSemilla2;
        public System.Windows.Forms.TextBox txtNumRep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX0;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY0;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCentro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRi;
        private System.Windows.Forms.Button btnLimpiar;
    }
}