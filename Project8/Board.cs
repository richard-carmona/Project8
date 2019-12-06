using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    class Board
    {
        public enum PieceColor { empty, black, red};

        public PieceColor Turn { get; }
        
        public PieceColor GetColor(int x, int y)
        {
            //if grid[x,y] is black 
            return PieceColor.black;
            PieceColor.
        }

        public bool IsWinner(PieceColor player)
        {

        }

        public bool CheckTie()
        {

        }

        public void SwitchTurns()
        {

        }

        public bool Move(int col)
        {

        }

    }
    public enum PieceColor { empty, red, black };

}
