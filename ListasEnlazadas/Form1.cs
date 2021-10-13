using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadas
{
    public partial class Form1 : Form
    {
        ListaSimplementeEnlazada lse = new ListaSimplementeEnlazada();
        public void MostrarPila()
        {
            listView1.Clear();
            Nodo p;
            p = lse.tope;
            while(p != null)
            {
                listView1.Items.Add((p.Informacion).ToString());
                p = p.Enlace;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lse.InsertarPila(Int32.Parse(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
            MostrarPila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lse.EliminarPila();
            MostrarPila();
        }
    }
}
