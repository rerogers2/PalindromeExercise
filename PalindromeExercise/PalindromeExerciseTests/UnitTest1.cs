using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("tacocat", true)]
        [InlineData("mom", true)]
        [InlineData("mother", false)]
        [InlineData("amanaplanacanalpanama", true)]
        [InlineData("",false)]
        [InlineData("racecar",true)]
        [InlineData("RaCEcaR", true)]
        [InlineData("mOTheR", false)]
        public void PalindromeTest(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
