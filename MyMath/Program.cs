namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string op = ShowMenu();
                if (IsValidOp(op))
                {
                    int a = ReadIntEx();
                    int b = ReadIntEx();
                    int r;
                    switch (op)
                    {
                        case "g":
                            r = MyMath.Calc_ggT(a, b);
                            MyMath.Calc_ggT(3, 3);
                            ShowResult("ggT", a, b, r);
                            break;
                        case "k":
                            r = MyMath.Calc_kgV(a, b);
                            ShowResult("kgV", a, b, r);
                            break;
                        case "r":
                            r = MyMath.Calc_ggT_r(a, b);
                            ShowResult("ggTr", a, b, r);
                            break;
                        case "s":
                            Console.Write("swap von {0} und {1} ", a, b);
                            MyMath.Swap(ref a, ref b);
                            Console.WriteLine("wird zu {0} und {1}", a, b);
                            break;
                        default:
                            Console.WriteLine("ungültige Operation");
                            break;
                    }
                }
                else if (op == "e")
                {
                    Console.WriteLine("und tschüss...");
                    break;
                }
                else if (op == "a")
                {
                    Console.WriteLine("Anzahl Werte?");
                    int anzWerte = ReadInt();
                    int[] werte = ReadValues(anzWerte);
                    ShowValues(werte);
                    int min = MyMath.GetMin(werte);
                    int max = MyMath.GetMax(werte);
                    double middle = MyMath.CalcMiddle(werte);
                    Console.WriteLine("min={0} max={1} mid={2:F2}", min, max, middle);
                    MyMath.Sort(werte);
                    ShowValues(werte);
                    MyMath.Reverse(werte);
                    ShowValues(werte);
                }
                else
                {
                    Console.WriteLine("ungültige Operation");
                }
            }
        }

        private static string ShowMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Bitte Operation eingeben:");
            Console.WriteLine("  g für ggT");
            Console.WriteLine("  k für kgV");
            Console.WriteLine("  r für ggTr");
            Console.WriteLine("  s für swap");
            Console.WriteLine("  a für Array");
            Console.WriteLine("  e für exit");
            string op = Console.ReadLine();
            return op;
        }

        private static bool IsValidOp(string op)
        {
            return op == "g" || op == "k" || op == "r" || op == "s";
        }


        //Variante ohne Exceptionhandling
        private static int ReadInt()
        {
            int i;
            do
            {
                Console.WriteLine("Bitte Zahl eingeben");
                string s = Console.ReadLine();
                int.TryParse(s, out i);
            } while (i <= 0);
            Console.WriteLine("danke");
            return i;
        }

        //Variante mit Exceptionhandling
        private static int ReadIntEx()
        {
            int i;
            do
            {
                Console.WriteLine("Bitte Zahl eingeben");
                try
                {
                    string s = Console.ReadLine();
                    i = int.Parse(s);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    i = 0;
                }
            } while (i <= 0);
            Console.WriteLine("danke");
            return i;
        }


        static int[] ReadValues(int anzahl)
        {
            int i = 0;
            int[] werte = new int[anzahl];
            while (i < anzahl)
            {
                werte[i++] = ReadInt();
            }
            return werte;
        }

        static void ShowResult(string op, int a, int b, int c)
        {
            Console.WriteLine(op + " von {0} und {1} ist {2}", a, b, c);
        }

        static void ShowValues(int[] werte)
        {
            foreach (int i in werte)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine();
        }
    }
}