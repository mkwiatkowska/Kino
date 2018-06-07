using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kino.RepertoireStructure;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Kino
{
    /// <summary>
    /// It's supposed to manage all the actions but now it can only load and prind the repertoire and after that close itself :)
    /// </summary>
    public static class Menu
    {

        public static void LoadMenuInConsole()
        {
            Console.WriteLine("System Obsługi Kina\n\n");
            Console.WriteLine("Wybierz jedną z akcji poprzez wpisanie jej numeru a następnie zatwierdź enterem:");
            Console.WriteLine("1 - Załaduj i wyświetl repertuar z pliku");
            Console.WriteLine("2 - Kup Bilet");
            Console.WriteLine("3 - Sprawdź dostępność miejsca");
            Console.WriteLine("4 - Zobacz info o filmie?");
            Console.WriteLine("5 - Wyłącz program");
        }

        public static void ChooseAction(int actionNumber)
        {
            switch (actionNumber)
            {
                case 1 :
                    LoadAndPrintOutRepertoireFromFile();
                    break;
                case 2:
                    
                    break;
                case 5:
                    Shutdown();
                    break;
                default:
                    break;
                    
            }
        }

        
        public static void LoadAndPrintOutRepertoireFromFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream openingStream = new FileStream("Repertuar.bin", FileMode.Open, FileAccess.Read);

            Repertoire RepertuarWczytany = (Repertoire)formatter.Deserialize(openingStream);
            openingStream.Close();
            Console.WriteLine(RepertuarWczytany.ToString());
        }
        
        public static void ForCase3()
        {

        }
        public static void ForCase4()
        {

        }
        public static void Shutdown()
        {
            Environment.Exit(0);
        }
    }
}
