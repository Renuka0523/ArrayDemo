using System.ComponentModel.DataAnnotations;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new[] { 1, 2, 3, 4, 5, 6 };

            //length

            Console.WriteLine("length of:" + number.Length);

            //Index of

            var index = Array.IndexOf(number, 3);
            Console.WriteLine("index of:" + index);

            //Clear

            Array.Clear(number, 0, 3);
            Console.WriteLine("Effect of Clear()");

            foreach (var n in number) 
            Console.WriteLine(n);

            //Copy
             int [] another = new int [3];
            Array.Copy(number, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);
        }
    }
}
