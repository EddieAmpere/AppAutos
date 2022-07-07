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
    public partial class fmrConsultasCli : Form
    {
        public fmrConsultasCli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmrMenu fmrMenu = new fmrMenu();
            fmrMenu.Show();
            this.Hide();
            fmrConsultasCli fmrConsultasCli = new fmrConsultasCli();
        }

        private void fmrConsultasCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplicacioncarrosDataSet4.V_ConsultaCliente' table. You can move, or remove it, as needed.
            this.v_ConsultaClienteTableAdapter.Fill(this.aplicacioncarrosDataSet4.V_ConsultaCliente);

        }
    }
}
