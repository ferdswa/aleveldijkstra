using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubeRouteFinder
{
    public partial class loadFileForm : Form
    {
        startScreen start = new startScreen();
        public string source = string.Empty, dest;
        public loadFileForm()
        {
            InitializeComponent();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            
            string fileName = fileNameBox.Text;
            try
            {
                using (StreamReader sr = new StreamReader(fileName + ".txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrEmpty(source))
                        {
                            source = line;
                        }
                        else
                        {
                            dest = line;
                        }
                    }
                    sr.Close();
                }
                mapScreen mapScreen = new mapScreen();
                mapScreen.Show();
                this.Hide();
            }
            catch(Exception)
            {
                fileNotFoundLabel.Text = "File Not Found\ntry again or cancel.";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            startScreen.hasAFileBeenLoaded = false;
            start.Show();
            this.Hide();
        }
    }
}
