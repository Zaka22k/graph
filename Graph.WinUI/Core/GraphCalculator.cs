using org.mariuszgromada.math.mxparser;

namespace Graph.Core;

/// <summary>
/// Evaluates a single-variable mXparser expression over a validated X range.
/// </summary>
public sealed class GraphCalculator
{
    public const int MaximumPointCount = 200_000;

    public GraphResult Calculate(string function, GraphParameters parameters)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(function);
        ArgumentNullException.ThrowIfNull(parameters);
        ValidateParameters(parameters);

        var argument = new Argument("x");
        var expression = new Expression(function, argument);

        if (!expression.checkSyntax())
            throw new FormatException(expression.getErrorMessage());

        var expectedCount = (int)Math.Ceiling(
            (parameters.XMax - parameters.XMin) / parameters.Step) + 1;

        var xValues = new List<double>(Math.Min(expectedCount, MaximumPointCount));
        var yValues = new List<double>(Math.Min(expectedCount, MaximumPointCount));

        for (var index = 0; index < expectedCount; index++)
        {
            var x = parameters.XMin + index * parameters.Step;
            if (x > parameters.XMax)
                break;

            argument.setArgumentValue(x);
            var y = expression.calculate();

            // Undefined values (for example 1/x at x=0) create gaps instead of
            // poisoning the whole series with NaN or Infinity.
            if (!double.IsFinite(y))
                continue;

            xValues.Add(x);
            yValues.Add(y);
        }

        if (xValues.Count == 0)
            throw new InvalidOperationException(
                "Функция не имеет конечных значений в заданном диапазоне.");

        return new GraphResult(xValues.ToArray(), yValues.ToArray());
    }

    private static void ValidateParameters(GraphParameters p)
    {
        if (!double.IsFinite(p.XMin) || !double.IsFinite(p.XMax) ||
            !double.IsFinite(p.YMin) || !double.IsFinite(p.YMax) ||
            !double.IsFinite(p.Step))
            throw new ArgumentOutOfRangeException(nameof(p),
                "Параметры графика должны быть конечными числами.");

        if (p.XMin >= p.XMax)
            throw new ArgumentException("Xmin должен быть меньше Xmax.");

        if (p.YMin >= p.YMax)
            throw new ArgumentException("Ymin должен быть меньше Ymax.");

        if (p.Step <= 0)
            throw new ArgumentException("Шаг H должен быть больше нуля.");

        var pointCount = (p.XMax - p.XMin) / p.Step;
        if (!double.IsFinite(pointCount) || pointCount > MaximumPointCount - 1)
            throw new ArgumentException(
                $"Слишком много точек. Увеличьте H: максимум {MaximumPointCount:N0} точек.");
    }
}
