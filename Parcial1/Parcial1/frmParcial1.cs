using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class frmParcial1 : Form
    {
        public frmParcial1()
        {
            InitializeComponent();
        }

        #region Metodos Custom

        private void Mensage(String texto)
        {
            MessageBox.Show(texto);
        }
        private void Limpiar()
        {
            this.txtSalario.Text = string.Empty;
            this.txtHorasL.Text = string.Empty;
            this.txtRcargo1.Text = string.Empty;
            this.txtRecargo2.Text = string.Empty;
            this.txtBonifi.Text = string.Empty;
            this.txtPocReten.Text = string.Empty;
            this.txtSalario.Focus();
            this.grbACalculo.Visible = false;
        }


        #endregion

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Mensage("Programa finalizado con éxito");
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
    }
}
