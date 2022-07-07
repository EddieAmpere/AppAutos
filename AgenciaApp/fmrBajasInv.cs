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
    public partial class fmrBajasInv : Form
    {
        public fmrBajasInv()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            fmrMenu fmrMenu = new fmrMenu();
            fmrMenu.Show();
            this.Hide();
            fmrBajasInv fmrBajasInv = new fmrBajasInv();
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
                Resp = MessageBox.Show("Desea darlo de baja", "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resp == DialogResult.Yes)
                {
                    Conexion valor = new Conexion();
                    int IdVehiculo;
                    IdVehiculo = Convert.ToInt32(txtIdVehiculo.Text);
                    try
                    {
                        valor.Bajas(IdVehiculo);
                        MessageBox.Show("Se ha dado de baja", "Baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("No se realizo la baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        limpiarcuadros();
                    }
                }
            }
        }
    }
}


 

