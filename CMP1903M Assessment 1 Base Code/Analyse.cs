using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> values = new List<int>();
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements

            values.Clear();

            //1. Number of sentences
            int sentence = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '.')
                {
                    sentence++;
                }
                
            }

            values.Add(sentence);

            //2. Number of vowels
            int vowels = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                bool isVowel = "aeiouAEIOU".IndexOf(ch) >= 0;

                if (isVowel == true)
                {
                    vowels++;
                }
            }

            values.Add(vowels);

            //3. Number of consonants
            int consonants = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                bool isConsonant = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".IndexOf(ch) >= 0;

                if (isConsonant == true)
                {
                    consonants++;
                }
            }

            values.Add(consonants);

            //4. Number of upper case letters
            int upper = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool outcome;
                char c = input[i];

                outcome = char.IsUpper(c);
                if (outcome == true)
                {
                    upper++;
                }
            }
            values.Add(upper);

            //5. Number of lower case letters
            int lower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool outcome;
                char c = input[i];

                outcome = char.IsLower(c);
                if (outcome == true)
                {
                    lower++;
                }
            }
            values.Add(lower);


            return values;
        }
    }
}
