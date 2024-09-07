//Laura Cristina Colorado Sánchez
//Utilización de componentes
//6.09.24

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilización_de_componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WMP WMP = new WMP();
            WMP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDF PDF = new PDF();
            PDF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IE IE = new IE();
            IE.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
