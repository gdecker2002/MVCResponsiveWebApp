using System;
using MVCResponsiveWebApp;
using Xunit;

namespace ResponsiveWebAppUnitTest
{

    public class WebAppUnitTest
    {
        [Fact]
        public void InputYear()
        {
            // Arrange
            int yearOfBirth = 2002;
            int expected = 19;
            int actual;

            // Act
            actual = Program.AgeThisYear(yearOfBirth);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void BadInput()
        {
            // Arrange
            int yearOfBirth = 1899;
            int expected = 0;
            int actual;

            // Act
            actual = Program.AgeThisYear(yearOfBirth);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
