    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineField_game.Interfaces;
namespace MineField_game
{
    public class Player : IPlayer
    {
        private IDraw _draw;
        private IGrid _grid;
        private int _lives;
        private int _moves = 0;

       

        public Player(IDraw draw, IGrid grid)   
        {
            _lives = CONSTANTS.maxLives;
            _draw = draw;
            _grid = grid;
                       
        }
        public bool Alive()
        {
            if (_lives > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ReduceLives()
        {
            _lives--;
            
        }

        public void Reset()
        {
            _lives = CONSTANTS.maxLives;
            _moves = 0; 

        }

        public bool Finished()
        {
            return _grid.CurrentSquare() == _grid.FinalSquare();
        }

        public int Moves()
        {
            return _moves;
        }

        public void MoveDown()
        {
            if (_grid.SquareDown())
            {
                Move();
            }
        }

        public void MoveLeft()
        {
            if (_grid.SquareLeft())
            {
                Move();
            }
        }

        public void MoveRight()
        {
            if (_grid.SquareRight())
            {
                Move();
            }
        }

        public void MoveUp()
        {
            if (_grid.SquareUp())
            {
                Move();
            }
        }
        public int Lives ()
        {
            return _lives;
        }

        private void Move()
        {
            _moves++;
            _draw.DrawMoves(_moves);
           // _grid.GetMineProximity();
            _grid.CurrentSquare().Current(this, _draw);

            if (!Finished())
                _draw.DrawLives(_lives);

            if (_lives == 0)
                _draw.DrawGameOver();
        }


    }
}
