using System.ComponentModel;
using System.Net.Quic;

namespace OOPgyakorlas {
    internal class Urhajo {
        private string nev;
        private int sebesseg;
        private int utaskapacitas;
        private int uzemanyagSzint;

        public Urhajo(string nev, int utaskapacitas)
        {
            this.nev = nev;
            this.sebesseg = 0;
            this.utaskapacitas = utaskapacitas; 
            this.uzemanyagSzint = 100;
        }

        public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagSzint)
        {
            this.nev = nev;
            this.sebesseg = sebesseg;
            this.utaskapacitas = utaskapacitas;
            this.uzemanyagSzint = uzemanyagSzint;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
        public int UzemaanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }

    public void Induulas() {
        sebesseg++;
        uzemanyagSzint--;
    }

    public void Tankolas(int mennyiseg) {
        uzemanyagSzint += mennyiseg;
    }

    public void Landolas() {
        sebesseg = 0;
    }

        public override string ToString()
        {
            return $"Nev: {nev}, Sebesseg: {sebesseg}, Utaskapacitas: {utaskapacitas}, UzemaanyagSzint: {uzemanyagSzint}";
        }
    }
}
