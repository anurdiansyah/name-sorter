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
        /// <returns>Return a list of string.</returns>
        public static List<string> ReadAllLine(string p_sFilePath)
        {
            string message = string.Empty;
            List<string> lstResults = new List<string>();

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

        /// <summary>
        /// Write string into Text file
        /// </summary>
        /// <param name="p_sContent"></param>
        /// <param name="p_sFileName">default : File_yyyyMMdd.txt</param>
        /// <param name="p_sPath">default : Base Directory</param>
        public static void WriteToFile(string p_sContent, string p_sFileName = "", string p_sPath = "")
        {
            string message = string.Empty;
            p_sPath = string.IsNullOrEmpty(p_sPath) ? AppContext.BaseDirectory : p_sPath;
            p_sFileName = string.IsNullOrEmpty(p_sFileName) ? "File" + DateTime.Now.ToString("yyyyMMdd") + ".txt" : p_sFileName;

            try
            {
                string fullPath = System.IO.Path.Combine(p_sPath, p_sFileName);
                System.IO.File.WriteAllText(fullPath, p_sContent);
            }
            catch(Exception e)
            {
                message = e.Message;
            }
            finally
            {
                if (!string.IsNullOrEmpty(message)) Console.WriteLine(message);
            }
        }

        /// <summary>
        /// Write string[] into Text file
        /// </summary>
        /// <param name="p_sContent"></param>
        /// <param name="p_sFileName">default : File_yyyyMMdd.txt</param>
        /// <param name="p_sPath">default : Base Directory</param>
        public static void WriteToFile(List<string> p_sContent, string p_sFileName = "", string p_sPath = "")
        {
            string message = string.Empty;
            p_sPath = string.IsNullOrEmpty(p_sPath) ? AppContext.BaseDirectory : p_sPath;
            p_sFileName = string.IsNullOrEmpty(p_sFileName) ? "File" + DateTime.Now.ToString("yyyyMMdd") + ".txt" : p_sFileName;

            try
            {
                string fullPath = System.IO.Path.Combine(p_sPath, p_sFileName);
                System.IO.File.WriteAllLines(fullPath, p_sContent);
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            finally
            {
                if (!string.IsNullOrEmpty(message)) Console.WriteLine(message);
            }
        }
    }
}
