using System;

namespace MVPGraph.Model
{
    public class Extremum
    {
        public double A { get; set; }
        public double B { get; set; }
        public double H { get; set; }
        public double Epsilon { get; set; }

        public double Find(Func <double, double> f)
        {
            double x = A;
            int fibonacciNum = 1;

            while(FMath.Fibonacci.Get(fibonacciNum) < (Math.Abs(B - A) / Epsilon))
            {
                ++fibonacciNum;

                 x = A + (FMath.Fibonacci.Get(fibonacciNum - 2) / FMath.Fibonacci.Get(fibonacciNum)) * (B - A);
                 double x1 = A + B - x;

                // Поиск нового интервала
                for(int i = 2; i < fibonacciNum - 2; ++i)
                {
                    if (f(x) <= f(x1))
                    {
                        B = x1;
                        x1 = x;
                        x = A + (FMath.Fibonacci.Get(fibonacciNum - i - 3) / FMath.Fibonacci.Get(fibonacciNum - i - 1)) * (B - A);
                    }
                    else
                    {
                        A = x;
                        x = x1;
                        x1 = A + (FMath.Fibonacci.Get(fibonacciNum - i - 2) / FMath.Fibonacci.Get(fibonacciNum - i - 1)) * (B - A);
                    }
                    x1 = x + Epsilon;

                    if (f(x) <= f(x1))
                        B = x1;
                    else
                        A = x;
                }
            }
            return (A + B) / 2;
        }

        public double Max(Func<double, double> f)
        {
            double maxY = double.MinValue;
            for (double i = A; i <= B; i += H)
            {
                double y = f(i);
                if (maxY < y)
                    maxY = y;
            }
            return maxY;
        }

        public double Min(Func<double, double> f)
        {
            double minY = double.MaxValue;
            for (double i = A; i <= B; i += H)
            {
                double y = f(i);
                if (y < minY)
                    minY = y;
            }
            return minY;
        }
    }
}