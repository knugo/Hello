using System;

namespace Hello
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMassage01());

            Console.WriteLine(CreateMassage02());
        }

        public static string CreateMassage01()
        {
            return "Hello World!";
        }

        public static string CreateMassage02()
        {
            return "FUCK World!";
        }
    }
}
