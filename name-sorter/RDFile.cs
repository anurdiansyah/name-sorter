using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorting
{
    public static class RDFile
    {
        
        /// <summary>
        /// Read a File from a path
        /// </summary>
        /// <param name="p_sFilePath"></param>
        /// <returns>Return a list of string, indexed by line.</returns>
        public static List<string> ReadAllLine(string p_sFilePath)
        {
            List<string> lstResults = new List<string>();
            string message = string.Empty;

            try
            {
                lstResults = System.IO.File.ReadAllLines(p_sFilePath).ToList();
                if (lstResults.Count < 1)
                {
                    message = "Your file " + System.IO.Path.GetFileName(p_sFilePath) + " have no lines";
                }
            }
            catch(Exception e)
            {
                message = e.Message;
            }
            finally
            {
                if(!string.IsNullOrEmpty(message)) Console.WriteLine(message);
            }
            return lstResults;
        }

    }
}
