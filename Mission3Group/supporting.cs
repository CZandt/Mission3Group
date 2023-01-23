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
            }
        }

        // Method to return the winner if there is one
    }
}
