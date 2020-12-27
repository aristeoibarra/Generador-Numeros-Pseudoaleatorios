using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorNumerosPseudoaleatorios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCuadradosMedios_Click(object sender, EventArgs e)
        {
            frmCuadradosMedios abrir = new frmCuadradosMedios();
            this.Hide();
            abrir.ShowDialog();
            this.Show();
        }

        private void btnProductoMedio_Click(object sender, EventArgs e)
        {
            frmProductosMedios abrir = new frmProductosMedios();
            this.Hide();
            abrir.ShowDialog();
            this.Show();
        }

        private void btnCongruencialMixto_Click(object sender, EventArgs e)
        {
            frmCongruencialMixto abrir = new frmCongruencialMixto();
            this.Hide();
            abrir.ShowDialog();
            this.Show();
        }
    }
}
