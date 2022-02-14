using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class ClassA
    {

        public bool compareStrings(string firstWord, string secondWord)
        {
            if (firstWord.Length == secondWord.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool compareLists(List<int> listOne, List<int> listTwo)
        {
            if (listOne.Count == listTwo.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void printFromClassParentA()
        {
            Console.WriteLine("printing from Class A");
        }
    }
}
