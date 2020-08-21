using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Chica";
            int dogAge = 2;
            char firstLetter = 'C';
            bool isNice = true;
            double bone = 3;
            decimal weight = 45m;

            Console.WriteLine($"Hell {dogName}. \n" +
                $"Welcome to the vet. \n" +
                $"Says here you are {dogAge} and you weigh {weight}lbs.\n" +
                $"{isNice}, you are a nice dog. \n" +
                $"Since the first letter in your name is {firstLetter}.\n" +
                $"We will give you {bone} bones today");
        }
    }
}
