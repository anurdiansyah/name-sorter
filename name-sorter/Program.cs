using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> unsortedNames = new List<string>();
            List<string> sortedNames = new List<string>();

            string readline;
            do
            {
                readline = Console.ReadLine();
                if (readline != "exit")
                {
                    unsortedNames = RDFile.ReadAllLine(readline);
                    if (unsortedNames.Count > 0)
                    {
                        sortedNames = RDString.SortByLastWord(unsortedNames, ' ');
                        foreach (string sortedName in sortedNames)
                        {
                            Console.WriteLine(sortedName);
                        }
                    }
                }

                Console.WriteLine();
            } while (readline.ToLower() != "exit");
            
        }
    }
}
