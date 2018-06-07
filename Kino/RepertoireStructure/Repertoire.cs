using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kino.RepertoireStructure
{
    /// <summary>
    /// Class contains list of Movie objects and methods to operate on that list.
    /// </summary>
    [Serializable]
    class Repertoire
    {
        List<Movie> listOfMovies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            listOfMovies.Add(movie);
        }
        public void AddMovie(string title, int length)
        {
            listOfMovies.Add(new Movie(title, length));
        }
        public void RemoveMovie(Movie movie)
        {
            listOfMovies.Remove(movie);
        }
        public void AddMovieInfo(Movie movie, string info)
        {
            movie.AddInfo(info);
        }
        public void AddSeance(Movie movie, DateTime seanceTime, int screen)
        {
           movie.listOfSeances.Add(new Seance(seanceTime, screen, movie.title));
        }
        public void EditMovie(int movie, string title, string about, int length)
        {
            listOfMovies[movie].EditMovie(title, about, length);
        }
        public void AddMovieInfo(int movie, string info)
        {
            listOfMovies[movie].AddInfo(info);
        }
        public void BuyTicket(int movieNumber, int dateTime, int row, int seat)
        {
            if (listOfMovies.ElementAt(movieNumber).listOfSeances[dateTime].tickets[row, seat].SeatTaken())
            {
                Console.WriteLine("Miejsce "+seat+" w rzędzie "+row+" zostało już wykupione");
            }
            else {
                listOfMovies.ElementAt(movieNumber).listOfSeances[dateTime].tickets[row, seat].BuyThisTicket();
                Console.WriteLine("~~~~~~~~~~~~Kupiłeś bilet~~~~~~~~~~~~\n");
                Console.WriteLine(listOfMovies.ElementAt(movieNumber).listOfSeances[dateTime].tickets[row, seat].ToString());

            }
        }


        public override string ToString()
        {
            string tmp = string.Empty;
            for (int i = 0; i < listOfMovies.Count; i++)
            {
                tmp+=listOfMovies[i].ToString() + "\n\n";
            }
            return tmp;
        }
    }
}
