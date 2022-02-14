using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class ClassB : ClassA, Interface1
    {

        List<string> list = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };

        List<int> list2 = new List<int>() { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };


        public void printFromInterface()
        {
            Console.WriteLine("Hello Interface");

            printFromClassParentA();
        }


       


        public List<string> orderList(string operation){
            if(operation == "asc")
            {
                list.Sort();
                return list;
            }else if(operation == "desc")
            {
                list.Reverse();
                return list;
            }
            else
            {
                Console.WriteLine(operation + " is not a valid operation");
                return null;
            }

        }
        public void filterList()
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] == " ")
                {
                    list.RemoveAt(i);
                }
            }

            list.ForEach(x => Console.WriteLine(x));
        }
        public void deleteDuplicate()
        {
            list2 = list2.Distinct().ToList();
            list2.ForEach(x => Console.WriteLine(x));
        }
        
        
    }
}
