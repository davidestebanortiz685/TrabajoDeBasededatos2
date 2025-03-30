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
    public partial class Form1 : Form
    {
        /*Crear una Instancia de la clase ManipulaBD*/
        ManipulaBD obj1M = new ManipulaBD();
        string param,proc;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proc = "InsertarClientes";
            param = "" + Int64.Parse(textBox1.Text)+ ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'";
            obj1M.ManipularBD(proc, param);
            proc = "ConsultarClientesPorID";
            param = "" + textBox1 + "";
            obj1M.ConsultarBD(proc, param);
            dataGridView1.DataSource= obj1M.dt.Tables["objeto1"];

        }

        private void button2_Click(object sender, EventArgs e)
        {

            proc = "EliminarClientesID";
            param = "" + textBox1.Text + "";
            obj1M.ManipularBD(proc, param);
            proc = "ConsultarClientesALL";
            param = "";
            obj1M.ConsultarBD(proc, param);
            dataGridView1.DataSource = obj1M.dt.Tables["objeto1"];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            proc = "ModificarClientes";
            param = "" + Int64.Parse(textBox1.Text) + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'";
            obj1M.ManipularBD(proc, param);
            proc = "ConsultarClientesPorID";
            param = "" + textBox1 + "";
            obj1M.ConsultarBD(proc, param);
            dataGridView1.DataSource = obj1M.dt.Tables["objeto1"];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            proc = "ConsultarClientesPorID";
            param = "" + textBox1.Text + "";
            obj1M.ConsultarBD(proc, param);

            dataGridView1.DataSource = obj1M.dt.Tables["objeto1"];

            textBox1.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[0].ToString();
            textBox2.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[1].ToString();
            textBox3.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[2].ToString();
            textBox4.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[3].ToString();
            textBox5.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[4].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            proc = "ConsultarClientesALL";
            param = "";
            obj1M.ConsultarBD(proc, param);
            dataGridView1.DataSource = obj1M.dt.Tables["objeto1"];

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
