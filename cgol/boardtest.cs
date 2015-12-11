using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace cgol
{
    [TestFixture]
    public class boardtest
    {
        [Test]
        public void can_create_new_board()
        {
            var board = new board();
            Assert.NotNull(board);
        }

        [Test]
        public void new_board_must_contain_one_cell_to_start_game()
        {
            var board = new board();
            var canStartGame = GameValidation.CanStartGame(board);
            Assert.True(canStartGame);
        }
    }
}
