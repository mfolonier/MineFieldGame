using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineField_game.Interfaces;

namespace MineField_game
{
    public class FinalSquare : Square
    {
        public FinalSquare(int x, int y, string xLabel = null, string yLabel = null, bool mine= false) : base(x, y, xLabel, yLabel, mine)
        {
        }
        public override void Current(IPlayer player, IDraw draw)
        {

            draw.DrawFinal(player.Moves());
            
        }

    }
}
