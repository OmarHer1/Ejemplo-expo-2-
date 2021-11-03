using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionstatusbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Text = "Ingrese su nombre de usuario o correo electronico";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Text = "Pase el curso por otro elemento";
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Text = "Ingrese su contraseña";
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Text = "Si la olvido busquela donde la guardo";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Text = "Click para iniciar sesión";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Text = "";
        }
    }
}
