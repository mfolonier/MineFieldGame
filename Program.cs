using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineField_game
{
    public class Program
    {

        static void Main(string[] args)
        {
           

            var draw = new ConsoleDraw();
            var grid = new GridCreator(draw);
            Control.Init( grid,  new Player(draw,grid));
            
			Console.ReadLine();


           
        }


        
       


    }
}
