using FluentAssertions;
using Xunit;

namespace RockPaperScissors.Test
{
    public class RockPaperScissorsGameTests
    {
        [Fact]
        public void RockCrushesScissors()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.DetermineWinner("rock", "scissors");

            actual.Should().Be("rock");
        }
    }
}