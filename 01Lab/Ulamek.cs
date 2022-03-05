using System;
using System.Collections.Generic;
using System.Text;

namespace _01Lab
{
    public class Ulamek
    {
        private int mianownik;
        private int licznik;

        public Ulamek()
        {
            this.mianownik = 1;
            this.licznik = 2;
        }
        public Ulamek(int mianownik, int licznik)
        {
            this.mianownik = mianownik;
            this.licznik = licznik;
        }

      public Ulamek(Ulamek previousUlamek)
        {
            mianownik = previousUlamek.mianownik;
            licznik = previousUlamek.licznik;
        }

        public void ToString()
        {

        }

        public static Ulamek operator +(Ulamek a, Ulamek b) => new Ulamek(a.mianownik * b.licznik + b.mianownik * a.licznik, a.licznik * b.licznik);
        public static Ulamek operator -(Ulamek a, Ulamek b)
         => a + (-b);
    }
}
