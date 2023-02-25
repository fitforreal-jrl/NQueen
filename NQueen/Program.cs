using System;

namespace NQueen
{
    class Program
    {
        static void Main(string[] args)
        {            
            NQueen queen = new NQueen();
            queen.Search(4);
        }
    }
}
