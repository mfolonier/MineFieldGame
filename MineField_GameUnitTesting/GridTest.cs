using MineField_game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineField_game;


namespace MineField_GameUnitTesting
{
   public class GridTest : IGrid
    {

        private IDraw _draw;
        private ISquare[,] _square;
        private ISquare _currentSquare;
        private ISquare _finishSquare;
        Random rnd = new Random();

        public ISquare[,] CreateGrid(int startPosX = 0)
        {
            return new Square[0, 0];
        }

        public ISquare CurrentSquare()
        {
            return new Square(0, 0);
        }

        public ISquare FinalSquare()
        {
            return new Square(0, 0);
        }

        public void Generate()
        {
            _square = new Square[CONSTANTS.rows, CONSTANTS.columns];
            _currentSquare = new Square(0, 0);
            _finishSquare = new FinalSquare(0, 0);
        }

        public bool SquareDown()
        {
            return true;
        }

        public bool SquareLeft()
        {
            return true;
        }

        public bool SquareRight()
        {
            return true;
        }

        public bool SquareUp()
        {
            return true;
        }
    }
}
