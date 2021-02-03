using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineField_game.Interfaces;

namespace MineField_game
{
    public class Square : ISquare
    {
        private string _id;
        private int _xPos;
        private int _yPos;
        private string _xLabel;
        private string _yLabel;
        private bool _mine;

        public Square(int x, int y, string xLabel = null, string yLabel = null , bool mine=false)
        {
            _xPos = x;
            _yPos = y;

            if (xLabel != null)
                _xLabel = xLabel;
            else _xLabel = x.ToString();

            if (yLabel != null)
                _yLabel = yLabel;
            //Need to set this to + 1 here as the console needs to print starting from 1 not 0
            else _yLabel = (y + 1).ToString();

            _id = _xLabel + _yLabel;

            _mine = mine;

        }


        public int Xpos() { return _xPos; }
        public int Ypos() { return _yPos; }
        public string Xlabel() { return _xLabel; }
        public string Ylabel() { return _yLabel; }
        public string Id() { return _id; }
        public bool Mine() {  return _mine; }
        public virtual void Current(IPlayer player, IDraw draw)
        {
           
        }

        
    }
}
