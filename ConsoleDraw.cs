using System;

using MineField_game.Interfaces;

namespace MineField_game
{
    public class ConsoleDraw : IDraw
    {
           
        public void DrawGrid(ISquare[,] squares, ISquare currentSquare, ISquare finalSquare)
        {
           

            Console.CursorVisible = false;

            Console.WriteLine();

            for (var y = CONSTANTS.rows - 1; y >= 0; y--)
            {
                Console.Write(" ");
                Console.Write(squares[0, y].Ylabel());
                Console.Write(" ");
                for (var x = 0; x < CONSTANTS.columns; x++)
                {
                    if (squares[x, y] == currentSquare && !squares[x,y].Mine())
                        Console.Write(CONSTANTS.currentPosition);
                    else if (squares[x, y] == finalSquare)
                        Console.Write(CONSTANTS.finalPosition);
                    else if (squares[x, y] == currentSquare && squares[x, y].Mine())
                        Console.Write(CONSTANTS.mineSquare);
                    else
                        Console.Write(CONSTANTS.emptySquare);
                }
                Console.WriteLine();
            }

            Console.Write("    ");

            for (var x = 0; x < CONSTANTS.columns; x++)
            {
                Console.Write(squares[x, 0].Xlabel());
                Console.Write("  ");
            }

            Console.WriteLine();
            Console.WriteLine();


        }

        public void DrawInitalMessage()
        {
            Console.WriteLine(CONSTANTS.helloMessage);
            Console.WriteLine();
            Console.WriteLine(CONSTANTS.instructionsMessage);
            Console.WriteLine();
        }

        public void DrawMine()
        {
            Console.WriteLine(CONSTANTS.hitMessage);
           
           
        }

        public void DrawLives(int lives)
        {
            Console.WriteLine($"You have {lives} lives");
        }

        public void DrawMoves(int moves)
        {
            Console.WriteLine($"You have done {moves} movements");
        }

        public void Clear()
        {

            Console.Clear();
        }

        public void DrawCurrentPos(ISquare currentSquare)
        {
            Console.WriteLine($"Current position: {currentSquare.Id()}");
        }

        public void DrawFinal(int moves)
        {
            Console.WriteLine();
            Console.WriteLine(CONSTANTS.congratMessage);
            Console.WriteLine($"You won through {moves} moves.");
            Console.WriteLine(CONSTANTS.optionMessage);
            

        }

        public void DrawGameOver()
        {
            Console.WriteLine();
            Console.WriteLine(CONSTANTS.loserMessage);
            Console.WriteLine(CONSTANTS.optionMessage);

        }
    }
}
