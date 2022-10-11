using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6_Goto_Labels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InClassMathReview();

        } // Main

        public static void InClassMathReview()
        {
            //28.Mixing Multiplication and Division: There is a group of 10 people who are ordering pizza.If each person gets 2 slices and each pizza has 4 slices, how many pizzas should they order?
            
             try
            {
                Console.WriteLine("Pizza Calucating App");

                Console.Write("How many people: ");
                int numOfPeople = int.Parse(Console.ReadLine());

                Console.Write("\nHow many slices per person: ");
                int slicePerPerson = int.Parse(Console.ReadLine());

                Console.Write("\nHow many slices per pizza: ");
                int slicesPerPizza = int.Parse(Console.ReadLine());

                int numberOfSlicesNeeded = numOfPeople * slicePerPerson;
                double numOfPizzasNeeded = numberOfSlicesNeeded / (double)slicesPerPizza;


                Console.WriteLine($"THere are {numOfPeople} people" +
                    $"\nThat eat {slicePerPerson} slices each" +
                    $"\nEach pizza has {slicesPerPizza}" +
                    $"We need {numOfPizzasNeeded}");
            }
            catch
            {
                Console.WriteLine("Enter in the right values");
            }



        } // 


    } // class

} // namespace
