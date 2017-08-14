using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedCharacter
{
    class CharCount
    {
        public int FindCount(string str)
        {
            int Count = str.Length - str.ToCharArray().Distinct().Count();
            return Count;
        }
    }
}
