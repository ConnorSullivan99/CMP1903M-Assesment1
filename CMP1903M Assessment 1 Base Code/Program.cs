//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            var input = new Input();
            input.inputChoice();
            
            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            var analyse = new Analyse();
            analyse.analyseText(input.text);

            //Report the results of the analysis
            var report = new Report();
            report.outputReport(analyse.values);

            //Counting the character frequency
            var characterFreqency = new Dictionary<char, int>();
            foreach (var ch in input.text)
            {
                if (characterFreqency.ContainsKey(ch))
                {
                    characterFreqency[ch]++;
                }
                else
                {
                    characterFreqency[ch] = 1;
                }
                    
            }
            Console.WriteLine("The frequency of individual characters is as follows: ");
            foreach (var pair in characterFreqency)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

           
        }
        
        
    
    }
}
