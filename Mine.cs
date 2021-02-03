using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineField_game.Interfaces;


namespace MineField_game
{
    public class Mine : Square
    {
        public Mine(int x, int y, string _xLabel = null, string _yLabel = null , bool _mine= true) : base(x, y, _xLabel, _yLabel, _mine)
        {
            
        }

        public override void Current(IPlayer player, IDraw draw)
        {
         
            player.ReduceLives();
            draw.DrawMine();
           
            
        }

    }
}
