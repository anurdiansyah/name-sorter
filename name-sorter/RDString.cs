using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorting
{
    public static class RDString
    {
        public static string LearnTestUnit()
        {
            return "Learn Unit Test";
        }

        public static List<string> SortByLastWord(List<string> p_ListToSort, char p_sSeparator)
        {
            string message = string.Empty;
            List<string> lstResults = new List<string>();

            try
            {
                p_ListToSort.Sort();

                Dictionary<int, string> indexByLastName = new Dictionary<int, string>();
                for (int i = 0; i < p_ListToSort.Count; i++)
                {
                    string[] words = p_ListToSort[i].Split(p_sSeparator);
                    indexByLastName.Add(i, words[words.Length - 1]);
                }

                var orderedDictionary = indexByLastName.OrderBy(o => o.Value);
                foreach(var keyValuePair in orderedDictionary)
                {
                    lstResults.Add(p_ListToSort[keyValuePair.Key]);
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            finally
            {
                if (string.IsNullOrEmpty(message)) Console.WriteLine(message);
            }

            return lstResults;
        }
    }
}
