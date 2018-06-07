using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.RepertoireStructure
{
    /// <summary>
    /// Class contains a Movie structure which consists of title, informations about movie, length and list of seaces.
    /// </summary>
  [Serializable]
    class Movie
    {
        public string title;
        public string about = "";
        public int length;
        public List<Seance> listOfSeances= new List<Seance>();

        public Movie(string title, int length)
        {
            this.title = title;
            this.length = length;
        }

        public Movie(string title, int length, List<DateTime> newListOfSeances, int screen)
        {
            this.title = title;
            this.length = length;
            for (int i = 0; i < newListOfSeances.Count; i++)
            {
                this.listOfSeances.Add(new Seance(newListOfSeances[i], screen, title));
            }
        }

        public override string ToString()
        {
            string tempListOfSeances = string.Empty;
            int lengthListOfSeances = listOfSeances.Count();
            for (int i = 0; i < lengthListOfSeances; i++)
            {
                tempListOfSeances += (listOfSeances[i].ToString() + "\n");
            }
            return "Title: "+title+"\n"+"About: "+about+"\nDuration time: "+length+"[min]\n" + tempListOfSeances;
        }
        public void AddInfo(string info)
        {
            this.about = info;
        }
        public void AddSeance(DateTime seanceTime, int screen)
        {
            //I don't remember why the body of this method is commented, but it must have been for a reason... 
            //listOfSeances.Add();
        }
        public void EditMovie(string title, string about, int length)
        {
            this.title = title;
            this.about = about;
            this.length = length;
        }
        
    }
}
