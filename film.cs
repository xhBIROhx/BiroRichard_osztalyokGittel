using System.ComponentModel;
using System.Net.Quic;

namespace OOPgyakorlas {
    internal class Film {
        private string cim;
        private string rendezo;
        private int hosszPercekben;
        private string mufaj;
        private bool megjelent;

        public Film(string cim, string rendezo)
        {
            this.cim = cim;
            this.rendezo = rendezo;
            this.hosszPercekben = 120;
            this.mufaj = "Ismeretlen";
            this.megjelent = false;
        }

        public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
        {
            this.cim = cim;
            this.rendezo = rendezo;
            this.hosszPercekben = hosszPercekben;
            this.mufaj = mufaj;
            this.megjelent = megjelent;
        }

        public string Cim { get => cim; set => cim = value; }
        public string Rendezo { get => rendezo; set => rendezo = value; }
        public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
        public string Mufaj { get => mufaj; set => mufaj = value; }
        public bool Megjelent { get => megjelent; set => megjelent = value; }

        public string Jatszas() {
            return "a " +cim+" cimu film elkezdodott";
        }

        public void MufajModositas(string ujMufaj) {
            mufaj = ujMufaj;
        }

        public void HosszNovelese(int percek) {
            hosszPercekben += percek;
        }

        public override string ToString()
        {
            return $"Cim: {cim}, Rendezo: {rendezo}, Megjelenes eve: {megjelent}, Hossz: {hosszPercekben}, Mufaj: {mufaj}";
        }
    }
}
