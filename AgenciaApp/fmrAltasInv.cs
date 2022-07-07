using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaApp
{
    public partial class fmrAltasInv : Form
    {
        public fmrAltasInv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "" || txtMarca.Text == "" || txtColor.Text == "" || txtAño.Text == "" || txtPrecio.Text == "" || txtKilometraje.Text == "" || txtTransmisión.Text == "")
            {
                MessageBox.Show("Debe capturar todos los campos", "Capturar campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Conexion datos = new Conexion();
                string modelo, marca, color, transmision;
                int año, precio, kilometraje;
                modelo = txtModelo.Text;
                marca = txtMarca.Text;
                color = txtColor.Text;
                transmision = txtTransmisión.Text;
                año = Convert.ToInt32(txtAño.Text);
                precio = Convert.ToInt32(txtPrecio.Text);
                kilometraje = Convert.ToInt32(txtKilometraje.Text);
                datos.altas(modelo, marca, color, año, precio, kilometraje, transmision);
                MessageBox.Show("Alta exitosa", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtModelo.Text = "";
                txtMarca.Text = "";
                txtColor.Text = "";
                txtTransmisión.Text = "";
                txtAño.Text = "";
                txtPrecio.Text = "";
                txtKilometraje.Text = "";
                txtModelo.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmrMenu fmrMenu = new fmrMenu();
            fmrMenu.Show();
            this.Hide();
            fmrAltasInv fmrAltasInv = new fmrAltasInv();
        }
    }
}
