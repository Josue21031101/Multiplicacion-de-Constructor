using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicacion_de_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Multiplicacion s = new Multiplicacion(double.Parse(n1.Text)
               , double.Parse(n2.Text));

            n3.Text = s.multiplicar().ToString();
        }
    }
}
