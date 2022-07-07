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
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrConsultasInv fmrConsultasInv = new fmrConsultasInv();
            fmrConsultasInv.Show();
            this.Hide();
            fmrMenu fmrMenu = new fmrMenu();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrAltasInv fmrAltasInv = new fmrAltasInv();
            fmrAltasInv.Show();
            this.Hide();
            fmrMenu fmrMenu = new fmrMenu();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resp;
            Resp = MessageBox.Show("Desea desconectarse?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resp == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                fmrMenu fmrMenu = new fmrMenu();
            }
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrBajasInv fmrBajasInv = new fmrBajasInv();
            fmrBajasInv.Show();
            this.Hide();
            fmrMenu fmrMenu = new fmrMenu();
        }

        private void cambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCambiosInv fmrCambiosInv = new fmrCambiosInv();
            fmrCambiosInv.Show();
            this.Hide();
            fmrMenu fmrMenu = new fmrMenu();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmrConsultasCli fmrConsultasCli = new fmrConsultasCli();
            fmrConsultasCli.Show();
            this.Hide();
            Form1 form1 = new Form1();
        }

        private void altasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmrAltasCli fmrAltasCli = new fmrAltasCli();
            fmrAltasCli.Show();
            this.Hide();
            Form1 form1 = new Form1();
        }

        private void bajasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmrBajasCli fmrBajasCli = new fmrBajasCli();
            fmrBajasCli.Show();
            this.Hide();
            fmrMenu fmrMenu = new fmrMenu();
        }

        private void cambiosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmrCambiosCli fmrCambiosCli = new fmrCambiosCli();
            fmrCambiosCli.Show();
            this.Hide();
            fmrMenu fmrMenu = new fmrMenu();
        }
    }
}
