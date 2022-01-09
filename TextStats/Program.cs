using System;
using System.Resources;

namespace CP
{
    class Program
    {
        static void Main(string[] args)
        {   // Path to testFile.txt must be changed to your download
            Algorithm algorithm = new 
                Algorithm(@"C:\Users\cmsmr2\Desktop\TextStats\TextStats\testfile.txt");
            algorithm.GetCharFrequency();
            algorithm.GetWordFrequency();



            Console.WriteLine("Hello World!");
        }
    }
}
