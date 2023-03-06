using System;
namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakeAndLadder Game");
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.DieRoll();
        }
    }
}
