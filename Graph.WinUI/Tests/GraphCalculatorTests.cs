using Graph.Core;
using Xunit;

namespace Graph.Tests;

public sealed class GraphCalculatorTests
{
    private readonly GraphCalculator _calculator = new();

    [Fact]
    public void CalculatesQuadraticFunction()
    {
        var result = _calculator.Calculate("x^2", new GraphParameters(-1, 1, -1, 2, 1));

        Assert.Equal(3, result.PointCount);
        Assert.Equal(new[] { 1d, 0d, 1d }, result.YValues);
    }

    [Fact]
    public void RejectsZeroStep()
    {
        var parameters = new GraphParameters(-1, 1, -1, 1, 0);

        Assert.Throws<ArgumentException>(() => _calculator.Calculate("x", parameters));
    }

    [Fact]
    public void RejectsNegativeStep()
    {
        var parameters = new GraphParameters(-1, 1, -1, 1, -0.1);

        Assert.Throws<ArgumentException>(() => _calculator.Calculate("x", parameters));
    }

    [Fact]
    public void RejectsReversedXAxisRange()
    {
        var parameters = new GraphParameters(2, -2, -1, 1, 0.1);

        Assert.Throws<ArgumentException>(() => _calculator.Calculate("x", parameters));
    }

    [Fact]
    public void RejectsExcessivePointCount()
    {
        var parameters = new GraphParameters(-1, 1, -1, 1, 0.000001);

        Assert.Throws<ArgumentException>(() => _calculator.Calculate("x", parameters));
    }

    [Fact]
    public void RejectsInvalidExpression()
    {
        var parameters = new GraphParameters(-1, 1, -1, 1, 0.1);

        Assert.Throws<FormatException>(() => _calculator.Calculate("sin(", parameters));
    }
}
