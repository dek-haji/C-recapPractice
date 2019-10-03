using System;
using System.Collections.Generic;
using System.Linq;

namespace linqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime is the type of the purchaseData variable.
            // DateTime purchaseDate=DateTime.Now;

            // /*
            //     string is the type of the lastName variable. It
            //     tells the compiler that the lastName variable can
            //     ONLY hold a string value.
            // */
            // string lastName="Dek";

            // /*
            //     C# now supports implicitly typing of a variable. The
            //     type of the variable will be determined, by the
            //     compiler, at compile time.
            // */
            // var firstName="Haji";

            // /*
            //     String interpolation in C# is similar to string interpolation in JavaScript,
            //     but there is a different syntax.

            //     An equivalent statement in JavaScript would be:
            //     console.log(`${firstName} ${lastName} purchased on ${purchaseDate}`);
            // */
            // Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");


            List<string> Products = new List<string>(){
                "Sofa",
                "Cake",
                "Mirror",
                "random",
                "Iphone",
                "Imac",
                "Iwatch"
            };
            // //for each loop is used to iterate over a collection
            // foreach (string Product in Products){
            //     Console.WriteLine(Product);
            // }

            //   List<string> RandomStuff = new List<string>(){
            //     "Sofa",
            //     "Cake",
            //     "Mirror",
            //     "random",
            //     "Iphone",
            //     "Imac",
            //     "Iwatch"
            // };
            //for loop can be used to and to get the equavalent the foreach above
            // for (int i=0; i<RandomStuff.Count; i++){
            //     Console.WriteLine(RandomStuff[i]);
            // }

            //now lets use conditions in c#
            foreach (string product in Products)
            {
                if (product.Length < 5)
                {
                    Console.WriteLine($"{product} has a short names");
                }
                else if (product.Length < 10)
                {
                    Console.WriteLine($"{product} has a medium-sized names");
                }
                else
                {
                    Console.WriteLine($"{product} has a long names");
                }
            }
            //Dictionary is like objects in C# lets see how it works
            Dictionary<string, int> toys = new Dictionary<string, int>(){
                {"Hot Wheels", 344},
                {"Legos", 763},
                {"Gaming Consoles", 551},
                {"Board Games", 298}
            };
            toys.Add("Bicycle", 321);
            Console.WriteLine($"we have a number of toys of {toys.Count}");

            foreach (KeyValuePair<string, int> toy in toys)
            {
                Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
            }
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Good", "The feeling of students when they watching spaceX documentry");
            wordsAndDefinitions.Add("Amazing", "The feeling of students when they enjoying coding");

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"the definition is {word.Value} means {word.Key}");
            }

            //using LinQ
            // Language-Integrated Query is used to filter 
            List<int> cohortStudentCount = new List<int>()
        {
            25, 12, 28, 22, 11, 25, 27, 24, 19
        };
        IEnumerable<int> idealSize = from count in cohortStudentCount
            where count < 27 && count > 19
            orderby count ascending
            select count;
            foreach (int c in idealSize)
            {
                Console.WriteLine($"{c}");
            }
        // using aggregation method
        // there is build in methods that we can use to get what we looking
        Console.WriteLine($"Largest number is {cohortStudentCount.Max()}");
        Console.WriteLine($"the sum of the number is {cohortStudentCount.Sum()}");
        Console.WriteLine($"the minimum number is {cohortStudentCount.Min()}");

        // Linq and lambdas
        List<int> nums = new List<int>(){9, -59, 23, 71, -74, 13, 52, 44, 2};
        var smallPositiveNumbers = nums.Where(n => n < 40 && n > 0).OrderBy(n => n);
        foreach (int d in smallPositiveNumbers){
        Console.WriteLine($" using lambdas {d}");
        }
        //lets check if every item in the collection passes a condition
        List<int> sampleNumbers = new List<int> {18, 9, 5, 6, 84, 2, 5, 13};
        IEnumerable<int> onlyEvens = sampleNumbers.Where(number => number % 2 == 0);
       foreach (int even in onlyEvens)
       {
            Console.WriteLine($"the even numbers are {even}");
       }
       
        }
    }
}
