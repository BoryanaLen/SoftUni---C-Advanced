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
                int input = int.Parse(Console.ReadLine());

                Box<int> currentBox = new Box<int>(input);

                Console.WriteLine(currentBox.ToString());
            }
        }
    }
}
