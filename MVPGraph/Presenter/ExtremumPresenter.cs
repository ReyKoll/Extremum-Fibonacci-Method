using MVPGraph.Model;
using MVPGraph.View;
using System;

namespace MVPGraph.Presenter
{
    public class ExtremumPresenter
    {
        public double X { get; set; }
        public double FX { get; set; }

        // Объект
        readonly Extremum extremum = new Extremum();

        // Экземпляр из Интерфейса
        private readonly IExtremum _view;

        // Конструктор
        public ExtremumPresenter(IExtremum view)
        {
            _view = view;
        }

        // Метод связи модели и окна
        private void Update()
        {
            if (
                _view.TxtA == ""
                || _view.TxtB == ""
                || _view.TxtH == ""
                || _view.TxtEpsilon == ""
                )
            {
                SetDefaultParams();
                ShowDefaultParamsMessage();
            }
            else
            {
                extremum.A = Convert.ToDouble(_view.TxtA);
                extremum.B = Convert.ToDouble(_view.TxtB);
                extremum.H = Convert.ToDouble(_view.TxtH);
                extremum.Epsilon = Convert.ToDouble(_view.TxtEpsilon);
            }
        }

        private void SetDefaultParams()
        {
            extremum.A = -10.0;
            extremum.B = 10.0;
            extremum.H = 0.1;
            extremum.Epsilon = 0.001;
        }

        private void ShowDefaultParamsMessage()
        {
            System.Windows.Forms.MessageBox.Show("A = -10, B = 10, Шаг = 0.1, Точность = 0.001", "Внимание",
            System.Windows.Forms.MessageBoxButtons.OK,
            System.Windows.Forms.MessageBoxIcon.Exclamation);
        }

        private void ShowInvalidEnterError()
        {
            if (extremum.B <= extremum.A)
                System.Windows.Forms.MessageBox.Show("Точка B не может быть меньше или равной точке А", "Ошибка",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
        }

        private void Sin(MainWindow window)
        {
            X = extremum.A;
            while (X <= extremum.B)
            {
                FX = FMath.Function.Sin(X);
                window.chrtGraph.Series[0].Points.AddXY(X, FX);
                X += extremum.H;
                var dataPointMax = window.chrtGraph.Series[0].Points.FindMaxByValue();
                var dataPointMin = window.chrtGraph.Series[0].Points.FindMinByValue();
                var xValueMax = dataPointMax.XValue;
                var xValueMin = dataPointMin.XValue;
                _view.TxtMaxX = xValueMax.ToString("0.00");
                _view.TxtMinX = xValueMin.ToString("0.00");
                _view.TxtMaxY = extremum.Max(FMath.Function.Sin).ToString("0.00");
                _view.TxtMinY = extremum.Min(FMath.Function.Sin).ToString("0.00");
            }
            _view.TxtFX = extremum.Find(FMath.Function.Sin).ToString("0.0000");
        }

        private void Cos(MainWindow window)
        {
            X = extremum.A;
            while (X <= extremum.B)
            {
                FX = FMath.Function.Cos(X);
                window.chrtGraph.Series[0].Points.AddXY(X, FX);
                X += extremum.H;
                var dataPointMax = window.chrtGraph.Series[0].Points.FindMaxByValue();
                var dataPointMin = window.chrtGraph.Series[0].Points.FindMinByValue();
                var xValueMax = dataPointMax.XValue;
                var xValueMin = dataPointMin.XValue;
                _view.TxtMaxX = xValueMax.ToString("0.00");
                _view.TxtMinX = xValueMin.ToString("0.00");
                _view.TxtMaxY = extremum.Max(FMath.Function.Cos).ToString("0.00");
                _view.TxtMinY = extremum.Min(FMath.Function.Cos).ToString("0.00");
            }
            _view.TxtFX = extremum.Find(FMath.Function.Cos).ToString("0.0000");
        }

        private void Parabola(MainWindow window)
        {
            X = extremum.A;
            while (X <= extremum.B)
            {
                FX = FMath.Function.Parabola(X);
                window.chrtGraph.Series[0].Points.AddXY(X, FX);
                X += extremum.H;
                var dataPointMax = window.chrtGraph.Series[0].Points.FindMaxByValue();
                var dataPointMin = window.chrtGraph.Series[0].Points.FindMinByValue();
                var xValueMax = dataPointMax.XValue;
                var xValueMin = dataPointMin.XValue;
                _view.TxtMaxX = xValueMax.ToString("0.00");
                _view.TxtMinX = xValueMin.ToString("0.00");
                _view.TxtMaxY = extremum.Max(FMath.Function.Parabola).ToString("0.00");
                _view.TxtMinY = extremum.Min(FMath.Function.Parabola).ToString("0.00");
            }
            _view.TxtFX = extremum.Find(FMath.Function.Parabola).ToString("0.0000");
        }

        private void Line(MainWindow window)
        {
            X = extremum.A;
            while (X <= extremum.B)
            {
                FX = FMath.Function.Line(X);
                window.chrtGraph.Series[0].Points.AddXY(X, FX);
                X += extremum.H;
                var dataPointMax = window.chrtGraph.Series[0].Points.FindMaxByValue();
                var dataPointMin = window.chrtGraph.Series[0].Points.FindMinByValue();
                var xValueMax = dataPointMax.XValue;
                var xValueMin = dataPointMin.XValue;
                _view.TxtMaxX = xValueMax.ToString("0.00");
                _view.TxtMinX = xValueMin.ToString("0.00");
                _view.TxtMaxY = extremum.Max(FMath.Function.Line).ToString("0.00");
                _view.TxtMinY = extremum.Min(FMath.Function.Line).ToString("0.00");
            }
            _view.TxtFX = extremum.Find(FMath.Function.Line).ToString("0.0000");
        }

        // Метод расчета функций
        public void Calculate(MainWindow window)
        {
            Update();
            ShowInvalidEnterError();

            if (window.rbtSin.Checked)
                Sin(window);

            if (window.rbtCos.Checked)
                Cos(window);

            if (window.rbtParabola.Checked)
                Parabola(window);

            if (window.rbtLine.Checked)
                Line(window);
        }

        public bool IsRadioButtonChecked(MainWindow window)
        {
            if (
                window.rbtSin.Checked == false
                && window.rbtCos.Checked == false
                && window.rbtParabola.Checked == false
                && window.rbtLine.Checked == false
                && window.rbtMax.Checked == false
                && window.rbtMin.Checked == false
                )
            {
                System.Windows.Forms.MessageBox.Show("По умолчанию выбрана функция Sin(x)", "Внимание",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Exclamation);

                window.rbtSin.Checked = true;
                window.rbtMax.Checked = true;
            }
            return true;
        }

        public void AnyTextBoxEmpty()
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
    }
}
