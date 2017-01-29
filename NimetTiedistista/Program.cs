using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NimetTiedistista
{
    class Program
    {
        static void Main(string[] args)
        {
            //TArakasta löytyykö tiedosto samasta hakemistosta
            if (File.Exists("names.txt"))
            {
                Console.WriteLine("Tiedosto löytyy samasta hakemistosta.");
            }
            //Tarkasta löytyykö tiedosto
            if (File.Exists(@"D:\Temp\names.exe"))
            {
                Console.WriteLine("Tiedosto löytyy D-asemalta ja  Temp -kansiosta.");
            }
            // katsotaan löytyykö D:\ asemalta
            bool exists = File.Exists("C:\\names.txt");
            Console.WriteLine(exists);

            var names = new List<string>();

            //Haetaan tiedostosta nimet ja tungetaan listaan
                using (var sr = new StreamReader(@"D:\Temp\names.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) !=null)
                    {
                        names.Add(line);
                    }
                }

           
                //Suoritetaan Uhrauksia pimeyden alttarille ja tapahtuu magiaa
           var nimetx1 = names.GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count);

            //JA hih hei loopilla pihalle
            foreach (var x in nimetx1)
            {
                Console.WriteLine("nimi: " + x.Value + " esiintyy: " + x.Count);
            }
           
        }
    }
}
