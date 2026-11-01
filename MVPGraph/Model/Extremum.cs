using System;
using System.Globalization;

namespace MVPGraph.Model
{
    /// <summary>
    /// Поиск минимума/максимума унимодальной функции методом Фибоначчи
    /// плюс поиск min/max по сетке значений (для отображения на графике).
    /// </summary>
    public class Extremum
    {
        public double A { get; set; }
        public double B { get; set; }
        public double H { get; set; }
        public double Epsilon { get; set; } = 0.001;

        /// <summary>
        /// Классический метод Фибоначчи: сужение интервала [A, B],
        /// пока его длина не станет меньше Epsilon.
        /// Сложность: O(log((B - A) / Epsilon)) вычислений функции.
        /// </summary>
        public double FindMinimum(Func<double, double> f)
        {
            ValidateInterval();

            double a = A, b = B;
            double length = b - a;

            // n: F(n) >= (b - a) / eps — число итераций, заданное точностью
            int n = FMath.Fibonacci.IndexFor(length / Math.Max(Epsilon, 1e-12));
            if (n < 3) n = 3;

            double fibN = FMath.Fibonacci.Get(n);
            double x1 = a + (FMath.Fibonacci.Get(n - 2) / fibN) * length;
            double x2 = a + (FMath.Fibonacci.Get(n - 1) / fibN) * length;
            double f1 = f(x1);
            double f2 = f(x2);

            // k-я итерация работает со стадией m = n-k; точки пересчитываются
            // в пропорциях стадии m' = m-1: x1 = a + G(m'-2)/G(m')·L', x2 = a + G(m'-1)/G(m')·L'
            for (int k = 1; k <= n - 2; k++)
            {
                double fibM = FMath.Fibonacci.Get(n - k - 1); // G(m') — знаменатель следующей стадии
                double fibMm2 = FMath.Fibonacci.Get(n - k - 3); // G(m'-2)
                double fibMm1 = FMath.Fibonacci.Get(n - k - 2); // G(m'-1)

                if (f1 <= f2)
                {
                    // минимум слева от x2
                    b = x2;
                    x2 = x1;
                    f2 = f1;
                    x1 = a + (fibMm2 / fibM) * (b - a);
                    f1 = f(x1);
                }
                else
                {
                    // минимум справа от x1
                    a = x1;
                    x1 = x2;
                    f1 = f2;
                    x2 = a + (fibMm1 / fibM) * (b - a);
                    f2 = f(x2);
                }
            }

            return (a + b) / 2;
        }

        /// <summary>Максимум функции f на [A, B] = минимум от -f.</summary>
        public double FindMaximum(Func<double, double> f) => FindMinimum(x => -f(x));

        /// <summary>
        /// Минимум и максимум по сетке значений с шагом H — один проход вместо
        /// четырёх отдельных сканирований (FindMax/FindMin по каждой координате).
        /// </summary>
        public (double MinY, double MaxY, double MinX, double MaxX) FindBounds(Func<double, double> f)
        {
            double minY = double.MaxValue, maxY = double.MinValue;
            double minX = A, maxX = A;

            for (double x = A; x <= B; x += H)
            {
                double y = f(x);
                if (y < minY) { minY = y; minX = x; }
                if (y > maxY) { maxY = y; maxX = x; }
            }
            return (minY, maxY, minX, maxX);
        }

        private void ValidateInterval()
        {
            if (B <= A)
                throw new ArgumentException("Точка B должна быть строго больше точки A");
        }
    }
}
