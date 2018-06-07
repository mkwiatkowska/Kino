using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Kino.RepertoireStructure
{
    [Serializable]
    class Seance
    {
        public DateTime seanceTime;
        int screenNumber;
        public Ticket[,] tickets;

        public Seance(DateTime seanceTime, int screenNumber, string movieTitle)
        {
            this.seanceTime = seanceTime;
            this.screenNumber = screenNumber;
            List<Screen> listOfScreens = GetScreenInfo();

            tickets = new Ticket[listOfScreens[screenNumber].GetRows(), listOfScreens[screenNumber].GetSeats()];

          
            for (int i = 0; i < this.tickets.GetLength(0); i++)
            {
                for (int j = 0; j < this.tickets.GetLength(1); j++)
                {
                    
                    tickets[i, j] = new Ticket(movieTitle, seanceTime.ToString(), screenNumber, i, j); // dopisać metody zwracające nazwę filmu etc
                }

            }
        }
        public override string ToString()
        {
            return "Time: "+seanceTime.ToShortTimeString() +" "+ "\nScreen #"+screenNumber.ToString()+"\nAmount of available seats: "+ HowManyAvailableSeats();
        }
        List<Screen> GetScreenInfo()
        {
            IFormatter openFormatter = new BinaryFormatter();
            Stream stream = new FileStream("SaleKinowe.bin", FileMode.Open, FileAccess.Read);
            List<Screen> tmp = (List<Screen>)openFormatter.Deserialize(stream);
            stream.Close();
            return tmp;
        }
        List<int[]> AvailableSeats() //mmethod chechs if there is any seat available in room
        {
            List<int[]> listOfAvailableSeat = new List<int[]>();
            
            for (int i = 0; i < this.tickets.GetLength(0); i++)
            {
                for (int j = 0; j < this.tickets.GetLength(1); j++)
                {
                    if (false == this.tickets[i, j].SeatTaken())
                    {
                        listOfAvailableSeat.Add(new int[] { i, j });
                    }
                }
                
            }
            return listOfAvailableSeat;
            
        }
        
        public int HowManyAvailableSeats()
        {
            List<int[]> list = AvailableSeats();
            return list.Count();
        }
        public void BuyTicket(int row, int seat)
        {
            if (!this.tickets[row, seat].SeatTaken())
            {
                tickets[row, seat].BuyThisTicket();
            }
        }

               
    }
}
