using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubeRouteFinder
{
    partial class mapScreen
    {
        public void launchDijkstra(int sourceStat, int destStat)//Generates fresh arrays for the Dijkstra algorithm, launches Dijkstra & then generates a path from output
        {
            int[] predecessorArray = new int[stationNumber];
            int[] distancesArray = new int[stationNumber];


            //Should not run as there are no isolated nodes on the map
            //If one is found, due to a connection not being added properly in tubeBuild.buildGraph, this will stop the programme here
            if (dijkstraTube(sourceStat, destStat, predecessorArray, distancesArray) == false)
            {
                nodesUnconnectedException();
                return;
            }


            List<int> path = new List<int>();//Path for storing shortest route
            int crawl = destStat;
            path.Add(crawl);

            while (predecessorArray[crawl] != -1)//Builds a path through each predecessor back to source
            {
                path.Add(predecessorArray[crawl]);
                crawl = predecessorArray[crawl];
            }

            string[] pathOfStationNames = new string[path.Count];

            //Converts integer station IDs to readable string station names
            //Also sets path order to source-first whereas before it was destination-first.
            for (int i = path.Count - 1; i >= 0; i--)
            {
                pathOfStationNames[i] = currentTubeBuild.getStationName(path[i]);
            }
            displayResult(path, distancesArray[destStat]);
        }

        //Implement Dijkstra
        private static bool dijkstraTube(int sourceStation, int destStation, int[] predecessorArray, int[] distancesArray)
        {
            PriorityQueue routeQueue = new PriorityQueue(); //Creates a priority queue for stations
            bool[] visited = new bool[stationNumber];
            for (int i = 0; i < stationNumber; i++) //Resets arrays. Sets distances from all stations stat to source as maximum value. Clears predecessor array.
            {
                visited[i] = false; //Sets all nodes as unvisited
                distancesArray[i] = int.MaxValue;
                predecessorArray[i] = -1;//No station is in a route right now, so none of them have predecessors.
            }

            //Sets source as visited, distance to itself = 0 & adds this info to the priority queue.
            visited[sourceStation] = true;
            distancesArray[sourceStation] = 0;
            routeQueue.enQueue(sourceStation, 0);

            while (routeQueue.Count() != 0)
            {
                //returns station (and predecessors) with smallest distance from source still in queue
                int currentStation = routeQueue.deQueue();

                for (int neighbour = 0; neighbour < adjacency[currentStation].Count; neighbour++)//For each neighbor of current Station
                {
                    if (visited[adjacency[currentStation][neighbour]] == false)
                    {
                        int connectionDistance = findDistance(0, currentStation, neighbour);//Gives distance between the current station and the neighbor currently being checked


                        visited[adjacency[currentStation][neighbour]] = true;//Marks this neigbor as visited
                        distancesArray[adjacency[currentStation][neighbour]] = distancesArray[currentStation] + connectionDistance; //Total distance from source
                        predecessorArray[adjacency[currentStation][neighbour]] = currentStation;
                        routeQueue.enQueue(adjacency[currentStation][neighbour], distancesArray[adjacency[currentStation][neighbour]]);//Enqueue this neigbor & its distance from source
                        if (adjacency[currentStation][neighbour] == destStation) //Is neigbour = destination? If yes, end. If no, continue.
                            return true;
                    }
                }
            }
            //Only ends here if there is no connection. This should not happen.
            return false;
        }
        static int findDistance(int j, int currentStation, int neighbour)//Gives distance between the current station and the neighbor currently being checked
        {
            int connectionDistance = 0; bool distFound = false; 
            while (!distFound)
            {
                if (distanceList[currentStation][j] == adjacency[currentStation][neighbour])
                {
                    connectionDistance = distanceList[currentStation][j + 1];
                    distFound = true;
                }
                j++;
            }
            return connectionDistance;
        }
    }
}
