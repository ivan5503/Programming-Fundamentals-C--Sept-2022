using System;

namespace Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double weightPig = double.Parse(Console.ReadLine()) * 1000;


            for (int i = 1; i <= 30; i++)
            {
                food -= 300;

                if (i % 2 == 0)
                {
                    double consumedHay = food * 5 / 100;
                    hay -= consumedHay;
                }
                if (i % 3 == 0)
                {
                    cover -= weightPig / 3;
                }
            }
            if (food >= 0 && hay >= 0 && cover >= 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food / 1000:f2}, Hay: {hay / 1000:f2}, Cover: {cover / 1000:f2}.");

            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
