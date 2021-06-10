using System;

namespace ProgrammingConcepts1
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            //  1 - Write a program and ask the user to enter a number.
            //  The number should be between 1 to 10.
            //  If the user enters a valid number, display "Valid" on the console.

             void Excercise1()
            {
                Console.WriteLine("Please enter a number");
                var userNumber = Convert.ToInt32(Console.ReadLine());
                if(userNumber<1 || userNumber > 10)
                {
                    Console.WriteLine("Not valid");
                }else
                {
                    Console.WriteLine("Valid");
                }

            }
            //  2- Write a program which takes three numbers
            //  from the console and displays the maximum of the three.
              void Exerciese2()
            {
                var userNumbers = new int[3];

                Console.WriteLine("Please enter first of three numbers");

                userNumbers[0] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter second of three numbers");

                userNumbers[1] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter third of three numbers");

                userNumbers[2] = Convert.ToInt32(Console.ReadLine());
                var max = userNumbers[0];
                foreach(var num in userNumbers)
                {
                    if(num > max)
                    {
                        max = num;
                    }
                }
                Console.WriteLine($"The highest number of the three is {max}.\nThanks for participating!");

            }
            int Excercise3()
            {
                // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no reaminder.
                // Display the count on the console.
                var count = 0;
                for(var i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
            void Exercise4()
            {
                // 4 - Write a program and ask user to enter a number.
                // Compute the factorial of the number and print it on the console.

                Console.WriteLine("Welcome to Factorializer...");
                Console.WriteLine("Please enter a number");
                var userNumber = Convert.ToInt32(Console.ReadLine());
                var result = userNumber;
                for(var i = userNumber-1; i>0; i--)
                {
                    Console.WriteLine(i);
                    
                    result *= i;  
                }
                Console.WriteLine($"{userNumber}! is {result}");
            }

            void Exercise5()
            {
                string asterisk = "*";
                    for(var i = 1; i<=5; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine(asterisk);

                    }
                    Console.WriteLine(asterisk += "*");
                }

            }

            Exercise5();
             
        }
    }
}
