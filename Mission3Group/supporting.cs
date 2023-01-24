using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3Group
{
    class supporting
    {
        private int[,] board = { { 0,0,0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        public supporting(int[,] userBoard)
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
            
            int[] determinates = { 0, 0 };

            // if there is a winner index 0 becomes 1

            // if index[0] is 1 then index 2 determines who is the winner 1 = player1 (X) , 2 = player2 (O)

            // check board rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
                {
                    determinates[0] = 1;
                    determinates[1] = board[i, 0];
                    break;
                }
            }

            // check columns
            if (determinates[0] == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != 0)
                    {
                        determinates[0] = 1;
                        determinates[1] = board[0, i];
                        break;
                    }
                }
            }

            // check diagonals
            if (determinates[0] == 0)
            {
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
                {
                    determinates[0] = 1;
                    determinates[1] = board[0, 0];
                }
                else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
                {
                    determinates[0] = 1;
                    determinates[1] = board[0, 2];
                }
            }
            if (determinates[0] == 1)
            {
                Console.WriteLine("Player " + determinates[1] + " won!");
                
            }
            return determinates;
        }
    }
}

