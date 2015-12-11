using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NotLivingWithoutNeighbors()
        {
            var result = new Cell().WillBeAliveInNextGeneration(0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ComesToLifeWithThreeNeighbors()
        {
            var result = new Cell().WillBeAliveInNextGeneration(3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DiesWithoutEnoughNeighbors()
        {
            var result = new Cell(true).WillBeAliveInNextGeneration(1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LivesOnWithTwoNeighbors()
        {
            var result = new Cell(true).WillBeAliveInNextGeneration(2);
            Assert.IsTrue(result); 
        }

        [TestMethod]
        public void DoesNotComeToLifeWithOnlyTwoLivingNeighbors()
        {
            var result = new Cell(false).WillBeAliveInNextGeneration(2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DiesWithMoreThanThreeNeighbors()
        {
            var result = new Cell(true).WillBeAliveInNextGeneration(4);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ComesToLifeWithExactlyThreeNeighbors()
        {
            var result = new Cell(false).WillBeAliveInNextGeneration(3);
            Assert.IsTrue(result); 
        }
    }

    internal class Cell
    {
        public bool Living { get; set; }
        public Cell(bool isAlive = false){
            Living = isAlive;
        }
        internal bool WillBeAliveInNextGeneration(int numberOfLivingNeighbors)
        {
            if (Living && numberOfLivingNeighbors == 2) return true;
            return numberOfLivingNeighbors == 3;
        }
    }
}
