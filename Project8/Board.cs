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

        public PieceColor[] grid = new PieceColor[6, 7];

        public PieceColor Turn { get; }
        
        public PieceColor GetColor(int x, int y)
        {
            if([x,y] == PieceColor.black)
            {
                return PieceColor.black;
                PieceColor.black;
            } 
            
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
