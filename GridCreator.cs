using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineField_game.Interfaces;

namespace MineField_game
{
    public class GridCreator : IGrid

    {
		private IDraw _draw;
		private ISquare[,] _square;
		private ISquare _currentSquare;
		private ISquare _finishSquare;
		Random rnd = new Random();
		


		private int RandomNumber(int min = 0, int max = 0)
		{
			return rnd.Next(min, max);
		}

		public ISquare[,] CreateGrid( int startPosX = 0)
		{
			var squares = new ISquare[CONSTANTS.columns, CONSTANTS.rows];

			
			for (var x = 0; x < CONSTANTS.columns; x++)
			{
				for (var y = 0; y < CONSTANTS.rows; y++)
				{
					//Probability of a mine is (1/CONSTANTS.level)%. 
					var insertMine = RandomNumber(1, CONSTANTS.level + 1) == CONSTANTS.level ? true : false;

					if (x == startPosX & y == CONSTANTS.startPosY || !insertMine)
					{
						squares[x, y] = new Square(x, y, CONSTANTS.labels[x], null , false);
					}
					else
					{
						squares[x, y] = new Mine(x, y, CONSTANTS.labels[x], null, true);

					}
				}
			}

			return squares;
		}
		

	
		public GridCreator(IDraw draw)
		{
			 _draw = draw;
			
		}

		

		public void Generate()
		{

			var startPositionX =  RandomNumber(0, CONSTANTS.columns);
			var endPositionX = RandomNumber(0, CONSTANTS.columns);
			_square = CreateGrid(startPositionX);

			_currentSquare = _square[startPositionX, CONSTANTS.startPosY];

			_finishSquare = new FinalSquare(endPositionX, CONSTANTS.finalPosY, CONSTANTS.labels[endPositionX]);
			_square[endPositionX, CONSTANTS.finalPosY] = _finishSquare;


			Draw();

		}

		public void Draw()
		{
			_draw.Clear();
			_draw.DrawInitalMessage();
			_draw.DrawGrid(_square, _currentSquare, _finishSquare);
			_draw.DrawCurrentPos(_currentSquare);
		}

	

		public bool SquareUp()
		{
			if (_currentSquare.Ypos() < CONSTANTS.rows-1)
			{
				
				_currentSquare = _square[_currentSquare.Xpos(), _currentSquare.Ypos() + 1];
				Draw();
				return true;
			}
			return false;
		}

		public bool SquareDown()
		{
			if (_currentSquare.Ypos() > 0)
			{

				_currentSquare = _square[_currentSquare.Xpos(), _currentSquare.Ypos() - 1];
				Draw();
				return true;
			}
			return false;
		}

		public bool SquareLeft()
		{
			if (_currentSquare.Xpos() > 0)
			{

				_currentSquare = _square[_currentSquare.Xpos()-1, _currentSquare.Ypos()];
				Draw();
				return true;
			}
			return false;
		}

		public bool SquareRight()
		{
			if (_currentSquare.Xpos() < CONSTANTS.columns - 1)
			{

				_currentSquare = _square[_currentSquare.Xpos() + 1, _currentSquare.Ypos()];
				Draw();
				return true;
			}
			return false;
		}
				

		public ISquare CurrentSquare()
		{
			return _currentSquare;
		}

		public ISquare FinalSquare()
		{
			return _finishSquare;
		}

		
	}
}
