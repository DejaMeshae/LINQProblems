using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_worksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQ_problems lINQ_problems = new LINQ_problems();
            lINQ_problems.Print();
            lINQ_problems.RemoveDup();

            //lINQ_problems.AverageGrade();
            Console.ReadLine();

        }
    }
}
