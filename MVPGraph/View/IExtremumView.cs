namespace MVPGraph.View
{
    /// <summary>Контракт вью для MVP: презентер не знает о конкретном UI-фреймворке.</summary>
    public interface IExtremumView
    {
        string TxtA { get; set; }
        string TxtB { get; set; }
        string TxtH { get; set; }
        string TxtEpsilon { get; set; }

        string TxtFX { get; set; }
        string TxtMaxY { get; set; }
        string TxtMinY { get; set; }
        string TxtMaxX { get; set; }
        string TxtMinX { get; set; }

        /// <summary>Точки графика как массив [x1, y1, x2, y2, ...] — presenter отдаёт данные, вью их рисует.</summary>
        void ShowChart(double[] points);
    }

    /// <summary>Режим отображения результата: минимум или максимум.</summary>
    public enum ExtremumMode
    {
        Minimum,
        Maximum
    }
}
