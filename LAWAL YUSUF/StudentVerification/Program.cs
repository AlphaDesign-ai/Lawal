using System;

namespace StudentVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter your program");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "full time"){
                Console.WriteLine("Enter your course");
                Console.Write(Console.ReadLine() + " is a good course");
            } else if (userInput == "part time"){
                Console.WriteLine("How many credit are you taking?");
                int UserCreditNo = int.Parse(Console.ReadLine());
                if (UserCreditNo > 6) {
                    Console.WriteLine("Too much unit for a part-time student");
                    Console.WriteLine("you are allow to enter maximum of 6 credit, TRY AGAIN!!!");
                    UserCreditNo = int.Parse(Console.ReadLine());
                    if (UserCreditNo <= 6) {
                        Console.WriteLine("proceed to screen");
                    } else {
                        Console.WriteLine("You enter the wrong input");
                    }

                } else {
                    Console.WriteLine("proceed to screen");
                }

            }
        }
    }
}
