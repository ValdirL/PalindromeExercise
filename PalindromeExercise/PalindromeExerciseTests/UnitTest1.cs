using PalindromeExercise;
using System;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hello", false)]
        public void IsAPalidrome(string word, bool expected)
        {
            //Arrange
            var tester = new WordSmith();

            //Act
            bool actual = tester.IsAPalidrome(word);  

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
