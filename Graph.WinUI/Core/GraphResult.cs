namespace Graph.Core;

public sealed record GraphResult(double[] XValues, double[] YValues)
{
    public int PointCount => XValues.Length;
}
