using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Ivan");

            int[] integers = ArrayCreator.Create(10, 1);
        }
    }
}
