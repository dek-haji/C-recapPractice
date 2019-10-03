using System;
using System.Collections.Generic;

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
            foreach( string product in Products){
                if(product.Length < 5){
                    Console.WriteLine($"{product} has a short names");
                }else if(product.Length < 10){
                    Console.WriteLine($"{product} has a medium-sized names");
                }else {
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
        }
    }
}
