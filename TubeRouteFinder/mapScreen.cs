using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TubeRouteFinder
{
    public partial class mapScreen : Form
    {
        //Global variables
        static tubeBuild currentTubeBuild = new tubeBuild();
        static int stationNumber = currentTubeBuild.stations.Count();
        static List<List<int>> adjacency = new List<List<int>>(stationNumber);
        public static List<List<int>> distanceList = new List<List<int>>(stationNumber); //Format distanceList[station][neighbor or distance]
        List<CheckBox> stationCheckBoxes = new List<CheckBox>();
        public static bool confirmation = false;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        public mapScreen()
        {
            float factor = screenHeight / 1080;//determines how big user's screen is to the program's native 1080p. Useful for older displays and budget laptops
            SizeF forScaling = new SizeF(factor,factor);
            InitializeComponent();
            this.Scale(forScaling);//Scaling complete

            saveButton.Hide();//Save Route button is hidden until route is calculated.
            createCheckArray(); //Checkbox array for map
            
            for (int i = 0; i < stationNumber; i++)
            {
                adjacency.Add(new List<int>());
                distanceList.Add(new List<int>());
            }

            currentTubeBuild.buildGraph(adjacency);

            if (startScreen.hasAFileBeenLoaded == true)
            {
                if ((startScreen.lF.source.Length > 0) & (startScreen.lF.dest.Length > 0))
                {
                    int sourceStat = currentTubeBuild.getStationID(startScreen.lF.source);
                    int destStat = currentTubeBuild.getStationID(startScreen.lF.dest);
                    sourceField.Text = startScreen.lF.source;
                    destinationField.Text = startScreen.lF.dest;
                    launchDijkstra(sourceStat, destStat);
                }
            }
        }

        private void goButton_Click(object sender, EventArgs e) //Event handler for clicking Go button
        {
            foreach(CheckBox x in stationCheckBoxes) //Resets checkboxes
            {
                x.Checked = false;
            }
            
            exceptionLabel.Text = "";//Resetting exception label (for when program runs > 1 times without shutdown)
            timeEstimateLabel.Text = "";//Same as above but for the estimated time label.
            if (sourceField.TextLength > 0 && sourceField.TextLength > 0)
            {
                try
                {
                    string sourceStationInput = sourceField.Text, destinationStationInput = destinationField.Text; 
                    if (sourceStationInput == destinationStationInput)//No same stations
                    {
                        sameSourceAndDestinationException();
                    }
                    else
                    {

                        int sourceStat = currentTubeBuild.getStationID(sourceStationInput);
                        int destStat = currentTubeBuild.getStationID(destinationStationInput);
                        launchDijkstra(sourceStat, destStat);//Off to Dijkstra
                    }
                }
                catch(IndexOutOfRangeException)//Catches non existent stations
                {
                    nonExistentStationException();
                }
            }
            else
                noStationEnteredException();
        }
        void saveButton_Click(object sender, EventArgs e)//Save a file begins here
        {
            saveFileForm sF = new saveFileForm();
            sF.source = sourceField.Text;
            sF.dest = destinationField.Text;
            sF.Show();
        }
        //Exceptions for different user input errors
        void nonExistentStationException()
        {
            exceptionLabel.Text = "One or both of the stations\nyou have entered do not exist\non this tube map.\nPlease verify.";
        }
        void noStationEnteredException()
        {
            exceptionLabel.Text = "Please enter stations";
        }
        void sameSourceAndDestinationException()
        {
            exceptionLabel.Text = "You have entered the same\nstation twice.\nPlease enter two different stations";
        }
        void nodesUnconnectedException()
        {
            exceptionLabel.Text = "Nodes are unconnected";
        }
    }
}
