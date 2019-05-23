using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class SuperKangelane:Kangelane
    {
        private double _Osavus;
        public SuperKangelane(string Name, string Location) : base(Name, Location)
        {
            _Osavus = SingleRandom.Instance.Next(1, 60)/10.0;
        }
        public override int Päästa(int ohustatuid)
        {
            return (int)Math.Round((95 + _Osavus) / 100 * ohustatuid, 0);
        }

        public override string ToString()
        {
            return base.ToString() + "ta on selles " + _Osavus + " prostesndi parem kui lihtsalt kangelane";
        }
    }
}
