using System;



namespace IterationStatements
{
    public class Program
    {

        static void Main (string[]  args)
        {
            PrintRange(1000, -1000);
        }



        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRange(int ceiling, int floor)
        {
            for (int i = ceiling; i>= floor; i--)
            {
                Console.WriteLine(i);
            }

        }

        public static void PrintThousand()
        {

        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time


        public static void Threes()

        {
            for(int k =3; k <= 999; k +=3)
            {
                Console.WriteLine(k);
            }
        }




        //Write a method to accept two integers as parameterss and check whether they are equal or not


        public static bool IsEqual(int a, int b)
        {

            if(a == b)
            {
                return true;
            }
            else
            {
                return false;
            }


        }




        //Write a method to check whether a given number is even or odd

        static void Even(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsEven(number))
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }






        //Write a method to check whether a given number is positive or negative

        


        static void PositivOrNegative(string[] args)
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (IsPositive(number))
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (IsNegative(number))
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine($"{number} is zero.");
            }
        }

        static bool IsPositive(double number)
        {
            return number > 0;
        }

        static bool IsNegative(double number)
        {
            return number < 0;
        }
    






    //Write a method to read the age of a candidate and determine whether they can vote.
    //Hint: Use Parse or the safer TryParse() for an extra challenge
    //Parse()
    //TryParse()


        


        static void Vote(string[] args)
        {
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                CheckVotingEligibility(age);
            }
            else
            {
                Console.WriteLine("Wrong age input. Please enter a valid integer age.");
            }
        }

        static void CheckVotingEligibility(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are able to vote.");
            }
            else
            {
                Console.WriteLine("You are not able to vote.");
            }
        }
    


    //Heatin Up Section:
    //Write a method to check if an integer(from the user) is in the range -10 to 10

        


    
        static void Range(string[] args)
        {
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                if (IsInRange(userNumber, -10, 10))
                {
                    Console.WriteLine($"{userNumber} is in the range -10 to 10.");
                }
                else
                {
                    Console.WriteLine($"{userNumber} is not in the range -10 to 10.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static bool IsInRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }
    



    //Write a method to display the multiplication table(from 1 to 12) of a given integer

        
    
        static void integer(string[] args)
        {
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                DisplayMultiplicationTable(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    

    //Call the methods to test them in the Main method below


    //double milesRanToday = 0;

    //bool isParsable;

    //do
    //{
    //    Console.WriteLine($"How many miles did you run today?");
    //    var response = Console.ReadLine();

    //    // Convert response into a double (Number)
    //    isParsable = double.TryParse(response, out milesRanToday);

    //} while (isParsable == false);

    //Console.WriteLine($"Whoah! You ran {milesRanToday} miles today!");

        
        static void Miles(string[] args)
        {
            double milesRanToday = GetValidMilesRan();

            Console.WriteLine($"Whoah! You ran {milesRanToday} miles today!");
        }

        static double GetValidMilesRan()
        {
            double milesRanToday = 0;
            bool isParsable;

            do
            {
                Console.WriteLine("How many miles did you run today?");
                var response = Console.ReadLine();

                // Convert response into a double (Number)
                isParsable = double.TryParse(response, out milesRanToday);

                if (!isParsable)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isParsable);

            return milesRanToday;
        }
    









}
    }
