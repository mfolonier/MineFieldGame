using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MineField_game;
using MineField_game.Interfaces;


namespace MineField_GameUnitTesting
{
    [TestClass]
    public class UnitTestGame
    {

        [TestMethod]
        public void TestofPlayerlives()
        {

            var player = new Player(new DrawTest(), new GridTest());
            player.ReduceLives();
            Assert.AreEqual(CONSTANTS.maxLives - 1, player.Lives());


        }
        [TestMethod]
        public void TestofPlayerMoves()
        {
            
            var player = new Player(new DrawTest(), new GridTest());
            player.MoveUp();
            Assert.AreEqual(1,player.Moves());
        }

        [TestMethod]
        public void TestOfReset()
        {
            var player = new Player(new DrawTest(), new GridTest());
            player.Reset();
            Assert.AreEqual(CONSTANTS.maxLives, player.Lives());
            Assert.AreEqual(0, player.Moves());
        }


        [TestMethod]
        public void TestOfFinish()
        {
            
            var draw = new DrawTest();
            var grid = new GridCreator(draw);
            var player = new Player(draw, grid);
            var square = grid.CreateGrid(2);
            var initSquare = square[2, CONSTANTS.finalPosY];
            var finalSquare = new FinalSquare(2, CONSTANTS.finalPosY, CONSTANTS.labels[2]);


            Assert.IsTrue(player.Finished());           

        }


        [TestMethod]
        public void TestOfAlive()
        {

            var player = new Player(new DrawTest(), new GridTest());

            player.ReduceLives();
            Assert.IsTrue(player.Alive());
            player.ReduceLives();
            Assert.IsTrue(player.Alive());
            player.ReduceLives();
            Assert.IsFalse(player.Alive());
            
        }


        [TestMethod]
        public void TestOfGenerateInitialPosition()
        {
           
            var grid = new GridCreator(new DrawTest());
            grid.Generate();
            var initSquare = grid.CurrentSquare();
            var finalSquare = grid.FinalSquare();
            Assert.IsTrue(initSquare.Xpos() >= 0 && initSquare.Xpos() < CONSTANTS.columns && initSquare.Ypos() == CONSTANTS.startPosY);
            Assert.IsTrue(finalSquare.Xpos() >= 0 && finalSquare.Xpos() < CONSTANTS.columns && finalSquare.Ypos() == CONSTANTS.finalPosY);
                             
        }

        [TestMethod]
        public void TestOfMoves()
        {
            var grid = new GridCreator(new DrawTest());
            grid.Generate();
            var testSquare = grid.CurrentSquare();

            while (testSquare.Id() != "A1")
            {
                grid.SquareLeft();
                testSquare = grid.CurrentSquare();

            }
           
            Assert.AreEqual("A1", testSquare.Id());

            grid.SquareRight();
            testSquare = grid.CurrentSquare();
            Assert.AreEqual("B1", testSquare.Id());

            grid.SquareUp();
            testSquare = grid.CurrentSquare();
            Assert.AreEqual("B2", testSquare.Id());

            grid.SquareLeft();
            testSquare = grid.CurrentSquare();
            Assert.AreEqual("A2", testSquare.Id());

            grid.SquareDown();
            testSquare = grid.CurrentSquare();
            Assert.AreEqual("A1", testSquare.Id());




        }

    }
}
