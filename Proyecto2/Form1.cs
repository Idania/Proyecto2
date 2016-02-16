using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        ClassControl C1 = new ClassControl();

        private void button1_Click(object sender, EventArgs e)
        {
           

            C1.nom = textBox1.Text;
            C1.CrearArchivo();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string me = textBox2.Text;
            C1.AgregarDatos(ref me);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C1.Mostrar(listBox1);
        }
        }
}
