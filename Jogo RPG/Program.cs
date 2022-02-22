using System;
using Jogo_RPG.src.Entities;
namespace Jogo_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Knight("Arus", 23, "Knight", 1345, 45);
            
            Console.WriteLine(arus.ToString());
        }
    }
}
