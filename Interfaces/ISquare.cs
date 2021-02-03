using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineField_game.Interfaces
{
    public interface  ISquare
    {
        void Current(IPlayer player, IDraw draw);
        int Xpos();
        int Ypos();
        string Xlabel();
        string Ylabel();
        string Id();
        bool Mine();
    }
}
