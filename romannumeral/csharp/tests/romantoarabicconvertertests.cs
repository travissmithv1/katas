using FluentAssertions;
using Xunit;

namespace RomanToArabic.Test
{
    public class RomanToArabicConverterTests
    {
        [Fact]
        public void CanConvertXVItoSixteen()
        {
            var converter = new RomanToArabicConverter();

            var actual = converter.ConvertToInteger("XVI");

            actual.Should().Be(16);
        }
    }
}