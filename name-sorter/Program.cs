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
            List<string> unsortedNames = RDFile.ReadAllLine(args[0]);
            if (unsortedNames.Count > 0)
            {
                List<string> sortedNames = RDString.SortByLastWord(unsortedNames, ' ');
                foreach (string sortedName in sortedNames)
                {
                    Console.WriteLine(sortedName);
                }
                RDFile.WriteToFile(sortedNames, "sorted-names-list.txt");
            }
        }
    }
}
