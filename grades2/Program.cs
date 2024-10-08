
/*Program to determine grades from score input using if else statements
 * Written by Gsby Marchingo
 * 17/02/23 */
using System; //calls library of system
using System.Diagnostics; //calls library of system diagnostics

namespace Grades2 // name of project, container for classes.
{
    internal class Program // initiates class of program. container for classes
    {
        public static void Main(string[] args) //entry point of the program main function
        {
            try // beginning of try catch block to exit the program gracefully if a number is not inputted
            {
                float score = 0.0f; //declaration of variable. initialises variable of type float called score
                string grade = "";//declares and initialises string type variable called grade

                Console.WriteLine("Enter score of student to receive grade:  "); // initial prompt to user
                score = Convert.ToSingle(Console.ReadLine()); // collects input of user, converts string input to floating point value and stores in variable

                if (score >= 85 && score <= 100)// beginning of if statement (gives condition to be true for block of code to execute)


                    grade = "High Distinction ";//assigns grade variable to high distinction

                else if (score >= 75 && score <= 84)// continuation of if statement (gives condition to be true for block of code to execute)

                    
                    grade = "Distinction";//assigns grade variable to  distinction

                else if (score >= 65 && score <= 74)// continuation of if statement (gives condition to be true for block of code to execute)


                    grade = "Credit";//assigns grade variable to credit

                else if (score >= 55 && score <= 64)// continuation of if statement (gives condition to be true for block of code to execute)

                    grade = "Pass";//assigns grade variable to pass

                else if (score >= 0 && score <= 54)// continuation of if statement (gives condition to be true for block of code to execute)

                    grade = "Fail";//assigns grade variable to fail



                else // completion of if statement (block of code below is completed if all other conditions above evaluate to false)

                    Console.WriteLine("That is in invalid score ");//prints message to screen if all other condition evaluate to false

                Console.WriteLine("The student's grade was " + grade);//prints the students grade to the screen from the if else statements
            }
            catch // completion of try catch block to find an exception and end the program gracefully
            {
                Console.WriteLine("Please start the program again and enter a valid integar or float number ");//message to user printed to screen
            }
            Console.ReadKey();//prevents the console window from closing
        }
        
    }
}