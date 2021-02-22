using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricksOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Patrick", 25);
            dict["navn"] = 90;

            Console.WriteLine(dict.ElementAt(0));


            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };

            characters.Remove("Han");

            foreach (KeyValuePair<string, bool> item in characters)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadKey();
        }
    }
}
