using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_worksheet
{
    class LINQ_problems
    {
        public List<string> grades;

        //problem #1
        public List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        public List<string> newTh = new List<string>(); //creating my new list that will contain the th strings

        public void Print()
        {
            foreach (string element in words) //loop through each element in words
            {

                if (element.Contains("th")) //if the elements contains "th"
                {
                    //newTh.Add(element); //adding it to the list
                    Console.WriteLine("The words that contains 'TH' are: " + element); //print it

                }
            }
        }
        //end problem #1

        //problem #2
        public void RemoveDup()
        {
            // List with duplicate elements.
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            foreach (string value in names)//loop through each element in names list
            {
                Console.WriteLine("Oldlist: {0}", value); //prints list
            }

            // Get distinct elements and convert into a list again.
            List<string> distinct = names.Distinct().ToList();

            foreach (string value in distinct)
            {
                Console.WriteLine("New list: {0}", value);
            }

            Console.ReadLine();
        }
        //end problem #2


        //problem #3
        public LINQ_problems()
        {
            grades = new List<string>() { "80,100,92,89,65",
                    "93,81,78,84,69",
                    "73,88,83,99,64",
                    "98,100,66,74,55"
                   };
        }
        public List<string> firstClassGrades = new List<string>(); //creating my new list that will contain the 1st string of grades


        public void AverageGrade(List<string> grades)
        {
            var stringArray = grades.Select(g => g.Split(',')).ToList();
            var intList = stringArray.Select(g => g.Select(a => int.Parse(a)).ToList()).ToList();
            // remove lowest
            // add all values in sub arrays and divide by grades.Count
            // add averages and divide by averages.Count



            foreach (string value in firstClassGrades.ToList())//loop through each element in names list
            {
                for (int i = firstClassGrades.Count - 1; i > 4; i++)
                {
                    if (firstClassGrades.Count == 4)
                    {
                        firstClassGrades.RemoveAt(4);
                    }

                }
            }

            firstClassGrades.RemoveAt(0); //removes entire first string 80,100,92,89,65 so no
            firstClassGrades.ForEach(Console.WriteLine);// prints list  

            Console.ReadLine();
        }
        

        //have a foreach .length -1, put each string in a new list, sort, drop lowest, average 
        //end of problem 3


        //problem #4
        //Write a function that takes in a string of letters (i.e. “Terrill”) 
        //and returns an alphabetically ordered string corresponding to the letter frequency (i.e. "E1I1L2R2T1")
       
        
        
        //end problem #4








    }
}
