using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is a tic tac toe simulator
//Trek Lewis, Kit Mori, JD Mestanze, Cole Hardy

namespace Mission3Group
{
    class Driver
    {
        static void Main(string[] args)
        {
            //DRIVER CLASS CODE GOES HERE
            //Welcome player
            Console.WriteLine("Welcome to our tic tac toe game :-)");

            //Initialize board array
            char[,] board = new char[3, 3]
            {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'}
            };

            //Print board (call supporting class)
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + "\t");
                }
                Console.WriteLine();
            } 

            //Get player names
            Console.Write("Enter Player One's name: ");
            string p1 = Console.ReadLine();
            Console.Write("Enter Player Two's name: ");
            string p2 = Console.ReadLine();

            //Declare turn variable
            bool winner = false;
            bool turn = true;
            int spot = 0;
            char mark = 'X';

            //While loop for 
            while (winner == false)
            {
                //Declare taken and missed turn variables
                bool taken = false;
                bool missturn = true;

                //Get moves
                if (turn == true)
                {
                    Console.Write(p1 + "'s" + " turn\nSelect spot 1-9 (ex. 7): ");
                    spot = Int32.Parse(Console.ReadLine());
                    mark = 'X';
                    missturn = turn;
                    turn = false;
                }

                else if (turn == false)
                {
                    Console.Write(p2 + "'s" + " turn\nSelect spot 1-9 (ex. 7): ");
                    spot = Int32.Parse(Console.ReadLine());
                    mark = 'O';
                    missturn = turn;
                    turn = true;
                }

                //Update board
                if (spot < 4)
                {
                    spot = spot - 1;
                    if (board[0, spot] == 'X' || board[0, spot] == 'O')
                    {
                        Console.Write("That spot is taken, pick a new number.");
                        taken = true;
                        turn = missturn;
                    }
                    else
                    {
                        board[0, spot] = mark;
                    }

                }
                else if (spot < 7)
                {
                    spot = spot - 4;
                    if (board[1, spot] == 'X' || board[1, spot] == 'O')
                    {
                        Console.Write("That spot is taken, pick a new number.");
                        turn = missturn;
                        taken = true;
                    }
                    else
                    {
                        board[1, spot] = mark;
                    }
                }
                else
                {
                    spot = spot - 7;
                    if (board[2, spot] == 'X' || board[2, spot] == 'O')
                    {
                        Console.Write("That spot is taken, pick a new number.");
                        turn = missturn;
                        taken = true;
                    }
                    else
                    {
                        board[2, spot] = mark;
                    }
                }

                //print board (call supporting function)
                if (taken == false)
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
            }
        }
    }
}
