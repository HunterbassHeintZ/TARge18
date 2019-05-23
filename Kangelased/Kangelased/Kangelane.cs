using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    public class Kangelane
    {
        private string Name;
        private string Location;

        public Kangelane(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Location1 { get => Location; set => Location = value; }

        public int Päästa(int Ohustatuid)
        {
            return (int)Math.Round(Ohustatuid * 0.95, 0);        }

        public override string ToString()
        {
            return Name1 + " kaitseb " + Location1;
        }
    }
}
