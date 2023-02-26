using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TubeRouteFinder
{
    public partial class startScreen : Form
    {
        public static loadFileForm lF = new loadFileForm();
        public static bool hasAFileBeenLoaded = false;
        public startScreen()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            mapScreen mapscreen = new mapScreen();
            mapscreen.Show();
            this.Hide();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            hasAFileBeenLoaded = true;
            lF.Show();
            this.Hide();
        }
    }
}
