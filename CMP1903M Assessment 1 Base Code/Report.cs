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
        public void outputReport(List<int> values)
        {
            Console.WriteLine("The provided text was " + values[0] + " sentences long.");
            Console.WriteLine("The provided text contained " + values[1] + " vowels.");
            Console.WriteLine("The provided text contained " + values[2] + " consonants.");
            Console.WriteLine("The provided text contained " + values[3] + " upper case letters.");
            Console.WriteLine("The provided text contained " + values[4] + " lower case letters.");
        }

    }
}
