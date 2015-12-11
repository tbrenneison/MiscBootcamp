using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cgol3;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LivesWithFourLiveNeighbors()
        {
            Cell cell = new Cell();
            List<Cell> list = new List<Cell>();
            list.Add(new Cell { IsCurrentlyAlive = true });
            list.Add(new Cell { IsCurrentlyAlive = true });
            list.Add(new Cell { IsCurrentlyAlive = true });
            list.Add(new Cell { IsCurrentlyAlive = true });
            Assert.IsFalse(cell.IsAliveInNextGeneration(list));  
        }

        [TestMethod]
        public void LivesWithThreeLiveNeighbors()
        {
            Cell cell = new Cell();
            List<Cell> list = new List<Cell>();
            list.Add(new Cell { IsCurrentlyAlive = true });
            list.Add(new Cell { IsCurrentlyAlive = true });
            list.Add(new Cell { IsCurrentlyAlive = true });
            list.Add(new Cell { IsCurrentlyAlive = false });
            Assert.IsTrue(cell.IsAliveInNextGeneration(list));
        }

        [TestMethod]
        public void LivesWithTwoLiveNeighbors()
        {
            Cell cell = new Cell();
            List<Cell> list = new List<Cell>();
            list.Add(new Cell { IsCurrentlyAlive = true });
            list.Add(new Cell { IsCurrentlyAlive = true });
            list.Add(new Cell { IsCurrentlyAlive = false });
            list.Add(new Cell { IsCurrentlyAlive = false });
            Assert.IsTrue(cell.IsAliveInNextGeneration(list));
        }

        [TestMethod]
        public void LivesWithOneLiveNeighbor()
        {
            Cell cell = new Cell();
            List<Cell> list = new List<Cell>();
            list.Add(new Cell { IsCurrentlyAlive = true });
            list.Add(new Cell { IsCurrentlyAlive = false });
            list.Add(new Cell { IsCurrentlyAlive = false });
            list.Add(new Cell { IsCurrentlyAlive = false });
            Assert.IsFalse(cell.IsAliveInNextGeneration(list));
        }
    }
}
