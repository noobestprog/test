using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProg
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassContainer workList = new ClassContainer();
            workList.ReadFromXML();
            workList.ShowListNamesAndSalaries();
            ;
            Console.ReadLine();
        }
    }
}
