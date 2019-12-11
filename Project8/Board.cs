/// Richard Carmona-Andrade
/// Project 8
/// Thursday / 4:30 p.m.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    /// <summary>
    /// enum to holf the turns value
    /// </summary>
    public enum PieceColor { empty, black, red };

    /// <summary>
    /// Class that has the rules for the board
    /// </summary>
    public class Board
    {
        /// <summary>
        /// variable tp hold row value
        /// </summary>
        private const int row = 6;
        /// <summary>
        /// variable to hold column value
        /// </summary>
        private const int Column = 7;
        /// <summary>
        /// the array for board
        /// </summary>
        private PieceColor[,] grid;


        /// <summary>
        /// Constructor for the class
        /// </summary>
        public Board()
        {
            grid = new PieceColor[row, Column];
            Turn = PieceColor.red;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    grid[i, j] = PieceColor.empty;
                }
            }
        }

        /// <summary>
        /// gets the value of the current turn field
        /// </summary>
        public PieceColor Turn { get; private set; }

        /// <summary>
        /// returns the value at position [x,y] in the field array
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PieceColor GetColor(int x, int y)
        {
            return grid[x, y];
        }

        /// <summary>
        /// returns whether the given player has four in a row, column, or diagonal
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool IsWinner(PieceColor player)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < Column - 3; j++)
                {
                    if (grid[i, j] == grid[i, j + 1] && grid[i, j] == grid[i, j + 2] && grid[i, j] == grid[i, j + 3] && grid[i, j] == player)
                    {
                        return true;
                    }
                }
            }

            for (int j = 0; j < Column; j++)
            {
                for (int i = 0; i < row - 3; i++)
                {
                    if (grid[i, j] == grid[i + 1, j] && grid[i, j] == grid[i + 2, j] && grid[i, j] == grid[i + 3, j] && grid[i, j] == player)
                    {
                        return true;
                    }
                }
            }

            for (int i = 0; i < row - 3; i++)
            {
                for (int j = 0; j < Column - 3; j++)
                {
                    if (grid[i, j] == grid[i + 1, j + 1] && grid[i, j] == grid[i + 2, j + 2] && grid[i, j] == grid[i + 3, j + 3] && grid[i, j] == player)
                    {
                        return true;
                    }
                }
            }

            for (int i = row - 1; i < row - 3; i--)
            {
                for (int j = 0; j < Column - 3; j++)
                {
                    if (grid[i, j] == grid[i - 1, j + 1] && grid[i, j] == grid[i - 2, j + 2] && grid[i, j] == grid[i - 3, j + 3] && grid[i, j] == player)
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        /// <summary>
        /// returns whether the board is full
        /// </summary>
        /// <returns></returns>
        public bool CheckTie()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (grid[i, j] != PieceColor.empty)
                    {
                        return false;
                    }
                    
                }
            }
            return true;
        }

        /// <summary>
        /// switches the turn field between (from red to black or black to red)
        /// </summary>
        public void SwitchTurns()
        {
            if (Turn == PieceColor.black) Turn = PieceColor.red;

            else Turn = PieceColor.black;

        }

        /// <summary>
        /// Checks to see if the move was valid
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        private bool IsValidMove(int col)
        {
            if (grid[0, col] == PieceColor.empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// drops a piece of the current turn color into the given column. Returns whether the move was successful
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool Move(int col)
        {
            int row_2 = getRow(col);
            if (IsValidMove(col))
            {
                grid[row_2, col] = Turn;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        private int getRow(int col)
        {
            for (int i = row - 1; i >= 0; i--)
            {
                if (grid[i, col] == PieceColor.empty)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}
