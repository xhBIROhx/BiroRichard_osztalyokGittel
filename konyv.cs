using System.ComponentModel;
using System.Net.Quic;

namespace OOPgyakorlas {
    internal class Konyv {
        private string cim;
        private string szerzo;
        private int kiadasEve;
        private int oldalszam;
        private int ar;

        public Konyv(string cim, string szerzo)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.kiadasEve = DateTime.Now.Year;
            this.oldalszam = 200;
            this.ar = 3000;
        }

        public Konyv(string cim, string szerzo, int kiadasEve, int oldalszam, int ar)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.kiadasEve = kiadasEve;
            this.oldalszam = oldalszam;
            this.ar = ar;
        }

        public string Cim { get => cim; set => cim = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
        public int Oldalszam { get => oldalszam; set => oldalszam = value; }
        public int Ar { get => ar; set => ar = value; }

        public void Arnoveles(int osszeg) {
            ar += osszeg;
        }

        public void Kedvezmeny(double szazalek) {
            ar -= Convert.ToInt16(ar * (szazalek / 100));
        }

        public int HanyOldalMaradt(int elolvasott) {
            return oldalszam - elolvasott;
        }

        public override string ToString()
        {
            return $"Cim: {cim}, Szerzo: {szerzo}, Kiadasz eve: {kiadasEve}, Ar: {ar}, Oldalszam: {oldalszam}";
        }
    }
}