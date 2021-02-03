namespace MineField_game.Interfaces
{
    public interface IDraw
    {

       
        void DrawGrid(ISquare[,] squares, ISquare currentSquare, ISquare finalSquare);
        void DrawLives(int lives);
        void DrawCurrentPos(ISquare currentSquare);
        void DrawMoves(int moves);
        void DrawMine();
        void DrawGameOver();
        void DrawFinal(int moves);
        void DrawInitalMessage();
        void Clear();

    }
}
