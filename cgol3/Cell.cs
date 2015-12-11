using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgol3
{
    public class Cell
    {
        public bool IsCurrentlyAlive { get; set; }
        //public int xCoordinate { get; set; }
        //public int yCoordinate { get; set; }

        public bool IsAliveInNextGeneration (List<Cell> cellNeighbors)
        {
            List<Cell> aliveNeighbors = new List<Cell>(); 
            foreach(Cell neighbor in cellNeighbors)
            {
                if(neighbor.IsCurrentlyAlive)
                {
                    aliveNeighbors.Add(neighbor); 
                }
            }

            if (aliveNeighbors.Count == 3 || aliveNeighbors.Count == 2) //if it's going to live
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }

    
}
