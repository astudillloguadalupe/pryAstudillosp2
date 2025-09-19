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
            cmbTipo.SelectedIndex = 0;
            cmbPersonas.SelectedIndex = 0;
            cmbDías.SelectedIndex = 0;
            for (int i = 0; i < chkAdicionales.Items.Count; i++)
            {
                chkAdicionales.SetItemChecked(i, false);
            }
            optEfectivo.Checked = true;
            optTarjeta.Checked = false;
            cmbTarjetas.Enabled = false;
            txtNombre.Clear();
            mtbTelefono.Clear();
            btnRegistrar.Enabled = false;
            cmbTipo.Focus();
            lstRegistro.Items.Clear();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar el registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarControles();
            }
        }

        private void lblPersonas_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistroCabañas_Load(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0;
            cmbPersonas.SelectedIndex = 0;
            cmbDías.SelectedIndex = 0;
            optEfectivo.Checked = true;
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

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked != false)
            {
                cmbTarjetas.Enabled = true;

            }
            else
            {
                cmbTarjetas.Enabled = false;
                cmbTarjetas.SelectedIndex = -1;
            }
        }

        private void cmbDías_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDías.SelectedIndex <= 0)
            {
                btnRegistrar.Enabled = false;

            }
            else
            {
                btnRegistrar.Enabled = true;

            }
        }
        private void CalcularTotal()
        {
            int MaxPersonas = 0;
            int PrecioBase = 0;
            int Personas = Convert.ToInt32(cmbPersonas.SelectedItem);
            Decimal PrecioDia = 0;
            string Adicionales = "";

            if (cmbTipo.SelectedItem.ToString().Contains("A"))
            {
                PrecioBase = 20;
                MaxPersonas = 4;
            }
            else if (cmbTipo.SelectedItem.ToString().Contains("B"))
            {
                PrecioBase = 34;
                MaxPersonas = 8;
            }
            if (Personas > MaxPersonas)
            {
                MessageBox.Show("La cabaña tipo " + cmbTipo.SelectedItem +
                    " solo puede alojar a " + MaxPersonas + " personas como máximo.");
                return;


            }
            PrecioDia = PrecioBase + Personas;

            for (int i = 0; i < chkAdicionales.Items.Count; i++)
            {
                if (chkAdicionales.GetItemChecked(i))
                {
                    Adicionales = Adicionales + chkAdicionales.Items[i].ToString();

                    if (Adicionales.Contains("Cocina"))
                    {
                        PrecioDia += 1m;
                    }
                    else if (Adicionales.Contains("Heladera"))
                    {
                        PrecioDia = 1.5m;
                    }
                    else if (Adicionales.Contains("Televisor"))
                    {
                        PrecioDia += 2m;
                    }

                }
            }
            int Dias = Convert.ToInt32(cmbDías.SelectedItem);
            Decimal PrecioTotal = PrecioDia * Dias;
            String Recargo = "";
            String FormaPago = "Efectivo";

            if (optEfectivo.Checked)
            {
                FormaPago = "Efectivo";
                PrecioTotal = PrecioTotal + 0;
                Recargo = "Sin Recargo";
            }

            if (optTarjeta.Checked)
            {
                FormaPago = cmbTarjetas.SelectedItem.ToString();

                if (FormaPago == "Card Blue")
                {
                    PrecioTotal = PrecioTotal * 1.20m;
                    Recargo = "20%";

                }
                else if (FormaPago == "Card Green")
                {
                    PrecioTotal = PrecioTotal * 1.20m;
                    Recargo = "20%";
                }
                else if (FormaPago == "Card Red")
                {
                    PrecioTotal = PrecioTotal * 1.10M;
                    Recargo = "10%";
                }


            }
            lstRegistro.Items.Add("Nombre:" + " " + txtNombre.Text);
            lstRegistro.Items.Add("Télefono: " + " " + mtbTelefono.Text);
            lstRegistro.Items.Add("Tipo de Cabaña: " + cmbTipo.SelectedItem);
            lstRegistro.Items.Add("Personas: " + cmbPersonas.SelectedItem);
            lstRegistro.Items.Add("Días: " + cmbDías.SelectedItem);
            lstRegistro.Items.Add("Adicionales: " + Adicionales);
            lstRegistro.Items.Add("Forma de pago: " + FormaPago);
            lstRegistro.Items.Add("Recargo: " + Recargo);
            lstRegistro.Items.Add("Precio diario: U$S " + PrecioDia);
            lstRegistro.Items.Add("Precio total: U$S " + PrecioTotal);


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CalcularTotal();    
        }
    }
}

