using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kangelased
{
    class Program
    {
        static List<Kangelane> kangelased = new List<Kangelane>();
        static void LaeKangelased(string Failinimi)
        {
            string[] failiandmed = File.ReadAllLines(Failinimi);
            foreach (string rida in failiandmed)
            {
                string[] name_and_location = rida.Split('/');
                for (int i = 0; i < name_and_location.Length; i++)
                {
                    name_and_location[i] = name_and_location[i].Trim();
                }
                if (name_and_location[0].EndsWith("*"))
                {
                    kangelased.Add(new SuperKangelane(name_and_location[0], name_and_location[1]));
                }
                else
                {
                    kangelased.Add(new Kangelane(name_and_location[0], name_and_location[1]));
                }
            }
            
        }
        static void Main(string[] args)
        {
             
        }
    }
}
