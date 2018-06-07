using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kino.RepertoireStructure
{
    [Serializable]
    class Screen
    {
        int number;
        int rows, seats;

        public Screen(int number, int rows, int seats)
        {
            this.number = number;
            this.rows = rows;
            this.seats = seats;
        }
        
        
        public override string ToString()
        {
            return "Screen number: " + number.ToString()+"\nRows: "+rows+"\nSeats: "+seats+"\nCapacity: "+rows*seats;
        }
        public int GetRows()
        {
            return rows;
        }
        public int GetSeats()
        {
            return seats;
        }
    }
}
