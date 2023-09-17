using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani_OOP
{
    class Zaměstnanec
    {
        string titul;
        string jmeno;
        int mesicnyPlat;
        DateTime datumNastupu;
        int osobniHodnoceni;
        string pozice;
        int hodiny;

        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                string[] text = jmeno.Split(' ');
                text[1].ToUpper();
                char prvni = jmeno[0];
                if (prvni > (char)96 && prvni < (char)123)
                {
                    prvni -= (char)32;
                }
                titul.Insert(0, prvni.ToString());
            }
        }

        public string Titul
        {
            get
            {
                return titul;
            }
            set
            {
                char prvni = titul[0];
                if (prvni > (char)96 && prvni < (char)123)
                {
                    prvni -= (char)32;
                }
                titul.Insert(0, prvni.ToString());

            }
        }

        public Zaměstnanec(string titul, string jmeno, int mesicnyPlat, DateTime datumNastupu, int osobniHodnoceni, int hodiny)
        {
            this.titul = titul;
            this.jmeno = jmeno;
            this.mesicnyPlat = mesicnyPlat;
            this.datumNastupu = datumNastupu;
            this.osobniHodnoceni = 0;
            this.hodiny = 0;
        }

        public int RocniPlat()
        {
            int rocniPlat = mesicnyPlat * 12;
            return rocniPlat;
        }
        public int PocetMesicu(DateTime datumNastupu)
        {
            DateTime ted = new DateTime();
            ted = DateTime.Now;
            TimeSpan rozdil = (ted - datumNastupu);
            int pocetMesicu = Convert.ToInt32((rozdil.TotalDays / 28));
            return pocetMesicu;
        }

        public void ZvysOsobni(int osobniHodnoceni)
        {
            if (titul != "Vedouci" && osobniHodnoceni > 10000)
            {
                titul = "Vedouci";
            }
        }

        public void PridejOdpracHod(int odprachodiny)   //dodělat
        {
            hodiny += odprachodiny;
            if (hodiny >= 100)
            {

            }
        }

        public void Relaxace(int hodiny)
        {
            int relaxace = 72;
            if (hodiny >=100)
            {
                
            }
        }
        public override string ToString()
        {
            return Titul + ", " + Jmeno + ", " + mesicnyPlat + ", " + PocetMesicu(datumNastupu) + ", " + osobniHodnoceni + ", " + RocniPlat() + ", " + RocniPlat() +
                ", " + hodiny;
        }
    }
    
}
