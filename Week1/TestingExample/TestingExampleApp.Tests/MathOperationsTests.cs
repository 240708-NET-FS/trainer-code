using TestingExampleApp;

namespace TestingExampleApp.Tests;

public class MathOperationsTests
{

    /*
        AAA Pattern

        Arrange
            - Setting up your tests and anything that you need to actually complete the test
        Act
            - The action you are actually trying to test for
        Assert
            - The validation to see if things worked correctly

    */

    // private MathOperations mathOperations = new MathOperations();

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        MathOperations mathOperations = new MathOperations();

        // Act
        int result = mathOperations.Add(1, 2);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectValue()
    {
        // Arrange
        MathOperations mathOperations = new MathOperations();

        // Act
        int result = mathOperations.Subtract(4, 2);

        // Assert
        Assert.Equal(2, result);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, -2, -3)]
    [InlineData(0, 0, 0)]
    [InlineData(100, 200, 300)]
    public void Add_ShouldReturnCorrectSumBetter(int a, int b, int expected)
    {
        // Arrange
        MathOperations mathOperations = new MathOperations();

        // Act
        int result = mathOperations.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}