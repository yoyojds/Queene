using QueeneEngine;
using Xunit;

namespace QueeneEngineTests
{
	public class GameTests
    {
        [Fact]
        public void Test1()
        {
			var game = new Game();

			game.Start();
        }
    }
}
