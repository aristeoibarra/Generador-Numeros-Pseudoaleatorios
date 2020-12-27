using System;
using System.Windows.Forms;

namespace GeneradorNumerosPseudoaleatorios
{
    public partial class frmCuadradosMedios : Form
    {
        public frmCuadradosMedios()
        {
            InitializeComponent();
        }
        /*   ---------Algoritmo---------
          1. Seleccionar semilla (X0) con D dígitos (D > 3).
          2. Sea X0 = resultado de elevar X0 al cuadrado; 
             sea X1 = los D dígitos del centro, y sea ri = 0.D dígitos del centro.
          3. Sea Yi = resultado de elevar Xi al cuadrado; sea Xi+1 = los D dígitos del centro,
             y sea ri = 0.D dígitos del centro para toda i = 1, 2, 3,..., n.
          4. Repetir el paso 3 hasta obtener los n números ri deseados.

          Nota: Si no es posible obtener los D dígitos del centro del número Yi,
          agregue ceros a la izquierda del número Yi.
          Generalmente este algoritmo es incapaz de generar una secuencia de ri con periodo de vida n grande.  
        */

        int N = 0;
        decimal generador;
        string semillaTexto, generadorTexto, digitosCentro;

        void Limpiar()
        {
            txtSemilla.Focus();
            dbgDatos.Rows.Clear();
            txtSemilla.Clear();
            txtNumRep.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if ((txtSemilla.Text == string.Empty && txtSemilla.Focus())
               || (txtNumRep.Text == string.Empty && txtNumRep.Focus()))
            {
                MessageBox.Show("Debe Completar la Información", "Campos Vacios!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dbgDatos.Rows.Clear();
                semillaTexto = txtSemilla.Text;
                N = (int)Convert.ToInt64(txtNumRep.Text);

                if (semillaTexto.Length > 3)
                {
                    MetodoCuadradosMedios(semillaTexto, N);
                }
                else
                {
                    MessageBox.Show("Seleccionar semilla (X0) con D dígitos (D > 3)", "Aviso!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void MetodoCuadradosMedios(string semillaTexto, int N)
        {
            for (int i = 0; i < N; i++)
            {
                int tamSemilla, tamGenerador;
                uint indexGen;

                tamSemilla = semillaTexto.Length;
                generador = (decimal)Math.Pow(Convert.ToDouble(semillaTexto), 2);

                generadorTexto = generador.ToString();
                tamGenerador = generadorTexto.Length;

                indexGen = (uint)((tamGenerador - tamSemilla) / 2);
                digitosCentro = generadorTexto.Substring((int)indexGen, tamSemilla);

                decimal digitosCentroDouble = decimal.Parse(digitosCentro);
                if (digitosCentroDouble == 0 || VerificarExiste(decimal.Parse("." + digitosCentro)))
                {
                    MessageBox.Show($"La semilla: {txtSemilla.Text} solo tiene: {i} iteracion(s)", "Aviso!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    AgregarDatos(semillaTexto, i);
                    semillaTexto = digitosCentro;
                }
            }
        }

        private bool VerificarExiste(decimal numAlea)
        {
            bool existe = false;
            foreach (DataGridViewRow row in dbgDatos.Rows)
            {
                if (Convert.ToDecimal(row.Cells["ColDecimal"].Value) == numAlea)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        private void AgregarDatos(string semillaTexto, int i)
        {
            int n = dbgDatos.Rows.Add();
            dbgDatos.Rows[n].Cells[0].Value = i;
            dbgDatos.Rows[n].Cells[1].Value = semillaTexto;
            dbgDatos.Rows[n].Cells[2].Value = generador;
            dbgDatos.Rows[n].Cells[3].Value = digitosCentro;
            dbgDatos.Rows[n].Cells[4].Value = decimal.Parse("." + digitosCentro);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtSemilla_KeyPress(object sender, KeyPressEventArgs e)
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
