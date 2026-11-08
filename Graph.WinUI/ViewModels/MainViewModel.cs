using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Graph.Core;
using System.Globalization;

namespace Graph.WinUI.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly GraphCalculator _calculator = new();

    [ObservableProperty] private string _function = "sin(x)";
    [ObservableProperty] private string _xMin = "-6.28";
    [ObservableProperty] private string _xMax = "6.28";
    [ObservableProperty] private string _yMin = "-5";
    [ObservableProperty] private string _yMax = "5";
    [ObservableProperty] private string _xInterval = "4";
    [ObservableProperty] private string _yInterval = "0.5";
    [ObservableProperty] private string _step = "0.01";
    [ObservableProperty] private string _status = "Нажмите «Построить», чтобы вывести график.";
    [ObservableProperty] private string _errorMessage = string.Empty;
    [ObservableProperty] private GraphResult? _currentGraph;
    [ObservableProperty] private GraphParameters _lastParameters =
        new(-6.28, 6.28, -5, 5, 0.01);
    [ObservableProperty] private double _lastXTickInterval = 4;
    [ObservableProperty] private double _lastYTickInterval = 0.5;

    [RelayCommand]
    private void Plot()
    {
        ErrorMessage = string.Empty;

        try
        {
            var settings = ReadAxisSettings();
            var result = _calculator.Calculate(Function, settings.Parameters);

            LastXTickInterval = settings.XInterval;
            LastYTickInterval = settings.YInterval;
            LastParameters = settings.Parameters;
            CurrentGraph = result;
            Status = $"Построено точек: {result.PointCount:N0}";
        }
        catch (Exception ex) when (ex is ArgumentException or FormatException or
                                   InvalidOperationException)
        {
            ErrorMessage = ex.Message;
            Status = "Не удалось построить график";
        }
    }

    [RelayCommand]
    private void ApplyAxes()
    {
        ErrorMessage = string.Empty;

        try
        {
            var settings = ReadAxisSettings();

            LastXTickInterval = settings.XInterval;
            LastYTickInterval = settings.YInterval;
            LastParameters = settings.Parameters;
            Status = "Параметры осей обновлены";
        }
        catch (Exception ex) when (ex is ArgumentException or FormatException or
                                   InvalidOperationException)
        {
            ErrorMessage = ex.Message;
            Status = "Не удалось обновить оси";
        }
    }

    [RelayCommand]
    private void Clear()
    {
        CurrentGraph = null;
        ErrorMessage = string.Empty;
        Status = "График очищен";
    }

    private (GraphParameters Parameters, double XInterval, double YInterval) ReadAxisSettings()
    {
        var parameters = new GraphParameters(
            Parse(XMin, nameof(XMin)),
            Parse(XMax, nameof(XMax)),
            Parse(YMin, nameof(YMin)),
            Parse(YMax, nameof(YMax)),
            Parse(Step, nameof(Step)));

        var xInterval = Parse(XInterval, nameof(XInterval));
        var yInterval = Parse(YInterval, nameof(YInterval));

        if (!double.IsFinite(parameters.XMin) ||
            !double.IsFinite(parameters.XMax) ||
            !double.IsFinite(parameters.YMin) ||
            !double.IsFinite(parameters.YMax) ||
            !double.IsFinite(parameters.Step) ||
            !double.IsFinite(xInterval) ||
            !double.IsFinite(yInterval))
        {
            throw new ArgumentException("Все параметры должны быть конечными числами.");
        }

        if (parameters.XMin >= parameters.XMax)
            throw new ArgumentException("Минимальный X должен быть меньше максимального X.");

        if (parameters.YMin >= parameters.YMax)
            throw new ArgumentException("Минимальный Y должен быть меньше максимального Y.");

        if (parameters.Step <= 0)
            throw new ArgumentException("Плотность точек должна быть больше нуля.");

        if (xInterval <= 0 || yInterval <= 0)
            throw new ArgumentException("Интервалы разметки осей должны быть больше нуля.");

        return (parameters, xInterval, yInterval);
    }

    private static double Parse(string value, string fieldName)
    {
        if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture,
                out var parsed) ||
            double.TryParse(value, NumberStyles.Float, CultureInfo.CurrentCulture,
                out parsed))
            return parsed;

        throw new FormatException($"Поле {fieldName}: введите корректное число.");
    }
}
