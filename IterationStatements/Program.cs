namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
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

            var i = 0;

            while (i < 9)
            {
                if(i % 2 ==0)
                {
                    Console.WriteLine(i);

                }
                i++;

            }

    }   }
}
