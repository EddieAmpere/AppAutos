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
    public partial class fmrCambiosCli : Form
    {
        public fmrCambiosCli()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmrMenu fmrMenu = new fmrMenu();
            fmrMenu.Show();
            this.Hide();
            fmrCambiosCli fmrCambiosCli = new fmrCambiosCli();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (txtIdCliente.Text == "" || txtIdCliente.Text == "0")
                {
                    MessageBox.Show("Debe capturar un número ID válido", "Capturar clave ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Conexion datos = new Conexion();
                    DataTable dt = new DataTable();
                    int IdCliente;
                    IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    try
                    {
                        dt = datos.BuscarCliente(IdCliente);
                        txtNombre.Text = dt.Rows[0][1].ToString();
                        txtApellido.Text = dt.Rows[0][2].ToString();
                        txtTelefono.Text = dt.Rows[0][3].ToString();
                        txtEdad.Text = dt.Rows[0][4].ToString();
                        txtDomicilio.Text = dt.Rows[0][5].ToString();

                    }
                    catch
                    {
                        MessageBox.Show("Cliente no existe", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarcuadros();
                    }
                }
            }
        }
        public void limpiarcuadros()
        {
            txtIdCliente.Text = "0";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "0";
            txtDomicilio.Text = "0";
            txtIdCliente.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "" || txtNombre.Text == "0" || txtApellido.Text == "" || txtTelefono.Text == "" || txtTelefono.Text == "0" || txtEdad.Text == "" || txtEdad.Text == "0" || txtDomicilio.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult Resp;
                Resp = MessageBox.Show("Desea realizar los cambios?", "Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resp == DialogResult.Yes)
                {
                    int IdCliente, edad;
                    string nombre, apellido, telefono, domicilio;
                    Conexion datos = new Conexion();
                    IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    nombre = txtNombre.Text;
                    apellido = txtApellido.Text;
                    telefono = txtTelefono.Text;
                    edad = Convert.ToInt32(txtEdad.Text);
                    domicilio = txtDomicilio.Text;
                    datos.CambiosCliente(IdCliente, nombre, apellido, telefono, edad, domicilio);
                    MessageBox.Show("Se han cambiado los datos", "Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarcuadros();
                }
            }
        }
    }
}

