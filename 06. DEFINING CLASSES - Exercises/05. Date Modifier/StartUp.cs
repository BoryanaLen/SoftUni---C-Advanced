using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = new DateModifier();

            string firstDate = Console.ReadLine();

            string secondDate = Console.ReadLine();

            Console.WriteLine(dateModifier.DifferenceBetweenDates(firstDate,secondDate));
        }
    }
}
