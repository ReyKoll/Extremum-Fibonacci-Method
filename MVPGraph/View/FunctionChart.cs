using System;
using System.Globalization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace MVPGraph.View;

/// <summary>
/// Лёгкий график одной функции: оси, сетка, полилиния.
/// Данные передаются через SetPoints(double[]) в формате [x1, y1, x2, y2, ...].
/// </summary>
public class FunctionChart : Control
{
    private const double ChartMargin = 40;

    public static readonly StyledProperty<IBrush> LineBrushProperty =
        AvaloniaProperty.Register<FunctionChart, IBrush>(nameof(LineBrush), Brushes.DodgerBlue);

    public IBrush LineBrush
    {
        get => GetValue(LineBrushProperty);
        set => SetValue(LineBrushProperty, value);
    }

    private double[] _points = Array.Empty<double>();

    public void SetPoints(double[] points)
    {
        _points = points ?? Array.Empty<double>();
        InvalidateVisual();
    }

    public void Clear()
    {
        _points = Array.Empty<double>();
        InvalidateVisual();
    }

    public override void Render(DrawingContext context)
    {
        var size = Bounds;
        if (size.Width < 2 * ChartMargin || size.Height < 2 * ChartMargin) return;

        double minX, maxX, minY, maxY;
        if (_points.Length >= 4)
        {
            minX = maxX = _points[0];
            minY = maxY = _points[1];
            for (int i = 2; i < _points.Length; i += 2)
            {
                double x = _points[i], y = _points[i + 1];
                if (x < minX) minX = x;
                if (x > maxX) maxX = x;
                if (y < minY) minY = y;
                if (y > maxY) maxY = y;
            }
            // всегда показываем немного места под/над нулём по Y
            minY = Math.Min(minY, -0.1 * (maxY - minY) - 0.1);
            maxY = Math.Max(maxY, 0.1 * (maxY - minY) + 0.1);
        }
        else
        {
            minX = -10; maxX = 10; minY = -6; maxY = 6;
        }

        if (maxX - minX < 1e-9) maxX = minX + 1;
        if (maxY - minY < 1e-9) maxY = minY + 1;

        double w = size.Width - ChartMargin;
        double h = size.Height - ChartMargin;
        double sx = w / (maxX - minX);
        double sy = h / (maxY - minY);

        double Px(double x) => ChartMargin + (x - minX) * sx;
        double Py(double y) => ChartMargin + h - (y - minY) * sy;

        var gridPen = new Pen(Brushes.Gainsboro, 0.5);
        var axisPen = new Pen(Brushes.Gray, 1);
        var linePen = new Pen(LineBrush, 1.5);
        var typeface = new Typeface(Typeface.Default.FontFamily, FontStyle.Normal, FontWeight.Normal);
        var labelBrush = Brushes.DimGray;

        FormattedText MakeText(string s) =>
            new(s, CultureInfo.InvariantCulture, FlowDirection.LeftToRight, typeface, 10, labelBrush);

        // Вертикальная сетка + подписи по X
        string Fmt(double v) => v.ToString(v > 10 || v < -10 ? "0" : "0.##", CultureInfo.InvariantCulture);
        double stepX = NiceStep(maxX - minX);
        for (double x = Math.Ceiling(minX / stepX) * stepX; x <= maxX; x += stepX)
        {
            double px = Px(x);
            context.DrawLine(gridPen, new Point(px, ChartMargin), new Point(px, ChartMargin + h));
            var label = MakeText(Fmt(x));
            context.DrawText(label, new Point(px - 8, ChartMargin + h + 4));
        }

        // Горизонтальная сетка + подписи по Y
        double stepY = NiceStep(maxY - minY);
        for (double y = Math.Ceiling(minY / stepY) * stepY; y <= maxY; y += stepY)
        {
            double py = Py(y);
            context.DrawLine(gridPen, new Point(ChartMargin, py), new Point(ChartMargin + w, py));
            var label = MakeText(Fmt(y));
            context.DrawText(label, new Point(ChartMargin - 34, py - 6));
        }

        // Оси через ноль, если он попадает в диапазон
        if (minX <= 0 && maxX >= 0)
            context.DrawLine(axisPen, new Point(Px(0), ChartMargin), new Point(Px(0), ChartMargin + h));
        if (minY <= 0 && maxY >= 0)
            context.DrawLine(axisPen, new Point(ChartMargin, Py(0)), new Point(ChartMargin + w, Py(0)));
        context.DrawLine(axisPen, new Point(ChartMargin, ChartMargin), new Point(ChartMargin, ChartMargin + h));

        if (_points.Length >= 4)
        {
            var geometry = new StreamGeometry();
            using (var ctx = geometry.Open())
            {
                ctx.BeginFigure(new Point(Px(_points[0]), Py(_points[1])), false);
                for (int i = 2; i < _points.Length; i += 2)
                    ctx.LineTo(new Point(Px(_points[i]), Py(_points[i + 1])));
            }
            context.DrawGeometry(null, linePen, geometry);
        }
        else
        {
            var hint = MakeText("Выберите функцию и нажмите «Построить график»");
            context.DrawText(hint, new Point(ChartMargin + 40, size.Height / 2));
        }
    }

    /// <summary>«Красивый» шаг сетки: 1/2/5 * 10^k.</summary>
    private static double NiceStep(double range)
    {
        double raw = range / 10;
        if (raw <= 0) return 1;
        double mag = Math.Pow(10, Math.Floor(Math.Log10(raw)));
        double norm = raw / mag;
        double nice = norm switch
        {
            < 1.5 => 1,
            < 3 => 2,
            < 7 => 5,
            _ => 10
        };
        return nice * mag;
    }
}
