using System;
using Xunit;
using Xunit.Sdk;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]

        [InlineData("racecar", true)]
        [InlineData("crazy", false)]
        [InlineData("foof", true)]
        [InlineData("lalapaloo", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange

            var testForPalindrome = new WordSmith();

            var actual = testForPalindrome.IsAPalindrome(word);


                //Assert

            Assert.Equal(expected, actual);
        }
    }
}
