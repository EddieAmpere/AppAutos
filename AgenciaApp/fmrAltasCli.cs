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
    public partial class fmrAltasCli : Form
    {
        public fmrAltasCli()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmrMenu fmrMenu = new fmrMenu();
            fmrMenu.Show();
            this.Hide();
            fmrAltasCli fmrAltasCli = new fmrAltasCli();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "" || txtTelefono.Text == "0" || txtEdad.Text == "" || txtEdad.Text == "0" || txtDomicilio.Text == "")
            {
                MessageBox.Show("Debe capturar todos los campos", "Capturar campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Conexion datos = new Conexion();
                string nombre, apellido, telefono, domicilio;
                int edad;
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                telefono = txtTelefono.Text;
                domicilio = txtDomicilio.Text;
                edad = Convert.ToInt32(txtEdad.Text);
                datos.altascliente(nombre, apellido, telefono, edad, domicilio);
                MessageBox.Show("Alta exitosa", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtEdad.Text = "";
                txtDomicilio.Text = "";
                txtNombre.Focus();
            }
        }
    }
}
