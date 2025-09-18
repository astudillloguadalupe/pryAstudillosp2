using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAstudilloCabaña
{
    public partial class frmRegistroCabañas : Form
    {
        public frmRegistroCabañas()
        {
            InitializeComponent();
        }


        private void LimpiarControles()
        {
            txtNombre.Clear();
            mtbTelefono.Clear();
            cmbTipo.SelectedIndex = -1;
            cmbPersonas.SelectedIndex = -1;
            cmbDías.SelectedIndex = -1;
        }
            





        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar el registro?", "Cancelar",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                LimpiarControles(); 
            }
        }

        private void lblPersonas_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistroCabañas_Load(object sender, EventArgs e)
        {

        }

        private void cmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

            {

            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void mtbTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbTelefono.TextLength > 0)
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }
    }
}
