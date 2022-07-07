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
    public partial class fmrCambiosInv : Form
    {
        public fmrCambiosInv()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdVehiculo.Text == "" || txtIdVehiculo.Text == "0" || txtModelo.Text == "" || txtMarca.Text == "" || txtColor.Text == "" || txtAño.Text == "" || txtAño.Text == "0" || txtPrecio.Text == "" || txtPrecio.Text == "0" || txtKilometraje.Text == "" || txtTransmisión.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult Resp;
                Resp = MessageBox.Show("Desea realizar los cambios?", "Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resp == DialogResult.Yes)
                {
                    int IdVehiculo, año, precio, kilometraje;
                    string modelo, marca, color, transmisión;
                    Conexion datos = new Conexion();
                    IdVehiculo = Convert.ToInt32(txtIdVehiculo.Text);
                    año = Convert.ToInt32(txtAño.Text);
                    precio = Convert.ToInt32(txtPrecio.Text);
                    kilometraje = Convert.ToInt32(txtKilometraje.Text);
                    modelo = txtModelo.Text;
                    marca = txtMarca.Text;
                    color = txtColor.Text;
                    transmisión = txtTransmisión.Text;
                    datos.Cambios(IdVehiculo, modelo, marca, color, año, precio, kilometraje, transmisión);
                    MessageBox.Show("Se han cambiado los datos", "Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarcuadros();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fmrMenu fmrMenu = new fmrMenu();
            fmrMenu.Show();
            this.Hide();
            fmrConsultasInv fmrConsultasInv = new fmrConsultasInv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIdVehiculo.Text == "" || txtIdVehiculo.Text == "0")
            {
                MessageBox.Show("Debe capturar un número ID válido", "Capturar clave ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Conexion datos = new Conexion();
                DataTable dt = new DataTable();
                int IdVehiculo;
                IdVehiculo = Convert.ToInt32(txtIdVehiculo.Text);
                try
                {
                    dt = datos.Buscar(IdVehiculo);
                    txtModelo.Text = dt.Rows[0][1].ToString();
                    txtMarca.Text = dt.Rows[0][2].ToString();
                    txtColor.Text = dt.Rows[0][3].ToString();
                    txtAño.Text = dt.Rows[0][4].ToString();
                    txtPrecio.Text = dt.Rows[0][5].ToString();
                    txtKilometraje.Text = dt.Rows[0][6].ToString();
                    txtTransmisión.Text = dt.Rows[0][7].ToString();
                }
                catch
                {
                    MessageBox.Show("Vehiculo no existe", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarcuadros();
                }
            }
        }



        public void limpiarcuadros()
        {
            txtIdVehiculo.Text = "0";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtColor.Text = "";
            txtAño.Text = "0";
            txtPrecio.Text = "0";
            txtKilometraje.Text = "0";
            txtTransmisión.Text = "";
            txtIdVehiculo.Focus();
        }
    }
}
