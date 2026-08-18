using System.Runtime.CompilerServices;

namespace Funktionen
{
    public class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }
        public static int Calc_kgV(int a, int b)
        {
            return (a * b) / Calc_ggT(a, b);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Calc_ggT_r(b, a % b);
        }
        /// <summary>
        /// Berechnet den Mittelwert
        /// </summary>
        /// <param name="werte">Array von Ganzzahlen, aus </param>
        /// <returns>Mittelwert des uebergebenen Arrays</returns>
        public static double CalcMiddle(int[] werte)
        {
            double summe = 0.0;
            foreach (int wert in werte)
            {
                summe += wert;
            }
            return summe / werte.Length;
        }

        public static int GetMin(int[] werte)
        {
            int min = int.MaxValue;
            foreach (int wert in werte)
            {
                if (wert < min) {
                    min = wert;
                }
            }
            return min;
        }

        public static int GetMax(int[] werte)
        {
            int max = int.MinValue;
            foreach (int wert in werte)
            {
                if (wert > max) {
                    max = wert;
                }
            }
            return max;
        }

        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public static void Reverse(int[] werte)
        {
            Array.Reverse(werte);
        }

        public static void Sort(int[] werte)
        {
            Array.Sort(werte);
        }
    }
}
