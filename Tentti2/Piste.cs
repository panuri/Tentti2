using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentti2
{
    class Piste
    {
        public string Nimi { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Piste()
        {

        }

        public Piste(string n, double x , double y)
        {
            this.Nimi = n;
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return this.Nimi + " " + this.X + " " + this.Y;
        }

    }
}
