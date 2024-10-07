using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meowmeow
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public int Szulev { get; set; }
        public int Rajt { get; set; }
        public string Nem { get; set; }
        public string Kategoria { get; set; }
        public TimeSpan Iuszas { get; set; }
        public TimeSpan Idepo1 { get; set; }
        public TimeSpan Ikerek { get; set; }
        public TimeSpan Idepo2 { get; set; }
        public TimeSpan Ifutas { get; set; }
        public int Eletkor => DateTime.Now.Year - Szulev;
        public override string ToString()
        {
            return $"{Nev} ({Eletkor}) {/*(Nem ? "Férfi" : "Nő")*/Nem}: {Kategoria} Kategóriában";
        }
        public Versenyzo(string sor)
        {
            string[] darabok = sor.Split(';');
            Nev = darabok[0];
            Szulev = Convert.ToInt16(darabok[1]);
            Rajt = Convert.ToInt16(darabok[2]);
            Nem = darabok[3];
            Kategoria = darabok[4];
            Iuszas = TimeSpan.Parse(darabok[5]);
            Idepo1 = TimeSpan.Parse(darabok[6]);
            Ikerek = TimeSpan.Parse(darabok[7]);
            Idepo2 = TimeSpan.Parse(darabok[8]);
            Ifutas = TimeSpan.Parse(darabok[9]);
        }
    }

}
