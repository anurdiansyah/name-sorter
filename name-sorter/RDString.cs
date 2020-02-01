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

        /// <summary>
        /// Order the list by last word and all given string in a list
        /// </summary>
        /// <param name="p_ListToSort">a list string contain sentence we want to sort</param>
        /// <param name="p_sSeparator">a separator of sentence eg: space, commas or pipeline</param>
        /// <returns></returns>
        public static List<string> SortByLastWord(List<string> p_ListToSort, char p_sSeparator)
        {
            string message = string.Empty;
            List<string> lstResults = new List<string>();

            try
            {
                //sort all given name first, it will give us new index that will help when we order the name by last word.
                p_ListToSort.Sort();

                //get all last word and the current index for all lines and store it into a dictionary
                Dictionary<int, string> indexByLastName = new Dictionary<int, string>();
                for (int i = 0; i < p_ListToSort.Count; i++)
                {
                    string[] words = p_ListToSort[i].Split(p_sSeparator);
                    indexByLastName.Add(i, words[words.Length - 1]);
                }

                //then order the dictionary by value (the last word that we store)
                var orderedDictionary = indexByLastName.OrderBy(o => o.Value);

                //finally, order the list by getting the string by the index that we store in the ordered by name dictionary.
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
