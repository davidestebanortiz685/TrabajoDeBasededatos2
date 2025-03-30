using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploprocedimientolenguaje
{
    public partial class Form2 : Form
    {
        ManipulaBD obj1M = new ManipulaBD();
        string param, proc;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            proc = "ValidarUsuario";
            param = "'" + textBox1.Text + "'," + textBox2.Text + "";
            obj1M.ConsultarBD(proc,param);
            if (obj1M.dt.Tables["objeto1"].Rows.Count == 0 )
            {
                MessageBox.Show("Usuario No Valido");
            }
            else
            {
                MessageBox.Show("usuario  valido");
                Form1 f1 = new Form1();
                f1.Show();
            }
        }
    }
}
