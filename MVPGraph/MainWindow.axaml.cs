using System;
using System.Text.RegularExpressions;
using Avalonia.Controls;
using Avalonia.Interactivity;
using MVPGraph.Presenter;
using MVPGraph.View;

namespace MVPGraph;

/// <summary>
/// Окно приложения. Реализует IExtremumView — единственная точка связи
/// с презентером, который не знает про Avalonia.
/// </summary>
public partial class MainWindow : Window, IExtremumView
{
    private static readonly Regex NumericRegex = new(@"^-?\d*([.,]\d*)?$", RegexOptions.Compiled);

    private readonly ExtremumPresenter _presenter;

    public MainWindow()
    {
        InitializeComponent();
        _presenter = new ExtremumPresenter(this);

        // Один общий валидатор вместо четырёх copy-paste KeyPress-обработчиков
        AttachNumericValidation(TxtA);
        AttachNumericValidation(TxtB);
        AttachNumericValidation(TxtH);
        AttachNumericValidation(TxtEpsilon);
    }

    // --- IExtremumView ---

    string IExtremumView.TxtA { get => TxtA.Text ?? ""; set => TxtA.Text = value; }
    string IExtremumView.TxtB { get => TxtB.Text ?? ""; set => TxtB.Text = value; }
    string IExtremumView.TxtH { get => TxtH.Text ?? ""; set => TxtH.Text = value; }
    string IExtremumView.TxtEpsilon { get => TxtEpsilon.Text ?? ""; set => TxtEpsilon.Text = value; }
    string IExtremumView.TxtFX { get => TxtFX.Text ?? ""; set => TxtFX.Text = value; }
    string IExtremumView.TxtMaxY { get => TxtMaxY.Text ?? ""; set => TxtMaxY.Text = value; }
    string IExtremumView.TxtMinY { get => TxtMinY.Text ?? ""; set => TxtMinY.Text = value; }
    string IExtremumView.TxtMaxX { get => TxtMaxX.Text ?? ""; set => TxtMaxX.Text = value; }
    string IExtremumView.TxtMinX { get => TxtMinX.Text ?? ""; set => TxtMinX.Text = value; }

    public void ShowChart(double[] points) => Chart.SetPoints(points);

    // --- Обработчики ---

    private void OnDrawClick(object? sender, RoutedEventArgs e)
    {
        SetStatus("");
        var f = GetSelectedFunction();
        var mode = RbMin.IsChecked == true ? ExtremumMode.Minimum : ExtremumMode.Maximum;
        _presenter.Calculate(f, mode, ShowWarning);
    }

    private void OnClearClick(object? sender, RoutedEventArgs e)
    {
        _presenter.Clear();
        Chart.Clear();
        SetStatus("");
    }

    private Func<double, double> GetSelectedFunction() => RbSin.IsChecked == true ? FMath.Function.Sin
        : RbCos.IsChecked == true ? FMath.Function.Cos
        : RbParabola.IsChecked == true ? FMath.Function.Parabola
        : FMath.Function.Line;

    private void ShowWarning(string message) => SetStatus(message);

    /// <summary>Статус-бар появляется только с сообщением — пустых красных линий нет.</summary>
    private void SetStatus(string message)
    {
        StatusText.Text = message;
        StatusBar.IsVisible = !string.IsNullOrEmpty(message);
    }

    private void AttachNumericValidation(TextBox box)
    {
        box.TextInput += (_, args) =>
        {
            string candidate = box.Text == null || box.CaretIndex == 0
                ? args.Text
                : box.Text.Insert(Math.Min(box.CaretIndex, box.Text.Length), args.Text);
            if (!NumericRegex.IsMatch(candidate))
                args.Handled = true;
        };
    }
}
