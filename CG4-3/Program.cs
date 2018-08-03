using System;

namespace CG4_3
{
    class Program
    {
        static void Main(string[] args)
        {


            //Write to console requesting the user to input 30 names and hit enter after each name.

            //If the user hits enter without entering a name the program stops and no longer allows the user to input names.

            //Writeline informing the user they pressed enter without adding a name so their submission is now complete.

            //Create an array with the names entered by the user.

            //Randomly choose a name from the array.

            //Write the chosen name to the console.

            //Write the list of names that did not win(not chosen) to the console.

            //I placed code in several different areas within the curly braces and other spots
            //trying to get this to work.  I reached out to class members but never heard back.
            //Kendra tried to help but I need in person tutoring (ha ha, sad really).
            //I will create a flow chart and get help on Saturday.  THANKS!

            //Ask the user to input names
            Console.WriteLine("Enter up to 30 names. " + 
            "Enter one name at a time and press enter after each entry. " +
            "Your entry is complete if you press enter without typing" +
            "a name or reach 30 names.");

            //Assign a name to the variable for the user input.
            string name = Console.ReadLine();

            //If the user hits enter without entering a name the program stops and no longer allows the user to input names.
            //I could not make this work:

            //if (name == "")
                //message = "";
            //message = "Thank you for entering your list of names.";

            //Below I attempted to create a random name selection.  This is doing nothing.
            Random r = new Random();

            //Create an array with the names entered by the user with quantity 30.
            string[] name2 = new string[30];
            
            //Create a way to print the names in the array.
            foreach (string text in name2)

            //This is more attempts for random selection.
            //return name2[Random.r(0, name2.Length)];
            //return name2[(0, name2.Length)];

            //More attempts to make program close if entered is pressed with no input.
            //if (name != "")
                

            {
                //Print names to console.
                Console.Write(text);
                Console.ReadLine();

            }
            

            }


            


        }
    }

