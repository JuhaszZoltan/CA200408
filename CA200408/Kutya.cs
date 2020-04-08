using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200408
{
    class Kutya
    {
        private string Nev;

        public ConsoleColor Szin { get; }

        #region erre van egyszerűbb syntax
        //private ConsoleColor _szin;
        //public ConsoleColor Szin
        //{
        //    set { _szin = value; }
        //    get { return _szin; }
        //}
        #endregion

        private DateTime Szul;

        private float suly;
        public float Suly
        {
            set
            {
                if (suly != 0 && value > suly * 1.01F)
                    throw new Exception("ennyit egyszerre nem tud enni egy kutya");

                if (value <= 0)
                    throw new Exception("a súlyának pozitínak kell lennie");

                if (value > 120)
                    throw new Exception("ez azért kutyának kicsit sok...");

                suly = value;
            }
            get
            {
                return suly;
            }
        }

        #region Ezt a hülyeséget majd JAVA-ban...
        //public void SetSuly(float ujSuly)
        //{
        //    if (ujSuly <= 0)
        //        throw new Exception("a súlyának pozitínak kell lennie");

        //    if (ujSuly > 120)
        //        throw new Exception("ez azért kutyának kicsit sok...");

        //    Suly = ujSuly;
        //}
        //public float GetSuly()
        //{
        //    return Suly;
        //}
        #endregion

        public void Ugat()
        {
            Console.ForegroundColor = this.Szin;
            Console.WriteLine("Vau-vau!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Eszik(float mennyiseg)
        {
            Suly += mennyiseg;
            Console.WriteLine($"{Nev} modja: nyami! <3 :3");
        }

        public Kutya(string nev, int szin, string szul, float suly)
        {
            Nev = nev;
            Szin = (ConsoleColor)szin;
            Szul = DateTime.Parse(szul);

            Suly = suly;
        }

    }
}
