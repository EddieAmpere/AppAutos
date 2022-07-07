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
    public partial class fmrConsultasInv : Form
    {
        public fmrConsultasInv()
        {
            InitializeComponent();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            Conexion datos = new Conexion();
            DataTable dt;
            dt = datos.Consulta();
            dataGridView1.DataSource = dt;

        }

private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fmrConsultasInv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplicacioncarrosDataSet2.V_ConsultaInventario' table. You can move, or remove it, as needed.
            this.v_ConsultaInventarioTableAdapter1.Fill(this.aplicacioncarrosDataSet2.V_ConsultaInventario);
            // TODO: This line of code loads data into the 'aplicacioncarrosDataSet1.V_ConsultaInventario' table. You can move, or remove it, as needed.
            this.v_ConsultaInventarioTableAdapter.Fill(this.aplicacioncarrosDataSet1.V_ConsultaInventario);
            // TODO: This line of code loads data into the 'aplicacioncarrosDataSet.inventario' table. You can move, or remove it, as needed.
            this.inventarioTableAdapter.Fill(this.aplicacioncarrosDataSet.inventario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmrMenu fmrMenu = new fmrMenu();
            fmrMenu.Show();
            this.Hide();
            fmrConsultasInv fmrConsultasInv = new fmrConsultasInv();
        }
    }
}
