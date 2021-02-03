using System;
using MineField_game.Interfaces;

namespace MineField_game
{
    public class Control 
    {

       public static void Init (IGrid grid,IPlayer player)
        {

            grid.Generate();
            while (player.Alive() && !player.Finished())
            {
                var move = Console.ReadKey();

                switch (move.Key)
                {
                    case ConsoleKey.UpArrow:
                        {

                            player.MoveUp();
                            
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            player.MoveDown();
                            break;
                        }
                    case ConsoleKey.LeftArrow:                    
                        {
                            player.MoveLeft();
                            break;
                        }
                    case ConsoleKey.RightArrow:                   
                        {
                            player.MoveRight();
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            grid.Generate();
                            player.Reset();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            return;
                        }
                }
            }


            Finish();


        }
        public static void Finish()
        {           
           

            var move = Console.ReadKey();
                                 
            switch (move.Key)
            {

                case ConsoleKey.Enter:
                {
                        var draw = new ConsoleDraw();
                        var grid = new GridCreator(draw);
                        Init(grid, new Player(draw, grid));
                        break;
                }
                case ConsoleKey.Escape:
                    {
                        return;
                    }
                default:
                    {
                        Finish();
                        break;
                    }
            }

        }


    }
}
