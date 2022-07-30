using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)



        public void UserOutput(List<int> list)
        {
            Console.WriteLine("Total number of Lower count letters used are: " + list[0]);
            Console.WriteLine("Total number of upper count letters used are: " + list[1]);
            Console.WriteLine("Total number of vowels letters used are: " + list[2]);
            Console.WriteLine("Total number of Consonants used are: " + list[3]);
            Console.WriteLine("Total number of Sentence endings used are: " + list[4]);
            Console.WriteLine("Total number of total letters used are: " + list[5]);
            Console.WriteLine("Total number of Spaces used are: " + list[6]);
            Console.WriteLine("Total number of numeral used are: " + list[7]);
        }




    }
}