using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubeRouteFinder
{
    class PriorityQueue //Priority queue to store stations.
    {
        int queueCount = 0;
        class node //Member class for queue
        {
            public int station { get; set; } 
            public int distanceAsPriority { get; set; } 
        }
        List<node> stationsAsPrioQueue = new List<node>();//Creates emprt list to serve as container for priority queue
        public void enQueue(int newStation, int newDistance) //Enqueues a new station as node
        {
            node newNode = new node { station = newStation, distanceAsPriority = newDistance };
            stationsAsPrioQueue.Add(newNode);
            queueCount++;
            insertionSort();
        }
        public int Count()
        {
            return queueCount;
        }
        public int deQueue()//Dequeues station with smallest distance to source
        {
            int stationToReturn = stationsAsPrioQueue[0].station;
            stationsAsPrioQueue.RemoveAt(0);
            queueCount--;
            insertionSort();
            return stationToReturn;
        }
        //Insertion sort queue members
        //The queue length increments meaning few swaps each time this is run. Queue will not be very long.
        void insertionSort()
        {
            int positionInQueue;
            node nodeToInsert;

            for(int i = 1; i<this.Count(); i++)
            {
                nodeToInsert = stationsAsPrioQueue[i];
                positionInQueue = i;

                while ((positionInQueue > 0) && (stationsAsPrioQueue[positionInQueue-1].distanceAsPriority > nodeToInsert.distanceAsPriority))
                {
                    //swapping until correct position is found
                    stationsAsPrioQueue[positionInQueue] = stationsAsPrioQueue[positionInQueue - 1];
                    positionInQueue--;
                }
                stationsAsPrioQueue[positionInQueue] = nodeToInsert;
            }
        }
    }
}
