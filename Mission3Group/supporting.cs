using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3Group
{
    class supporting
    {
        private char[,] board = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

        public supporting( char[,] userBoard)
        {
            board = userBoard;
        }

        public void printBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.Write("\n");
            }
        }

        // Method to return the winner if there is one

        public int[] findWinner()
        {
            // find winners

            int[] determinates = { 0, 0 };
            
            // if there is a winner index 0 becomes 1

            // if index[0] is 1 then index 2 determines who is the winner 1 = player1 (X) , 2 = player2 (O)


            return determinates;
        }
    }
}
