using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Creating default variables
        public string text = "nothing";
        public string? path;

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public void manualTextInput()
        {
            Console.WriteLine("Please input the text you wish to analyse.");
            text = Console.ReadLine();
            if (text == null)
            {
                text = "";
            }
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public void fileTextInput(string fileName)
        {
            try
            {
                text = File.ReadAllText(fileName);
            }
            catch (FileNotFoundException e) //Terminate the program if the file is not found
            {
                Console.WriteLine("The file " + fileName + " was not found.", e.Source);
                Environment.Exit(1);
            }
        }

        //Method: inputChoice
        //Arguments: none
        //Returns: nothing (calls other methods)
        //Allow the user to choose to input manually or input via file
        public void inputChoice()
        {
            Console.WriteLine("Do you want to input text manually or from a file? (m/f)");
            while (true)
            {
                var choice = Console.ReadLine();
                var decided = false;

                switch (choice)
                {
                    case "m":
                        manualTextInput();
                        decided = true;
                        break;
                    case "f":
                        Console.WriteLine("Please enter the full path of the file you wish to read.");
                        path = Console.ReadLine();
                        fileTextInput(path);
                        decided = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please enter either 'm' or 'f'.");
                        break;
                }
                if (decided)
                {
                    break;
                }
            }
        }

    }
}
