using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FindNoRepeatedWordsFilesCollections
{
    class Files
    {
        private static string sInputData;

        public static string Open(string fileName)
        {
            StreamReader input = null;

            try
            {
                input = new StreamReader(fileName, Encoding.GetEncoding(1251));
                sInputData = input.ReadToEnd();
                input.Close();
                return sInputData;
            }

            catch (Exception)
            {
                return null;
            }

            finally
            {
                if (input != null) input.Close();
            }
        }

        public static List<string> FindNotRepeatedWords()
        {
            // RemoveEmptyEntries - no null elements
            string[] split = sInputData.Split(new String[] { "!", ",", ".", ":", ";", ".", "?", " ", "\t", "\n", "\r", "\r\n", "/", "|" }, StringSplitOptions.RemoveEmptyEntries);

            Comparer comparer = new Comparer();
            Dictionary<string, int> dictionary = new Dictionary<string, int>(comparer);

            for (int i = 0; i < split.Length; i++)
            {
                try
                { 
                    dictionary.Add(split[i], 1);
                }
                catch (ArgumentException)
                {
                    dictionary[split[i]]++;
                }
            }

           
            List<string> keys = new List<string>(dictionary.Keys);
            List<int> values = new List<int>(dictionary.Values);
            List<string> correctChosenWordsList = new List<string>();

            for (int i = 0; i < keys.Count; i++)
            {
                if (values[i] == 1) correctChosenWordsList.Add(keys[i]);
            }

            if (correctChosenWordsList.Count != 0) return MySort(correctChosenWordsList);
            else return null;

        }

        private static List<string> MySort(List<string> list)
        {
            int indexVowel = 0;
            string vowels = "eyuioaEYUIOAуеыаоэяиюёУЕЫАОЭЯИЮЁ";
          
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (list[i][0] != vowels[j])
                    {
                        string temp = list[indexVowel];
                        list[indexVowel] = list[i];
                        list[i] = temp;
                        indexVowel++;
                    }
                }
            }

            list.Sort(0, indexVowel, null); // null- default comparer
            list.Sort(indexVowel, list.Count - indexVowel, null);
            return list;
        }

        public static void OutputToTextfile(List<string> list, string fileName)
        {
            StreamWriter output = null;

            try
            {
                output = new StreamWriter(fileName, false); //false-rewriting data in file
               
                if (list == null) output.Write("");
                else
                {
                    foreach (string i in list)
                    {
                        output.Write(i + Environment.NewLine);
                    }
                }
                output.Close();
               
            }

            catch (Exception)
            {
           
            }

            finally
            {
                if (output != null) output.Close();
            }
        }
    }
}
