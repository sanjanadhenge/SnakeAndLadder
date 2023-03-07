using System;
namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakeAndLadder Game");
            SnakeLadder snakeLadder1 = new SnakeLadder();
            snakeLadder1.DieRole();
            int player1= snakeLadder1.Game();
            SnakeLadder snakeLadder2 = new SnakeLadder();
            snakeLadder2.DieRole();
            int player2= snakeLadder2.Game();
            snakeLadder2.CheckWinner( player1,player2);
        }
    }
}
