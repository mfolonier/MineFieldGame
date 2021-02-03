using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineField_game.Interfaces
{
    public interface  IPlayer
    {
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void ReduceLives();
        void Reset();
        bool Finished();
        bool Alive();
        int Moves();
       

    }
}
