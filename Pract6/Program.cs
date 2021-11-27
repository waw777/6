using System;

namespace Pract6
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression arithmeticProgression = new (1,7);
            GeometricProgression geometricProgression = new(6,3);
            Console.WriteLine("Арифметическая прогрессия ");
            PrintSeries(arithmeticProgression,6);
            arithmeticProgression.Reset();
            PrintIIndexable(arithmeticProgression, 3);

            Console.WriteLine("Геометрическая прогрессия ");
            PrintSeries(geometricProgression, 6);
            arithmeticProgression.Reset();
            PrintIIndexable(geometricProgression, 3);
        }
        private static void PrintSeries(ISeries series, int count)
        {
            for (int i = 0; i < count; i++)
            {
              
               Console.WriteLine( series.GetCurrent());
                series.MoveNext();
            }
        }
       private static void PrintIIndexable(IIndexable indexable, int count)
        {
            for (int i = 1; i <= count; i++)
            {

                Console.WriteLine(indexable[i]);
             
            }
        }
    }
}
