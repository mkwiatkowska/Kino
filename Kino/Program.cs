using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kino.Users;
using Kino.RepertoireStructure;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.CompilerServices;



namespace Kino
{
    public enum State { Guest, LoggedUser, Cashier, Manager}
    
    public class Cinema
    {
        public List<Person> PeopleList = new List<Person>();
        public Cinema()
        {
            this.PeopleList = new List<Person>();
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Menu.LoadMenuInConsole();
            while (true)
            {
                Menu.ChooseAction(Convert.ToInt32(Console.ReadLine()));
                Menu.LoadMenuInConsole();
            }
            
            //List<Screen> listOfScreens = new List<Screen>(5);
            //listOfScreens.Add(new Screen(1, 10, 10));
            //listOfScreens.Add(new Screen(2, 10, 10));
            //listOfScreens.Add(new Screen(3, 10, 10));
            //listOfScreens.Add(new Screen(4, 10, 10));
            //listOfScreens.Add(new Screen(5, 12, 16));
            //int listCount = listOfScreens.Count;

            
            //Console.WriteLine(listOfScreens.ElementAt(1).ToString());

            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream("Repertuar.bin", FileMode.OpenOrCreate, FileAccess.Write);





            //List<DateTime> dT = new List<DateTime>();
            //dT.Add(new DateTime(2017, 10, 12, 13, 00, 00));
            //dT.Add(new DateTime(2017, 10, 12, 15, 00, 00));
            //dT.Add(new DateTime(2017, 10, 12, 17, 00, 00));
            //dT.Add(new DateTime(2017, 10, 12, 19, 00, 00));
            //Movie m1 = new Movie("Królewna Śnieżka", 90, dT, 3);

            //List<DateTime> dT2 = new List<DateTime>();
            //dT2.Add(new DateTime(2017, 10, 12, 13, 00, 00));
            //dT2.Add(new DateTime(2017, 10, 12, 15, 00, 00));
            //dT2.Add(new DateTime(2017, 10, 12, 17, 00, 00));
            //dT2.Add(new DateTime(2017, 10, 12, 20, 00, 00));
            //Movie Shrek = new Movie("Shrek", 120, dT2, 2);


            //List<DateTime> dT3 = new List<DateTime>();
            //dT3.Add(new DateTime(2017, 10, 12, 13, 00, 00));
            //dT3.Add(new DateTime(2017, 10, 12, 15, 00, 00));
            //dT3.Add(new DateTime(2017, 10, 12, 17, 00, 00));
            //dT3.Add(new DateTime(2017, 10, 12, 19, 00, 00));

            //Movie LDM = new Movie("Listy do M", 112, dT3, 1);


            //Repertoire R1 = new Repertoire();
            //R1.AddMovie(m1);
            //R1.AddMovie(Shrek);
            //R1.AddMovie(LDM);

            //Console.WriteLine(m1.ToString());
            //Console.WriteLine(Shrek.ToString());
            //Console.WriteLine(LDM.ToString());

            //formatter.Serialize(stream, R1);

            //stream.Close();



            

            

           // RepertuarWczytany.BuyTicket(1, 2, 3, 8);
//            RepertuarWczytany.EditMovie(1, "Shrek 2", "", 222);

            //Console.WriteLine(RepertuarWczytany.ToString());


            //RepertuarWczytany.AddMovieInfo(1, "Shrek is love\nShrek is life");


            //Stream cS = new FileStream("Repertuar.bin", FileMode.Create, FileAccess.Write);
            //formatter.Serialize(cS, RepertuarWczytany);
            //cS.Close();

            while ("42"!=Console.ReadLine())
            {
               
            }
            

        }
    }
}
