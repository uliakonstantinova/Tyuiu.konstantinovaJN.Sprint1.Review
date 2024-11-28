using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonstantinovaJN.Sprint1.TaskReview.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double e = Math.Pow(y, 2) + Math.Cos(Math.Pow(x, 3)) + 12 * x * y - 3 * Math.Pow(x, 2);
            double r = Math.Cos((Math.Pow(x, 3)) + 3) + 18 * y - 1;
            double u = e / r;
            double res = Math.Exp(x) - u;

            return Math.Round(res, 3);
        }
    }
}
 