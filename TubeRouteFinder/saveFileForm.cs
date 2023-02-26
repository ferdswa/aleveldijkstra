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
    public partial class saveFileForm : Form
    {
        public string source, dest;
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            string path = (fileNameBox.Text)+".txt";
            if(!File.Exists(path))//Checks for existing file
            {
                using(StreamWriter save = File.CreateText(path))//Creates and writes to file
                {
                    save.WriteLine(source);
                    save.WriteLine(dest);
                }
            }
            else if(mapScreen.confirmation==true)//Overwrites file
            {
                File.Delete(path);
                using (StreamWriter save = File.CreateText(path))
                {
                    save.WriteLine(source);
                    save.WriteLine(dest);
                }
            }
            else
            {
                errorLabel.Text = "File already exists\nPress again for overwrite";//Prepeares for overwrite
                mapScreen.confirmation = true;
            }
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)//Closes form if user has changed their mind
        {
            this.Hide();
        }

        public saveFileForm()
        {
            InitializeComponent();
        }
    }
}
