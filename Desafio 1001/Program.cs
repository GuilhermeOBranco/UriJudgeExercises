using System;
using System.Globalization;
using System.Threading;

namespace DesafiosUriJudge
{
    class Program
    {
        static void Main(string[] args)
        {

            var cultura = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = cultura;
            Thread.CurrentThread.CurrentUICulture = cultura;

            double n = 3.14159;
            double area = double.Parse(Console.ReadLine());
            double areaCalculada = (Math.Pow(area, 2)) * n;

            System.Console.WriteLine("A={0:F4}", areaCalculada);
        }
    }
}
