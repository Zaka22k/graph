using Graph.WinUI.ViewModels;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Windows.UI;
using System.ComponentModel;
using Windows.Graphics;
using WinRT.Interop;

namespace Graph.WinUI;

public sealed partial class MainWindow : Window
{
    public MainViewModel ViewModel { get; } = new();

    private ScottPlot.Plottables.Scatter? _graphScatter;
    private string _graphColor = "#76B9ED";
    private bool _isErrorDialogOpen;

    public MainWindow()
    {
        InitializeComponent();

        ExtendsContentIntoTitleBar = true;
        SetTitleBar(AppTitleBar);
        ResizeWindow();

        ViewModel.PropertyChanged += OnViewModelPropertyChanged;

        ConfigurePlotTheme();
        RootGrid.ActualThemeChanged += RootGrid_ActualThemeChanged;
        ApplyAxisSettings();
        PlotControl.Refresh();
    }

    private void ResizeWindow()
    {
        var windowHandle = WindowNative.GetWindowHandle(this);
        var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
        var appWindow = AppWindow.GetFromWindowId(windowId);
        appWindow.Resize(new SizeInt32(1000, 600));
    }

    private void RootGrid_ActualThemeChanged(FrameworkElement sender, object args)
    {
        ConfigurePlotTheme();
        PlotControl.Refresh();
    }

    private void ConfigurePlotTheme()
    {
        var plot = PlotControl.Plot;
        var isDarkTheme = RootGrid.ActualTheme == ElementTheme.Dark;

        var backgroundColor = ScottPlot.Color.FromHex(
            isDarkTheme ? "#202020" : "#F3F3F3");
        var axisColor = ScottPlot.Color.FromHex(
            isDarkTheme ? "#A0A0A0" : "#606060");
        var gridColor = ScottPlot.Color.FromHex(
            isDarkTheme ? "#3A3A3A" : "#D6D6D6");

        plot.FigureBackground.Color = backgroundColor;
        plot.DataBackground.Color = backgroundColor;
        plot.Axes.Color(axisColor);
        plot.Grid.MajorLineColor = gridColor;

        plot.XLabel(string.Empty);
        plot.YLabel(string.Empty);
        plot.Axes.Frame(false);
        plot.FigureBorder = new() { Width = 0 };
        plot.DataBorder = new() { Width = 0 };
    }

    private void ApplyAxisSettings()
    {
        var plot = PlotControl.Plot;

        plot.Axes.SetLimits(
            ViewModel.LastParameters.XMin,
            ViewModel.LastParameters.XMax,
            ViewModel.LastParameters.YMin,
            ViewModel.LastParameters.YMax);

        plot.Axes.Bottom.TickGenerator =
            new ScottPlot.TickGenerators.NumericFixedInterval(ViewModel.LastXTickInterval);
        plot.Axes.Left.TickGenerator =
            new ScottPlot.TickGenerators.NumericFixedInterval(ViewModel.LastYTickInterval);

        PlotControl.Refresh();
    }

    private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(MainViewModel.ErrorMessage) &&
            !string.IsNullOrWhiteSpace(ViewModel.ErrorMessage))
        {
            _ = ShowErrorDialogAsync(ViewModel.ErrorMessage);
            return;
        }

        if (e.PropertyName == nameof(MainViewModel.LastParameters) ||
            e.PropertyName == nameof(MainViewModel.LastXTickInterval) ||
            e.PropertyName == nameof(MainViewModel.LastYTickInterval))
        {
            ApplyAxisSettings();
            return;
        }

        if (e.PropertyName != nameof(MainViewModel.CurrentGraph))
            return;

        PlotControl.Plot.Clear();
        _graphScatter = null;

        if (ViewModel.CurrentGraph is { } graph)
        {
            _graphScatter = PlotControl.Plot.Add.Scatter(graph.XValues, graph.YValues);
            _graphScatter.Color = ScottPlot.Color.FromHex(_graphColor);
            _graphScatter.LineWidth = 2;
            _graphScatter.MarkerSize = 0;
        }

        ApplyAxisSettings();
    }

    private async Task ShowErrorDialogAsync(string message)
    {
        if (_isErrorDialogOpen || RootGrid.XamlRoot is null)
            return;

        _isErrorDialogOpen = true;

        try
        {
            var messageText = new TextBlock
            {
                Text = message,
                TextWrapping = TextWrapping.Wrap,
                MaxWidth = 420
            };

            var dialog = new ContentDialog
            {
                XamlRoot = RootGrid.XamlRoot,
                Title = "Ошибка",
                Content = messageText,
                CloseButtonText = "Понятно"
            };

            await dialog.ShowAsync();
        }
        finally
        {
            _isErrorDialogOpen = false;
        }
    }

    private static Brush GetErrorBrush()
    {
        if (Application.Current.Resources.TryGetValue(
                "SystemFillColorCriticalBrush", out var resource) &&
            resource is Brush brush)
        {
            return brush;
        }

        return new SolidColorBrush(Color.FromArgb(255, 196, 43, 28));
    }

    private void FunctionHelpButton_Click(object sender, RoutedEventArgs e)
    {
        FunctionHelpTip.IsOpen = true;
    }

    private void ColorSwatch_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not FrameworkElement element ||
            element.Tag is not string colorHex)
            return;

        _graphColor = colorHex;

        if (_graphScatter is not null)
        {
            _graphScatter.Color = ScottPlot.Color.FromHex(_graphColor);
            PlotControl.Refresh();
        }
    }
}
