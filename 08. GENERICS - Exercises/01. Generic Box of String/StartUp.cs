using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                string input = Console.ReadLine();

                Box<string> currentBox = new Box<string>(input);

                Console.WriteLine(currentBox.ToString());
            }
        }
    }
}
