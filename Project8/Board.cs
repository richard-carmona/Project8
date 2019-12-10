using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{ 
    /// <summary>
    /// 
    /// </summary>
    public enum PieceColor { empty, black, red };

    /// <summary>
    /// 
    /// </summary>
    public class Board
    {
        /// <summary>
        /// 
        /// </summary>
        private const int row = 6;
        /// <summary>
        /// 
        /// </summary>
        private const int Column = 7;
        /// <summary>
        /// 
        /// </summary>
        private PieceColor[,] grid;
        

        /// <summary>
        /// 
        /// </summary>
        public Board()
        {
            grid = new PieceColor[row, Column];
            Turn = PieceColor.red;

            for(int i = 0; i <= row ; i++)
            {
                for(int j = 0; j <= Column ; j++)
                {
                    grid [i,j] = PieceColor.empty;
                }
            }
    }

        /// <summary>
        /// 
        /// </summary>
        public PieceColor Turn { get; private set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PieceColor GetColor(int x, int y)
        {
            return grid[x, y];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool IsWinner(PieceColor player)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < Column; j++){ 
                if (grid[i,j] == grid[i, j+1] && grid[i,j] == grid[i,j +2] && grid[i,j] == grid[i,j + 3] && grid[i,j] == player)
                {
                return true;
                }
            else
                {
                return false;
                }
                }
            }

            for (int j = 0; j < Column; j++)
            {
                for (int i = 0; i < row - 3; i++)
                {
                    if (grid[i, j] == grid[i, j + 1] && grid[i, j] == grid[i, j + 2] && grid[i, j] == grid[i, j + 3] && grid[i, j] == player)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < Column - 4; j++)
                {
                    if (grid[i, j] == grid[i, j + 1] && grid[i, j] == grid[i, j + 2] && grid[i, j] == grid[i, j + 3] && grid[i, j] == player)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckTie()
        {
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < Column; j++)
                {
                    if (grid[i,j] != PieceColor.empty)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void SwitchTurns()
        {
            if(Turn == PieceColor.black) Turn = PieceColor.red;
            
            else Turn = PieceColor.black;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        private bool IsValidMove(int col)
        {
            if (grid[0,col] == PieceColor.empty)
            {
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
        public bool Move(int col)
        {
            if (IsValidMove(col)) {
                return true;
        }
            else
            {
                return false;
            }
        }
    }
}
