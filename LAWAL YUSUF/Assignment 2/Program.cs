using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine("Hello, I can solve linear equation using cramer's rule");
            Console.WriteLine("Input your first coefficent term for the first equation");
            int firstEquaOneCoeffiecient;
            firstEquaOneCoeffiecient =  int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Input your second coefficent term for the first equation");
            int firstEquaTwoCoeffiecient;
            firstEquaTwoCoeffiecient =  int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Input your constant value");
            var firstConstantValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Input your first coefficent term for the second equation");
            int secondEquaOneCoeffiecient;
            secondEquaOneCoeffiecient =  int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Input your second coefficent term for the second equation");
            int secondEquaTwoCoeffiecient;
            secondEquaTwoCoeffiecient =  int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Input your constant value");
            var secondConstantValue = int.Parse(Console.ReadLine());

            int a = firstEquaOneCoeffiecient;
            int b = firstEquaTwoCoeffiecient;
            int e = firstConstantValue;
            int c = secondEquaOneCoeffiecient;
            int d = secondEquaTwoCoeffiecient;
            int f = secondConstantValue;

            if (a == 0 || b == 0 || c == 0 || d == 0 || e == 0 || f == 0 ) {
                Console.WriteLine("Invalid format for simultaneous equation");
            } else {
                Console.WriteLine("first equation");
                Console.WriteLine(firstEquaOneCoeffiecient +"x " + "+ " + firstEquaTwoCoeffiecient + "y" + "=" + firstConstantValue);
                Console.WriteLine("second equation");
                Console.WriteLine(secondEquaOneCoeffiecient +"x " + "+ " + secondEquaTwoCoeffiecient + "y" + "=" + secondConstantValue);
                int delta = a*d - c*d;
                int deltaX = e*d - b*f;
                int deltaY = a*f - e*c;

                int valueX = deltaX/delta; 
                int valueY = deltaY/delta;

                Console.WriteLine("x = " + valueX + " " + "y = " + valueY);
            }

        }
    }
}
