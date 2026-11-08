namespace Graph.Core;

public sealed record GraphParameters(
    double XMin,
    double XMax,
    double YMin,
    double YMax,
    double Step)
{
    public static GraphParameters Default { get; } =
        new(-2 * Math.PI, 2 * Math.PI, -5, 5, 0.01);
}
