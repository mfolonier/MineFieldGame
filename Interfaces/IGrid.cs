using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineField_game.Interfaces
{
    public interface  IGrid
    {
        void Generate();
        ISquare[,] CreateGrid(int startPosX = 0);
        bool SquareUp();
        bool SquareDown();
        bool SquareLeft();
        bool SquareRight();
        ISquare CurrentSquare();
        ISquare FinalSquare();
    }
}
