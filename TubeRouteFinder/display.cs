using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubeRouteFinder
{
    partial class mapScreen// Once again split to separate parts of class with different functions
    {
        void displayResult(List<int> stationIDArray, int estimatedTime)
        {
            
           
            foreach(int i in stationIDArray)
            {
                stationCheckBoxes[i].Checked = true;
            }

            timeEstimateLabel.Text = "Estimated Time:\n" + estimatedTime + " minutes.";
            saveButton.Show();
        }
        void createCheckArray()//Creates a list of all checkboxes present on map
        {
            foreach(CheckBox checkBox in this.Controls.OfType<CheckBox>())
            {
                stationCheckBoxes.Add(checkBox);
            }
            stationCheckBoxes.Reverse(); //By default the list is backwards with stationCheckBoxes[0] = checkBox301. This makes it the right way round.
        }
        
    }
}
