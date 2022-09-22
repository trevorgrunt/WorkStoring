using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лагранж
{
    class Lagrange
    {
        private double l(int i, double[] X, double h, double x)
        {
            double l = 1;
            for (int j = 0; j < X.Length; j++)
            {
                if (j != i)
                {
                    l *= (x - X[0] - j * h) / (i - j);
                }
            }
            return l / Math.Pow(h, X.Length - 1);
        }

        public double GetValue(double[] X, double h, double[] Y, double x)
        {
            double y = 0;
            for (int j = 0; j < X.Length; j++)
            {
                y += Y[j] * l(j, X, h, x);
            }
            return y;
        }
    }
}
