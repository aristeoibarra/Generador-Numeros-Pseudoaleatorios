using System;
using System.Windows.Forms;

namespace GeneradorNumerosPseudoaleatorios
{
    public partial class frmCongruencialMixto : Form
    {
        public frmCongruencialMixto()
        {
            InitializeComponent();
        }
        int N = 0;
        string semilla;
        decimal X0, A, C, M;

        void Limpiar()
        {
            txtA.Focus();
            dbgDatos.Rows.Clear();
            txtSemilla.Clear();
            txtA.Clear();
            txtC.Clear();
            txtM.Clear();
            txtNumRep.Clear();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Llamar la función validar

            if (ValidarTextBoxVacio(txtSemilla) || ValidarTextBoxVacio(txtA)
                || ValidarTextBoxVacio(txtC) || ValidarTextBoxVacio(txtM) || ValidarTextBoxVacio(txtNumRep))
            {
                MessageBox.Show("Debe Completar la Información", "Campos Vacios!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dbgDatos.Rows.Clear();
                semilla = txtSemilla.Text;
                X0 = decimal.Parse(semilla);
                A = decimal.Parse(txtA.Text);
                C = decimal.Parse(txtC.Text);
                M = decimal.Parse(txtM.Text);
                N = int.Parse(txtNumRep.Text);

                // M > Semilla, A,C
                if ((M > X0 && M > A && M > C) && (X0 > 0 && A > 0 && C > 0))
                {                
                    MetodoCongruencialMixto();
                }
                else
                {
                    MessageBox.Show("Seleccionar M > X0, A, C\n\n" +
                                    "Seleccionar X0, A, C > 0", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MetodoCongruencialMixto()
        {
            for (int i = 0; i < N; i++)
            {
                // (A * X0 + C) mod M
                decimal subtotal = (A * X0) + C;
                decimal residuo = subtotal % M;
                float numAleatorio = (float)(residuo / M);

                if (VerificarExiste(numAleatorio))
                {
                    MessageBox.Show($"La semilla: {txtSemilla.Text} solo tiene: {i} iteracion(s)", "Aviso!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    int n = dbgDatos.Rows.Add();
                    dbgDatos.Rows[n].Cells[0].Value = i;
                    dbgDatos.Rows[n].Cells[1].Value = X0;
                    dbgDatos.Rows[n].Cells[2].Value = A;
                    dbgDatos.Rows[n].Cells[3].Value = C;
                    dbgDatos.Rows[n].Cells[4].Value = M;
                    dbgDatos.Rows[n].Cells[5].Value = subtotal;
                    dbgDatos.Rows[n].Cells[6].Value = residuo;
                    dbgDatos.Rows[n].Cells[7].Value = numAleatorio;

                    X0 = residuo;
                }           
            }
        }

        private bool ValidarTextBoxVacio(TextBox textBox)
        {
            bool vacio;
            if(textBox.Text == string.Empty)
                 vacio = true;        
            else       
                vacio = false;
            return vacio;          
        }

        private bool VerificarExiste(float numAlea)
        {
            bool existe = false;
            foreach (DataGridViewRow row in dbgDatos.Rows)
            {
                if (Convert.ToSingle(row.Cells["ColDecimal"].Value) == numAlea)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        private void txtSemilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }

        private void txtNumRep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }
    }
}
