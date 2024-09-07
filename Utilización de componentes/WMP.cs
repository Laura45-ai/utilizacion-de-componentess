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
    public partial class WMP : Form
    {
        public WMP()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string videoPath = @"C:\Utilización de componentes\Utilización de componentes\¿Cuál es la diferencia entre Visual Studio y Visual Studio Code_.mp4";
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
