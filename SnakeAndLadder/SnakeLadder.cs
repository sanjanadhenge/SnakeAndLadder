using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        //UC1
        const int No_Play = 0, Ladder = 1, Snake = 2, Winning_Position = 100;
        int playerPosition = 0,count = 0;
        //UC2
        Random random = new Random();
        public int DieRole()
        {
            int die = random.Next(1, 7);
            count++;
                return die;
        }
        //UC3
        public int Game()
        {
            while (this.playerPosition < Winning_Position)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case No_Play:
                        break;
                    case Ladder:
                        this.playerPosition = 0;
                        break;
                    case Snake:
                        int dieRole = DieRole();
                        if (this.playerPosition - dieRole > 0) 
                        {
                            this.playerPosition -= DieRole();
                           
                        }
                        break; 
                }
            }
            return playerPosition;
         }
        public void CheckWinner(int p1 , int p2)
        {
            if( p1 == 100 )
            {
                Console.WriteLine("Player1 is Winner");
            }
            else
            {
                Console.WriteLine("Player2 is Winner");
            }
        }


    }

}
