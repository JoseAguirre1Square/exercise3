using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassB classB = new ClassB();

            classB.printFromInterface();


            /***            Order List Asc ****/
            Console.WriteLine("*************Ordering List ASC**************");
            classB.orderList("asc").ForEach(p => Console.WriteLine(p));
            Console.WriteLine("********************************************");
            Console.WriteLine("*************Ordering List DESC**************");
            classB.orderList("desc").ForEach(p => Console.WriteLine(p));
            Console.WriteLine("********************************************");



            Console.WriteLine("***********FILTER LIST**********************");
            classB.filterList();
            Console.WriteLine("********************************************");


            Console.WriteLine("***********DELETE DUPLICATES**********************");
            classB.deleteDuplicate();
            Console.WriteLine("**************************************************");

            ClassA classA = new ClassA();


            Console.WriteLine("***********COMPARING STRING'S**********************");
            Console.WriteLine(classA.compareStrings("jose","jose"));
            Console.WriteLine("***************************************************");

            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 1,2, 3 };

            Console.WriteLine("***********COMPARING LIST'S'S**********************");
            classA.compareLists(list1, list2);
            Console.WriteLine("***************************************************");

            Console.ReadKey();


        }
    }
}
