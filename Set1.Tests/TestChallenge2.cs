using System;
using Xunit;

namespace Set1.Tests
{
    public class TestChallenge2
    {
        [Fact]
        public void TestFixedXOR()
        {
            // Arrange
            string input1 = "1c0111001f010100061a024b53535009181c";
            string input2 = "686974207468652062756c6c277320657965";
            string expected = "746865206b696420646f6e277420706c6179";

            // Act
            string actual = Challenge2.FixedXOR(input1, input2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
