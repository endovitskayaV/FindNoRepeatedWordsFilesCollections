using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNoRepeatedWordsFilesCollections
{
    class Comparer: IEqualityComparer<string>
    {
        public bool Equals(string str1, string str2)
        {
            if (str1.ToLower().Equals(str2.ToLower())) return true;
            else return false;
        }

        public int GetHashCode(string str)
        {
            return str.ToLower().GetHashCode();
        }
    }
}
