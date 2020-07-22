using System;
using Xunit;

namespace Set1.Tests
{
    public class TestChallenge1
    {
        [Fact]
        public void TestHexToBase64Converter()
        {
            // Arrange
            string expected = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";
            string input = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";

            // Act
            string actual = Challenge1.HexToBase64(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
