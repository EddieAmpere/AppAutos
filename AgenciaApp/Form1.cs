using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgenciaApp
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-O8B72AR;Initial Catalog=aplicacioncarros;Integrated Security=True";


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENTDataSet.login' table. You can move, or remove it, as needed.  
            //this.loginTableAdapter.Fill(this.sTUDENTDataSet.login);  
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O8B72AR;Initial Catalog=aplicacioncarros;Integrated Security=True");
            con.Open();

            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-O8B72AR;Initial Catalog=aplicacioncarros;Integrated Security=True";
            con.Open();
            string usuario = textBox1.Text;
            string password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select LoginID,Password from Login where LoginID='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Successfuly logged into the database");
                fmrMenu fmrMenu = new fmrMenu();
                fmrMenu.Show();
                this.Hide();
                Form1 form1 = new Form1();


            }
            else
            {
                MessageBox.Show("Username or password entered is not correct");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Resp;
            Resp = MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
