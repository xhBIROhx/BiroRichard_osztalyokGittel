using System.ComponentModel;
using System.Net.Quic;

namespace OOPgyakorlas {
    internal class KemKuldetes {
        private string kodnev;
        private string orszag;
        private int veszelySzint;
        private int sikerEsej;

        public KemKuldetes(string kodnev, string orszag)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = 5;
            this.sikerEsej = 50;
        }

        public KemKuldetes(string kodnev, string orszag, int veszelySzint, int sikerEsej)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = veszelySzint;
            this.sikerEsej = sikerEsej;
        }

        public void KuldetesInditasa() {
            System.Console.WriteLine(kodnev+ "elkezdodott");
        }

        public void VeszelySzintNovelese(int mennyiseg) {
            veszelySzint += mennyiseg;
        }

        public void SikerEsejNovelese(int szazalek) {
            sikerEsej += szazalek;
        }

        public string Kodnev { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public int SikerEsej { get => sikerEsej; set => sikerEsej = value; }

        public override string ToString()
        {
            return $"Kodnev: {kodnev}, Orszag: {orszag}, VeszelySzint: {veszelySzint}, SikerEsej: {sikerEsej}";
        }
    }
}
