using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEKHOLOA_Tankiso_POE
{
    internal class Program
    {
        //declaration of ingredient details variables 
         Ingredients obj1 = new Ingredients();
        static int ingreDetails = 0;
        int numSteps;
        double scale;


        

        static void Main(string[] args)
        {
            

            Console.WriteLine("=== PRODUCT DETAILS === "); //reminder add with colour

            string[] arrIngredients = new string[1];       //array that captures the user's input
            for (int i = 0; i < arrIngredients.Length; i++)
            { 
                arrIngredients[i] = Console.ReadLine();
                Console.WriteLine(arrIngredients[i]);
            
                Console.WriteLine("Enter the number of ingredients: \t");
                //arrIngredients[i] =
                Console.ReadLine();

                Console.WriteLine("Enter the name of ingredient 1: \n");
                Console.ReadLine();

                Console.WriteLine("Enter the quantity of ingredient 1: \n");
                Console.ReadLine();

                Console.WriteLine("Enter the unit measurement of ingredient 1: \n");
                Console.ReadLine();

                Console.WriteLine("Enter the name of ingredient 2: \n");
                Console.ReadLine();

                Console.WriteLine("Enter the quantity of ingredient 2: \n");
                Console.ReadLine();

                Console.WriteLine("Enter the unit measurement of ingredient 2: \n");
                Console.ReadLine();
            }
            Console.WriteLine("=== STEPS === "); //reminder add with color

            {

                Console.WriteLine("Enter the number of steps for the recipe: ");
                Console.ReadLine();
                
            }

            Console.WriteLine("=== STEP DESCRIPTIONS === \n");

            string[] arrStepdescr = new string[1];
            for (int j = 0; j < arrStepdescr.Length; j++) 

            {

                Console.WriteLine("~For each step a description must be provided~ ");

                Console.WriteLine("Enter the description for the first step : \n");
                Console.ReadLine();

                Console.WriteLine("Enter the description for the second step : \n");
                Console.ReadLine();

                Console.WriteLine("Enter the description for the third step : \n");
                Console.ReadLine();

                Console.WriteLine("Enter the description for the fourth step : \n");
                Console.ReadLine();

                Console.WriteLine("Enter the description of the fifth step : \n");
                Console.ReadLine();
            }

            }

      










    } 
}
