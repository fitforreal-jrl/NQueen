using System;
using System.Text;

namespace NQueen
{
    class Program
    {
        enum MODE
        {
            TEST_MODE,
            SOLUTION_MODE
        }

        static void Main(string[] args)
        {
            NQueen queen = new NQueen();

            Console.WriteLine("Please slecte mode (1: solution mode 2: test mode)");
            var Mode = Console.ReadLine();
            if (Mode == "1") 
            {            
                Console.WriteLine("Please input number of queen to place.");
                byte bQueen = (byte)(Encoding.ASCII.GetBytes(Console.ReadLine())[0] - 48);               
                queen.execute(bQueen);
            }
            else
            {
                Console.WriteLine("Please input number of queen to test the sum of solution. ");
                byte bQueen = (byte)(Encoding.ASCII.GetBytes(Console.ReadLine())[0] -48);
                queen.test(bQueen);
            }
            
        }
    }
}
