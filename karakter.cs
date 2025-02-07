using System.ComponentModel;
using System.Net.Quic;

namespace OOPgyakorlas {
    internal class Karakter {
        private string nev;
        private int szint;
        private int eletero;
        private int ero;

        public Karakter(string nev, int szint, int eletero, int ero)
        {
            this.nev = nev;
            this.szint = szint;
            this.eletero = eletero;
            this.ero = ero;
        }

        public Karakter(string nev, int ero)
        {
            this.nev = nev;
            this.szint = 1;
            this.eletero = 100;
            this.ero = ero;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int Ero { get => ero; set => ero = value; }

        public void Tamadas() {
            System.Console.WriteLine(nev+" tamad " + ero+ "-vel");
        }

        public void Gyogyulas(int mennyiseg) {
            eletero += mennyiseg;
        }

        public void Szintlepes() {
            szint++;
            eletero++;
        }

        public override string ToString()
        {
            return $"Nev: {nev}, Szint: {szint}, Eletero: {eletero}, Ero: {ero}";
        }
    }
}
