using System;

namespace mathlib
{
    public static class math
    {
        // Základní matematické operace
        public static double Scitani(double a, double b) => a + b;
        public static double Odecitani(double a, double b) => a - b;
        public static double Nasobeni(double a, double b) => a * b;
        public static double Deleni(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Nelze dělit nulou.");
            return a / b;
        }

        // Faktoriál
        public static long Faktorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Faktoriál není definován pro záporná čísla.");
            long vysledek = 1;
            for (int i = 2; i <= n; i++)
                vysledek *= i;
            return vysledek;
        }

        // Umocňování s přirozenými exponenty
        public static double Umocneni(double zaklad, int exponent)
        {
            double vysledek = 1;
            for (int i = 0; i < exponent; i++)
                vysledek *= zaklad;
            return vysledek;
        }

        // Obecná odmocnina
        public static double Odmocnina(double zaklad, double odmocnitel)
        {
            if (zaklad < 0 && odmocnitel % 2 == 0)
                throw new ArgumentException("Nelze počítat sudou odmocninu ze záporného čísla.");
            return Math.Pow(zaklad, 1 / odmocnitel);
        }

        // Binomický koeficient
        public static double Modulo(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Modulo nulou není definováno.");
            return a % b;
        }

        public static double ZmenaZnamenka(double cislo)
        {
            return -cislo;
        }
    }
}
