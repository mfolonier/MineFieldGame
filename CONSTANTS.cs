using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineField_game
{
    public static class CONSTANTS
    {
        public const int columns = 8;
        public const int rows = 8;
        public const int maxLives = 3;
        public const int level = 5; // with level = 5 between 12 and 14 squares are mines 
        public const int startPosY = 0;
        public const int finalPosY = rows - 1;
        public const string currentPosition = "[X]";
        public const string finalPosition = "[O]";
        public const string emptySquare = "[ ]";
        public const string mineSquare = "[*]";

        public static readonly Dictionary<int, string> labels  = new Dictionary<int, string>{
                { 0, "A"}, { 1, "B"}, { 2, "C"}, { 3, "D"},
                { 4, "E"}, { 5, "F"}, { 6, "G"}, { 7, "H"},
                { 8, "I"}, { 9, "J"}, { 10, "K"}, { 11, "L"},
                { 12, "M"}, { 13, "N"}, { 14, "O"}, { 15, "P"},
                { 16, "Q"}, { 17, "R"}, { 18, "S"}, { 19, "T"},
                { 20, "U"}, { 21, "V"}, { 22, "W"}, { 23, "X"},
                { 24, "Y"}, { 25, "Z"}
         };



        public const string helloMessage = " Welcome to Minefield Game!! Reach the other side avoiding the mines. Good Luck!";
        public const string instructionsMessage = " Input your move (Left,Right,Up,Down) with the arrows";
        public const string hitMessage = "You've exploded a mine!";
        public const string congratMessage = "Congratulation, You win!!!";
        public const string loserMessage = "Game Over!! Try again... ";
        public const string optionMessage = "To play again, press Enter. To exit, press Escape";
    }
}
