using System;
using MVPGraph.Model;
using MVPGraph.View;

namespace MVPGraph.Presenter
{
    /// <summary>
    /// Презентер: читает параметры из вью, считает через модель, пишет результаты обратно.
    /// Не зависит ни от WinForms, ни от Avalonia — только от IExtremumView.
    /// </summary>
    public class ExtremumPresenter
    {
        private const double DefaultA = -10.0;
        private const double DefaultB = 10.0;
        private const double DefaultH = 0.1;
        private const double DefaultEpsilon = 0.001;

        private readonly IExtremumView _view;

        public ExtremumPresenter(IExtremumView view) => _view = view;

        /// <summary>
        /// Единственный метод расчёта: раньше было 4 копипаста (Sin/Cos/Parabola/Line),
        /// отличавшихся только функцией. Min/max вычисляются за один проход по сетке,
        /// а не O(n^2) вызовов FindMax/FindMin на каждую добавленную точку.
        /// </summary>
        public void Calculate(Func<double, double> f, ExtremumMode mode, Action<string> warn)
        {
            var extremum = ReadParameters(warn);
            if (extremum == null) return;

            if (extremum.B == extremum.A)
            {
                warn("Точки A и B совпадают — использован интервал по умолчанию [−10; 10]");
                extremum.A = DefaultA;
                extremum.B = DefaultB;
            }
            else if (extremum.B < extremum.A)
            {
                warn("Точка B меньше точки A — границы интервала поменены местами");
                (extremum.A, extremum.B) = (extremum.B, extremum.A);
            }

            if (extremum.H > extremum.B - extremum.A)
                warn("Шаг H больше длины интервала — min/max вычислены по единственной точке");

            if (extremum.Epsilon > extremum.B - extremum.A)
                warn("Точность ε больше длины интервала — результат будет очень грубым");

            // Ни одно исключение модели не должно ронять приложение —
            // нормальный график важнее падения. Ошибку показываем в статусе.
            try
            {
                _view.TxtFX = (mode == ExtremumMode.Minimum
                    ? extremum.FindMinimum(f)
                    : extremum.FindMaximum(f)).ToString("0.0000");

                var (minY, maxY, minX, maxX) = extremum.FindBounds(f);
                _view.TxtMinY = minY.ToString("0.00");
                _view.TxtMaxY = maxY.ToString("0.00");
                _view.TxtMinX = minX.ToString("0.00");
                _view.TxtMaxX = maxX.ToString("0.00");

                // Отрисовка НЕ зависит от шага H: фиксированное число точек,
                // чтобы кривая была гладкой при любом (даже грубом) шаге расчёта min/max
                _view.ShowChart(SampleSmooth(f, extremum.A, extremum.B));
            }
            catch (Exception ex)
            {
                warn("Ошибка расчёта: " + ex.Message);
            }
        }

        public void Clear()
        {
            _view.TxtA =
            _view.TxtB =
            _view.TxtH =
            _view.TxtEpsilon =
            _view.TxtFX =
            _view.TxtMaxY =
            _view.TxtMinY =
            _view.TxtMaxX =
            _view.TxtMinX = string.Empty;
        }

        /// <summary>Разбор параметров; пустые поля заменяются дефолтами (как в оригинале).</summary>
        private Extremum ReadParameters(Action<string> warn)
        {
            double a = ParseOr(_view.TxtA, DefaultA, out bool aDefault);
            double b = ParseOr(_view.TxtB, DefaultB, out bool bDefault);
            double h = ParseOr(_view.TxtH, DefaultH, out bool hDefault);
            double eps = ParseOr(_view.TxtEpsilon, DefaultEpsilon, out bool eDefault);

            if (aDefault || bDefault || hDefault || eDefault)
                warn($"Незаполненные поля заменены значениями по умолчанию:\nA = {DefaultA}, B = {DefaultB}, шаг = {DefaultH}, точность = {DefaultEpsilon}");

            if (h <= 0) { warn("Шаг H должен быть положительным — установлен 0.1"); h = DefaultH; }
            if (eps <= 0) { warn("Точность должна быть положительной — установлена 0.001"); eps = DefaultEpsilon; }

            return new Extremum { A = a, B = b, H = h, Epsilon = eps };
        }

        private static double ParseOr(string text, double fallback, out bool usedDefault)
        {
            if (double.TryParse((text ?? "").Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture,
                    out double value))
            {
                usedDefault = false;
                return value;
            }
            usedDefault = true;
            return fallback;
        }

        /// <summary>Равномерная выборка функции: 1001 точка на [a, b] —
        /// гладкая кривая независимо от пользовательского шага H.</summary>
        private static double[] SampleSmooth(Func<double, double> f, double a, double b)
        {
            const int count = 1001; // нечётный запас: 1000 сегментов (+1 точка)
            var pts = new double[2 * count];
            double step = (b - a) / (count - 1);
            for (int i = 0; i < count; i++)
            {
                double x = a + i * step;
                pts[2 * i] = x;
                pts[2 * i + 1] = f(x);
            }
            return pts;
        }
    }
}
