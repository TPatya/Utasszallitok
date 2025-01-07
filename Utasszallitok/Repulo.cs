using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utasszallitok
{
    internal class Repulo
    {
        public string Tipus { get; set; }

        public int Ev { get; set; }

        public string Utas { get; set; }

        public string Szemelyzet { get; set; }

        public int UtazoSebesseg { get; set; }

        public int FelszalloTomeg { get; set; }

        public string Fesztav { get; set; }


        public Repulo(string sor)
        {
            string[] s = sor.Split(';');

            Tipus = s[0];
            Ev = int.Parse(s[1]);
            Utas = s[2];
            Szemelyzet = s[3];
            UtazoSebesseg = int.Parse(s[4]);
            FelszalloTomeg = int.Parse(s[5]);
            Fesztav = s[6];

        }
    }
}
