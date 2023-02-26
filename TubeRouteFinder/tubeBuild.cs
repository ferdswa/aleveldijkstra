using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TubeRouteFinder
{
    class tubeBuild
    {
        static void addEdge(List<List<int>> adj, int i, int j, int k)
        {
            //bidirectional
            //Stores edges in adjacency list
            adj[i].Add(j);
            adj[j].Add(i);

            //Stores distances between source & neighbor in separate distances list.
            mapScreen.distanceList[i].Add(j); mapScreen.distanceList[i].Add(k);
            mapScreen.distanceList[j].Add(i); mapScreen.distanceList[j].Add(k);
            // i= station, j = station, k = time between stations in minutes
        }
        public void buildGraph(List<List<int>> adjStations)//Constructs graph and stores it in adjacency list.
        {
            //The variables are : adjacency list, source station, neighbor, time between statios
            //A
            addEdge(adjStations, 0, 72, 2); addEdge(adjStations, 0, 229, 3); addEdge(adjStations, 0, 263, 3); addEdge(adjStations, 0, 51, 2);
            addEdge(adjStations, 1, 155, 2); addEdge(adjStations, 1, 261, 4);
            addEdge(adjStations, 2, 261, 2); addEdge(adjStations, 2, 294, 2); addEdge(adjStations, 2, 155, 4);
            addEdge(adjStations, 3, 69, 2); addEdge(adjStations, 3, 199, 2);
            addEdge(adjStations, 4, 192, 2); addEdge(adjStations, 4, 250, 3);
            addEdge(adjStations, 5, 45, 4);
            addEdge(adjStations, 6, 143, 2); addEdge(adjStations, 6, 187, 3);
            addEdge(adjStations, 7, 123, 2); addEdge(adjStations, 7, 262, 1);
            addEdge(adjStations, 8, 30, 3); addEdge(adjStations, 8, 238, 3);
            addEdge(adjStations, 9, 94, 1); addEdge(adjStations, 9, 127, 2);
            //#A
            //B
            addEdge(adjStations, 10, 162, 1); addEdge(adjStations, 10, 210, 1); addEdge(adjStations, 10, 82, 3); addEdge(adjStations, 10, 241, 4); addEdge(adjStations, 10, 103, 3); addEdge(adjStations, 10, 27, 2); addEdge(adjStations, 10, 93, 6);
            addEdge(adjStations, 11, 55, 2); addEdge(adjStations, 11, 255, 1);
            addEdge(adjStations, 12, 155, 2); addEdge(adjStations, 12, 242, 2); addEdge(adjStations, 12, 223, 2); addEdge(adjStations, 12, 156, 2); addEdge(adjStations, 12, 167, 3); addEdge(adjStations, 12, 277, 4);
            addEdge(adjStations, 13, 91, 1); addEdge(adjStations, 13, 167, 2);
            addEdge(adjStations, 14, 76, 2); addEdge(adjStations, 14, 267, 4);
            addEdge(adjStations, 15, 90, 2); addEdge(adjStations, 15, 174, 2);
            addEdge(adjStations, 16, 109, 2); addEdge(adjStations, 16, 288, 2); addEdge(adjStations, 16, 73, 3);
            addEdge(adjStations, 17, 185, 2); addEdge(adjStations, 17, 191, 2);
            addEdge(adjStations, 18, 96, 4);
            addEdge(adjStations, 19, 64, 2); addEdge(adjStations, 19, 215, 3);
            addEdge(adjStations, 20, 66, 3); addEdge(adjStations, 20, 267, 2);
            addEdge(adjStations, 21, 46, 2); addEdge(adjStations, 21, 110, 2);
            addEdge(adjStations, 22, 40, 2); addEdge(adjStations, 22, 156, 3);
            addEdge(adjStations, 23, 155, 3); addEdge(adjStations, 23, 163, 2);
            addEdge(adjStations, 24, 160, 1); addEdge(adjStations, 24, 253, 2);
            addEdge(adjStations, 25, 258, 2); addEdge(adjStations, 25, 272, 2);
            addEdge(adjStations, 26, 77, 3); addEdge(adjStations, 26, 199, 3);
            addEdge(adjStations, 27, 161, 1); addEdge(adjStations, 27, 190, 1); addEdge(adjStations, 27, 104, 2);
            addEdge(adjStations, 28, 83, 1); addEdge(adjStations, 28, 156, 2);
            addEdge(adjStations, 29, 180, 2); addEdge(adjStations, 29, 188, 3);
            addEdge(adjStations, 30, 299, 2);
            addEdge(adjStations, 31, 69, 1); addEdge(adjStations, 31, 202, 1);
            addEdge(adjStations, 32, 35, 2); addEdge(adjStations, 32, 163, 1);
            addEdge(adjStations, 33, 99, 3); addEdge(adjStations, 33, 118, 2);
            addEdge(adjStations, 34, 246, 2);
            addEdge(adjStations, 35, 284, 2);
            addEdge(adjStations, 36, 157, 3); addEdge(adjStations, 36, 300, 3);
            addEdge(adjStations, 37, 57, 2); addEdge(adjStations, 37, 80, 3);
            //#B
            //C
            addEdge(adjStations, 38, 127, 2); addEdge(adjStations, 38, 143, 5);
            addEdge(adjStations, 39, 46, 2); addEdge(adjStations, 39, 88, 3); addEdge(adjStations, 39, 138, 2); addEdge(adjStations, 39, 169, 1);
            addEdge(adjStations, 40, 214, 1); addEdge(adjStations, 40, 251, 2); addEdge(adjStations, 40, 41, 3);
            addEdge(adjStations, 41, 119, 1); addEdge(adjStations, 41, 287, 2); addEdge(adjStations, 41, 177, 3);
            addEdge(adjStations, 42, 77, 2); addEdge(adjStations, 42, 217, 3); addEdge(adjStations, 42, 177, 3); addEdge(adjStations, 42, 284, 3);
            addEdge(adjStations, 43, 160, 1); addEdge(adjStations, 43, 165, 2);
            addEdge(adjStations, 44, 205, 2); addEdge(adjStations, 44, 244, 2);
            addEdge(adjStations, 45, 49, 8); addEdge(adjStations, 45, 52, 4);
            //addEdge(adjStations, 46, x); Just here to keep count - all neighbours of 46 already counted
            addEdge(adjStations, 47, 125, 1); addEdge(adjStations, 47, 242, 2);
            addEdge(adjStations, 48, 86, 1); addEdge(adjStations, 48, 195, 2); addEdge(adjStations, 48, 150, 2);
            //addEdge(adjStations, 49, x); All 49 neighbors have been counted
            addEdge(adjStations, 50, 102, 2); addEdge(adjStations, 50, 213, 2);
            addEdge(adjStations, 51, 263, 2);
            addEdge(adjStations, 52, 212, 4);
            addEdge(adjStations, 53, 54, 2); addEdge(adjStations, 53, 55, 2);
            addEdge(adjStations, 54, 246, 1);
            //55
            addEdge(adjStations, 56, 186, 4);
            addEdge(adjStations, 57, 118, 2);
            addEdge(adjStations, 58, 235, 2); addEdge(adjStations, 58, 256, 2);
            addEdge(adjStations, 59, 125, 1); addEdge(adjStations, 59, 150, 1);
            addEdge(adjStations, 60, 170, 1); addEdge(adjStations, 60, 233, 1);
            addEdge(adjStations, 61, 166, 4); addEdge(adjStations, 61, 278, 3);
            addEdge(adjStations, 62, 201, 1); addEdge(adjStations, 62, 217, 1);
            addEdge(adjStations, 63, 106, 1); addEdge(adjStations, 63, 134, 1);
            addEdge(adjStations, 64, 96, 1);
            //#C
            //D
            addEdge(adjStations, 65, 66, 4); addEdge(adjStations, 65, 84, 3);
            //66
            addEdge(adjStations, 67, 157, 2); addEdge(adjStations, 67, 254, 3);
            addEdge(adjStations, 68, 85, 1); addEdge(adjStations, 68, 106, 2);
            //69
            addEdge(adjStations, 70, 171, 2); addEdge(adjStations, 70, 295, 2);
            //#D
            //E
            addEdge(adjStations, 71, 72, 4); addEdge(adjStations, 71, 281, 3);
            addEdge(adjStations, 72, 176, 3);
            addEdge(adjStations, 73, 98, 3); addEdge(adjStations, 73, 121, 3); addEdge(adjStations, 73, 137, 3); addEdge(adjStations, 73, 282, 2); addEdge(adjStations, 73, 288, 1);
            addEdge(adjStations, 74, 175, 2); addEdge(adjStations, 74, 293, 3);
            addEdge(adjStations, 75, 92, 4); addEdge(adjStations, 75, 123, 2);
            addEdge(adjStations, 76, 268, 2);
            //77
            addEdge(adjStations, 78, 203, 2); addEdge(adjStations, 78, 237, 2);
            addEdge(adjStations, 79, 208, 2); addEdge(adjStations, 79, 220, 2);
            //80
            addEdge(adjStations, 81, 162, 2); addEdge(adjStations, 81, 191, 3);
            addEdge(adjStations, 82, 191, 4);
            addEdge(adjStations, 83, 135, 3); addEdge(adjStations, 83, 147, 2);
            addEdge(adjStations, 84, 128, 2);
            addEdge(adjStations, 85, 151, 1);
            addEdge(adjStations, 86, 253, 2); addEdge(adjStations, 86, 277, 2); addEdge(adjStations, 86, 292, 2);
            addEdge(adjStations, 87, 254, 2);
            addEdge(adjStations, 88, 143, 2); addEdge(adjStations, 88, 169, 2); addEdge(adjStations, 88, 275, 1);
            addEdge(adjStations, 89, 103, 2); addEdge(adjStations, 89, 143, 2);
            //#E
            //F
            addEdge(adjStations, 90, 108, 2);
            addEdge(adjStations, 91, 143, 4);
            addEdge(adjStations, 92, 164, 3); addEdge(adjStations, 92, 283, 2);
            addEdge(adjStations, 93, 252, 2); addEdge(adjStations, 93, 280, 7); addEdge(adjStations, 93, 285, 1);
            addEdge(adjStations, 94, 122, 2); addEdge(adjStations, 94, 159, 2); addEdge(adjStations, 94, 222, 4);
            addEdge(adjStations, 95, 193, 2); addEdge(adjStations, 95, 282, 1);
            //#F
            //G
            //96
            addEdge(adjStations, 97, 174, 2); addEdge(adjStations, 97, 209, 3);
            addEdge(adjStations, 98, 121, 4); addEdge(adjStations, 98, 231, 1);
            addEdge(adjStations, 99, 110, 4);
            addEdge(adjStations, 100, 109, 2); addEdge(adjStations, 100, 225, 1);
            addEdge(adjStations, 101, 257, 1); addEdge(adjStations, 101, 275, 2);
            addEdge(adjStations, 102, 108, 3);
            //103
            addEdge(adjStations, 104, 132, 2); addEdge(adjStations, 104, 190, 2); addEdge(adjStations, 104, 195, 1); addEdge(adjStations, 104, 271, 2); addEdge(adjStations, 104, 292, 3);
            addEdge(adjStations, 105, 181, 2); addEdge(adjStations, 105, 194, 2);
            //106
            addEdge(adjStations, 107, 140, 3); addEdge(adjStations, 107, 263, 3);
            //#G
            //H
            //108
            addEdge(adjStations, 109, 207, 2); addEdge(adjStations, 109, 263, 2);
            //110
            addEdge(adjStations, 111, 175, 3); addEdge(adjStations, 111, 194, 2);
            addEdge(adjStations, 112, 247, 2); addEdge(adjStations, 112, 296, 2);
            addEdge(adjStations, 113, 139, 3);
            addEdge(adjStations, 114, 182, 2); addEdge(adjStations, 114, 286, 2); addEdge(adjStations, 114, 178, 3);
            addEdge(adjStations, 115, 116, 3); addEdge(adjStations, 115, 117, 3); addEdge(adjStations, 115, 131, 4);
            addEdge(adjStations, 116, 117, 5);
            //117
            //118
            addEdge(adjStations, 119, 233, 1);
            addEdge(adjStations, 120, 259, 3);
            addEdge(adjStations, 121, 185, 3);
            addEdge(adjStations, 122, 143, 4);
            //123
            addEdge(adjStations, 124, 133, 2); addEdge(adjStations, 124, 269, 3);
            addEdge(adjStations, 125, 221, 2); addEdge(adjStations, 125, 257, 2);
            addEdge(adjStations, 126, 185, 2); addEdge(adjStations, 126, 224, 1);
            //127
            addEdge(adjStations, 128, 266, 2);
            addEdge(adjStations, 129, 130, 2); addEdge(adjStations, 129, 131, 2);
            addEdge(adjStations, 130, 188, 2);
            //131
            addEdge(adjStations, 132, 145, 2);
            //#H
            //I
            addEdge(adjStations, 133, 218, 3);
            addEdge(adjStations, 134, 170, 1);
            //#I
            //No J names
            //K
            addEdge(adjStations, 135, 189, 2); addEdge(adjStations, 135, 277, 3);
            addEdge(adjStations, 136, 204, 3); addEdge(adjStations, 136, 296, 3);
            //137
            addEdge(adjStations, 138, 262, 2);
            addEdge(adjStations, 139, 232, 2);
            addEdge(adjStations, 140, 211, 3);
            addEdge(adjStations, 141, 285, 2); addEdge(adjStations, 141, 295, 2);
            addEdge(adjStations, 142, 158, 2); addEdge(adjStations, 142, 204, 2);
            addEdge(adjStations, 143, 221, 2);
            addEdge(adjStations, 144, 205, 2); addEdge(adjStations, 144, 280, 3);
            addEdge(adjStations, 145, 231, 3);
            //#K
            //L
            addEdge(adjStations, 146, 149, 1); addEdge(adjStations, 146, 290, 2);
            addEdge(adjStations, 147, 277, 1);
            addEdge(adjStations, 148, 161, 3); addEdge(adjStations, 148, 206, 1);
            addEdge(adjStations, 149, 225, 2);
            addEdge(adjStations, 150, 195, 2); addEdge(adjStations, 150, 257, 1);
            //151
            addEdge(adjStations, 152, 153, 3); addEdge(adjStations, 152, 248, 2);
            addEdge(adjStations, 153, 228, 2); addEdge(adjStations, 153, 273, 2);
            addEdge(adjStations, 154, 223, 3); addEdge(adjStations, 154, 291, 3);
            addEdge(adjStations, 155, 167, 2);
            addEdge(adjStations, 156, 239, 2);
            //157
            //#L
            //M
            addEdge(adjStations, 158, 276, 1);
            addEdge(adjStations, 159, 264, 3);
            //160
            //161
            //162
            addEdge(adjStations, 163, 245, 2); addEdge(adjStations, 163, 248, 4);
            //164
            addEdge(adjStations, 165, 261, 2);
            addEdge(adjStations, 166, 183, 3); addEdge(adjStations, 166, 212, 4);
            addEdge(adjStations, 167, 187, 1);
            addEdge(adjStations, 168, 235, 4);
            //169
            //170
            //#M
            //N
            addEdge(adjStations, 171, 280, 4);
            addEdge(adjStations, 172, 251, 4);
            addEdge(adjStations, 173, 251, 4);
            //174
            addEdge(adjStations, 175, 281, 2);
            addEdge(adjStations, 176, 192, 2);
            //177
            addEdge(adjStations, 178, 197, 3);
            addEdge(adjStations, 179, 232, 2); addEdge(adjStations, 179, 279, 2);
            addEdge(adjStations, 180, 229, 1);
            addEdge(adjStations, 181, 234, 3);
            addEdge(adjStations, 182, 200, 2);
            addEdge(adjStations, 183, 184, 2);
            addEdge(adjStations, 184, 197, 2);
            addEdge(adjStations, 185, 206, 2);//Notting Hill Gate
            //#N
            //O
            addEdge(adjStations, 186, 238, 2);//oakwood
            //186
            //187
            //188
            addEdge(adjStations, 189, 246, 3);//oval
            addEdge(adjStations, 190, 195, 2); addEdge(adjStations, 190, 210, 2); addEdge(adjStations, 190, 257, 2); addEdge(adjStations, 190, 275, 2);//oxford
            addEdge(adjStations, 191, 216, 1); addEdge(adjStations, 191, 276, 2);
            //192
            addEdge(adjStations, 193, 203, 3);
            //194
            //195
            addEdge(adjStations, 196, 270, 1); addEdge(adjStations, 196, 271, 3);
            //197
            addEdge(adjStations, 198, 268, 2); addEdge(adjStations, 198, 284, 2);
            addEdge(adjStations, 199, 287, 1); addEdge(adjStations, 199, 291, 1);
            addEdge(adjStations, 200, 280, 3);
            addEdge(adjStations, 201, 215, 1);
            addEdge(adjStations, 202, 248, 2);
            //203,204,205,206
            addEdge(adjStations, 207, 243, 2);
            addEdge(adjStations, 208, 230, 3); addEdge(adjStations, 208, 286, 3);
            addEdge(adjStations, 209, 273, 2);
            //210,211,212
            addEdge(adjStations, 213, 300, 3);
            addEdge(adjStations, 214, 274, 1);
            //215
            addEdge(adjStations, 216, 290, 2);
            //217
            addEdge(adjStations, 218, 220, 2);
            addEdge(adjStations, 219, 234, 1); addEdge(adjStations, 219, 289, 3);
            //220,221
            addEdge(adjStations, 222, 258, 3);
            addEdge(adjStations, 223, 260, 3); addEdge(adjStations, 223, 274, 1); addEdge(adjStations, 223, 294, 2);
            addEdge(adjStations, 224, 293, 3);
            //225
            addEdge(adjStations, 226, 294, 2);
            addEdge(adjStations, 227, 231, 2); addEdge(adjStations, 227, 271, 2);
            addEdge(adjStations, 228, 236, 2);
            //229
            addEdge(adjStations, 230, 249, 2);
            //231-235
            addEdge(adjStations, 236, 300, 2);
            addEdge(adjStations, 237, 298, 3);
            //238
            addEdge(adjStations, 239, 277, 1);
            addEdge(adjStations, 240, 271, 2); addEdge(adjStations, 240, 292, 2);
            addEdge(adjStations, 241, 252, 1);
            //242
            addEdge(adjStations, 243, 263, 1);
            //244
            addEdge(adjStations, 245, 294, 3);
            addEdge(adjStations, 246, 270, 3);
            addEdge(adjStations, 247, 279, 3);
            addEdge(adjStations, 248, 284, 7);
            addEdge(adjStations, 249, 250, 3);
            //250
            addEdge(adjStations, 255, 256, 2);
            //256
            addEdge(adjStations, 259, 301, 3);
            addEdge(adjStations, 264, 299, 2);
            addEdge(adjStations, 265, 266, 3);
            addEdge(adjStations, 277, 292, 3);
            addEdge(adjStations, 283, 301, 1);
            addEdge(adjStations, 287, 291, 2);
            addEdge(adjStations, 297, 298, 3);

            /* IGNORE CONTENTS OF COMMENT - REMNANT OF NON-GUI PROTOTYPE
            Console.WriteLine("Enter your starting station:\n\n"); //replace in interface with data collection from text box / item tapped (DONE)
            string userInputStation1 = Console.ReadLine();
            Console.WriteLine("Enter your destination:\n\n"); //replace in interface with data collection from text box / item tapped (DONE)
            string userInputStation2 = Console.ReadLine();
            tubeTracer.printShortestDistance(adjStations, sourceStation, destStation, stationNumber, stationList, distanceList); //All variables needed for algorithm sent to algorithm class
            */
        }
        public void removeStation(string stationName) //Removes a station, if the need arises
        {
            for (int h = 0; h < stations.Length; h++)
            {
                if (stations[h] == stationName)
                {
                    stations[h] = "";
                }
            }
        }

        public int getStationID(string statName) //Returns numerical IDs for routefinder
        {
            int statID = 0;
            int i = 0;
            bool statFound = false;

            while (!(statFound))
            {
                if (statName.ToLower() == stations[i].ToLower())
                {
                    statFound = true;
                    statID = i;
                    return statID;
                }
                else
                    i++;
            }
            return statID;
        }
        public string getStationName(int stationID) //Returns actual station names for people to read
        {
            return stations[stationID];
        }
 
        public string[] stations = new string[]//Collection of stations for the map
            {"Acton Town","Aldgate","Aldgate East",
            "All Saints","Alperton","Amersham",
            "Angel","Archway","Arnos Grove",
            "Arsenal","Baker Street","Balham",
            "Bank","Barbican","Barking",
            "Barkingside", "Barons Court", "Bayswater",
            "Beckton", "Beckton Park", "Becontree",
            "Belsize Park", "Bermondsey", "Bethnal Green",
            "Blackfriars", "Blackhorse Road", "Blackwall",
            "Bond Street", "Borough", "Boston Manor",
            "Bounds Green", "Bow Church", "Bow Road",
            "Brent Cross", "Brixton", "Bromley-By-Bow",
            "Buckhurst Hill", "Burnt Oak",
            "Caledonian Road", "Camden Town", "Canada Water",
            "Canary Wharf", "Canning Town", "Cannon Street",
            "Canons Park", "Chalfont & Latimer", "Chalk Farm",
            "Chancery Lane", "Charing Cross", "Chesham",
            "Chigwell", "Chiswick Park", "Chorleywood",
            "Clapham Common", "Clapham North", "Clapham South",
            "Cockfosters", "Colindale", "Colliers Wood",
            "Covent Garden", "Crossharbour & London Arena", "Croxley",
            "Custom House", "Cutty Sark", "Cyprus",
            "Dagenham East", "Dagenham Heathway", "Debden",
            "Deptford Bridge", "Devons Road", "Dollis Hill",
            "Ealing Broadway", "Ealing Common", "Earl's Court",
            "East Acton", "East Finchley", "East Ham",
            "East India", "East Putney", "Eastcote",
            "Edgware", "Edgware Road (B)", "Edgware Road (C)",
            "Elephant & Castle", "Elm Park", "Elverson Road",
            "Embankment", "Epping", "Euston",
            "Euston Square", "Fairlop", "Farringdon",
            "Finchley Central", "Finchley Road", "Finsbury Park",
            "Fulham Broadway", "Gallions Reach", "Gants Hill",
            "Gloucester Road", "Golders Green", "Goldhawk Road",
            "Goodge Street", "Grange Hill", "Great Portland Street",
            "Green Park", "Greenford", "Greenwich",
            "Gunnersbury", "Hainault", "Hammersmith",
            "Hampstead", "Hanger Lane", "Harlesden",
            "Harrow & Wealdston", "Harrow-on-the-Hill", "Hatton Cross",
            "Heathrow Terminal 4", "Heathrow Terminals 1, 2 & 3", "Hendon Central",
            "Heron Quays", "High Barnet", "High Street Kensington",
            "Highbury & Islington", "Highgate", "Hillingdon",
            "Holborn", "Holland Park", "Holloway Road",
            "Hornchurch", "Hounslow Central", "Hounslow East",
            "Hounslow West", "Hyde Park Corner", "Ickenham",
            "Island Gardens", "Kennington", "Kensal Green", "Kensington (Olympia)", "Kentish Town",
            "Kenton", "Kew Gardens", "Kilburn",
            "Kilburn Park", "King's Cross St. Pancras", "Kingsbury",
            "Knightsbridge", "Ladbroke Grove", "Lambeth North","Lancaster Gate",
            "Latimer Road", "Leicester Square", "Lewisham",
            "Leyton", "Leytonstone", "Limehouse",
            "Liverpool Street", "London Bridge", "Loughton",
            "Maida Vale", "Manor House", "Mansion House",
            "Marble Arch", "Marylebone","Mile End",
            "Mill Hill East", "Monument", "Moor Park",
            "Moorgate", "Morden", "Mornington Crescent",
            "Mudchute", "Neasden", "New Cross",
            "New Cross Gate", "Newbury Park", "North Acton",
            "North Ealing", "North Greenwich","North Harrow",
            "North Wembley", "Northfields", "Northolt",
            "Northwick Park", "Northwood", "Northwood Hills",
            "Notting Hill Gate", "Oakwood", "Old Street",
            "Osterley", "Oval", "Oxford Circus",
            "Paddington", "Park Royal", "Parsons Green",
            "Perivale", "Picadilly Circus", "Pimlico",
            "Pinner", "Plaistow", "Poplar",
            "Preston Road", "Prince Regent", "Pudding Mill Lane",
            "Putney Bridge", "Queen's Park", "Queensbury",
            "Queensway", "Ravenscourt Park", "Rayners Lane",
            "Redbridge", "Regent's Park", "Richmond",
            "Rickmansworth", "Roding Valley", "Rotherhithe",
            "Royal Albert", "Royal Oak", "Royal Victoria",
            "Ruislip", "Ruislip Gardens", "Ruislip Manor",
            "Russell Square", "Seven Sisters", "Shadwell",
            "Shepherd's Bush (C)", "Shepherd's Bush (H)", "Shoreditch",
            "Sloane Square", "Snaresbrook", "South Ealing",
            "South Harrow", "South Kensington", "South Kenton",
            "South Quay", "South Ruislip", "South Wimbledon",
            "South Woodford",
            "Southfields", "Southgate", "Southwark",
            "St. James's Park", "St. John's Wood", "St. Paul's",
            "Stamford Brook", "Stanmore", "Stepney Green",
            "Stockwell", "Stonebridge Park", "Stratford",
            "Sudbury Hill", "Sudbury Town", "Surrey Quays",
            "Swiss Cottage", "Temple", "Theydon Bois",
            "Tooting Bec", "Tooting Broadway", "Tottenham Court Road",
            "Tottenham Hale", "Totteridge & Whetstone", "Tower Gateway",
            "Tower Hill", "Tufnell Park",
            "Turnham Green", "Turnpike Lane", "Upminster",
            "Upminster Bridge", "Upney", "Upton Park",
            "Uxbridge", "Vauxhall", "Victoria",
            "Walthamstow Central", "Wanstead", "Wapping",
            "Warren Street", "Warwick Avenue", "Waterloo",
            "Watford", "Wembley Central", "Wembley Park",
            "West Acton", "West Brompton", "West Finchley",
            "West Ham","West Hampstead","West Harrow",
            "West India Quay","West Kensington","West Ruislip",
            "Westbourne Park","Westferry","Westminster",
            "White City","Whitechapel","Willesden Green",
            "Willesden Junction","Wimbledon","Wimbledon Park",
            "Wood Green","Woodford","Woodside Park"
        };
    }
}
