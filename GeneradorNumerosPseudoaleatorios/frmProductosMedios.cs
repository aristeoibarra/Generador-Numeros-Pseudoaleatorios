using System;
using System.Windows.Forms;

namespace GeneradorNumerosPseudoaleatorios
{
    public partial class frmProductosMedios : Form
    {
        public frmProductosMedios()
        {
            InitializeComponent();
        }

        int N = 0;
        string semilla1, semilla2, digitosCentro;

        void Limpiar()
        {
            txtSemilla1.Focus();
            dbgDatos.Rows.Clear();
            txtSemilla1.Clear();
            txtSemilla2.Clear();
            txtNumRep.Clear();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if ((txtSemilla1.Text == string.Empty && txtSemilla1.Focus()) || (txtSemilla2.Text == string.Empty && txtSemilla2.Focus()) || (txtNumRep.Text == string.Empty && txtNumRep.Focus()))
            {
                MessageBox.Show("Debe Completar la Información", "Campos Vacios!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dbgDatos.Rows.Clear();
                semilla1 = txtSemilla1.Text; //X0 = "2795";
                semilla2 = txtSemilla2.Text; // X1 = 1895; 
                N = Convert.ToInt32(txtNumRep.Text);

                if (semilla1.Length != semilla2.Length)
                {
                    MessageBox.Show("El tamaño de las semillas debe ser el mismo", "Aviso!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (semilla1.Length > 3 && semilla2.Length > 3)
                {
                    MetodoProductosMedios(semilla1, semilla2, N);
                }
                else
                {
                    MessageBox.Show("Seleccionar semilla (X0) con D dígitos (D > 3) \n\n" +
                        "Seleccionar semilla (X1) con D dígitos (D > 3)", "Aviso!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MetodoProductosMedios(string semilla1, string semilla2, int N)
        {
            for (int i = 0; i < N; i++)
            {
                int tamSemilla = semilla1.Length;   // 4

                decimal generador = Convert.ToDecimal(semilla1) * Convert.ToDecimal(semilla2); // Y0 = 5296525;
                string generadorTexto = generador.ToString(); // Y0Texto = "5296525";
                int largo = generadorTexto.Length; // 7            0123456

                uint indexGen = (uint)((largo - tamSemilla) / 2); // (7 -4) / 2 = 1
                digitosCentro = generadorTexto.Substring((int)indexGen, tamSemilla); // centro = "2965"

                decimal digitosCentroDouble = decimal.Parse(digitosCentro);
                if (digitosCentroDouble == 0 || VerificarExiste(decimal.Parse("." + digitosCentro)))
                {
                    MessageBox.Show($"Las semillas: {txtSemilla1.Text} y {txtSemilla2.Text} " +
                        $"solo tienen: {i} iteracion(s)", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    AgregarDatos(i, semilla1, semilla2, generadorTexto, largo);

                    semilla1 = semilla2;
                    semilla2 = digitosCentro;
                }
            }
        }

        private bool VerificarExiste(decimal numAlea)
        {
            bool existe = false;
            foreach (DataGridViewRow row in dbgDatos.Rows)
            {
                if (Convert.ToDecimal(row.Cells["ColRi"].Value) == numAlea)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        private void AgregarDatos(int i, string semilla1, string semilla2, string generadorTexto, int largo)
        {
            int n = dbgDatos.Rows.Add();
            dbgDatos.Rows[n].Cells[0].Value = i;
            dbgDatos.Rows[n].Cells[1].Value = semilla1;
            dbgDatos.Rows[n].Cells[2].Value = semilla2;
            dbgDatos.Rows[n].Cells[3].Value = generadorTexto;
            dbgDatos.Rows[n].Cells[4].Value = largo;
            dbgDatos.Rows[n].Cells[5].Value = digitosCentro;
            dbgDatos.Rows[n].Cells[6].Value = double.Parse("." + digitosCentro);
        }

        private void txtSemilla1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtSemilla2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }

        private void txtNumRep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }
    }
}
