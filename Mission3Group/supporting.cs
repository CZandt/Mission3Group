using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3Group
{
    class supporting
    {
        public void printBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Method to return the winner if there is one

        public int[] findWinner(char[,] board)
        {
            
            int[] determinates = { 0, 0 };

            // if there is a winner index 0 becomes 1

            // if index[0] is 1 then index 2 determines who is the winner 1 = player1 (X) , 2 = player2 (O)

            // check board rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && (board[i, 0] == 'X' || board[i, 0] == 'O'))
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
                    if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && (board[0, i] == 'X' || board[0, i] == 'O'))
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
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && (board[0, 0] == 'X' || board[0,0] == 'O'))
                {
                    determinates[0] = 1;
                    determinates[1] = board[0, 0];
                }
                else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && (board[0, 2] == 'X' || board[0,2] == 'O'))
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

