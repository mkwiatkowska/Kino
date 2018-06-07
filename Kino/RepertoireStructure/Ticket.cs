using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kino.RepertoireStructure
{
    /// <summary>
    /// Class contains a Ticket structure that consists of movie title, time of the seance, screen number, row, seat and boolean variable bought which can tell us has this exact ticket been bought before.
    /// </summary>
    [Serializable]
    class Ticket
    {
        string movie;
        string seanceTime;
        int screen;
        int row;
        int seat;
        bool bought;

        public Ticket(string movie, string seanceTime, int screen, int row, int seat) //I don't declare variable bought here, because there is no need for that
        {
            this.movie = movie;
            this.seanceTime = seanceTime;
            this.screen = screen;
            this.row = row;
            this.seat = seat;
            bought = false;
        }
        public bool SeatTaken()
        {
            return this.bought;
        }
        public void BuyThisTicket()
        {
            if (!SeatTaken())
            {
                this.bought = true;
            }
            else
            {
                Console.WriteLine("Sorry, this seat is taken.");
            }
            
        }
        public override string ToString()
        {
            return "Tytuł: " + movie + "\nGodzina seansu: " + seanceTime + "\nSala #" + screen + "\nRząd: " + row + " Miejsce: " + seat;
        }
       

    }
}
