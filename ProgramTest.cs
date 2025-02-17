using System;
using Xunit;

public class ProgramTest
{
    [Fact]
    public void Subtracao_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = Subtracao(a, b);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Subtracao_TwoNegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        int a = -5;
        int b = -3;

        // Act
        int result = Subtracao(a, b);

        // Assert
        Assert.Equal(-2, result);
    }

    [Fact]
    public void Subtracao_PositiveAndNegativeNumber_ReturnsCorrectResult()
    {
        // Arrange
        int a = 5;
        int b = -3;

        // Act
        int result = Subtracao(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtracao_NegativeAndPositiveNumber_ReturnsCorrectResult()
    {
        // Arrange
        int a = -5;
        int b = 3;

        // Act
        int result = Subtracao(a, b);

        // Assert
        Assert.Equal(-8, result);
    }

    private int Subtracao(int a, int b)
    {
        return a - b;
    }
}