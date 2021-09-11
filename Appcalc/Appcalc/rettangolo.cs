using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Appcalc
{
    public class Tasto
    {
        public Point a, b, c, d;
        public string funzione = "";
        public bool tastoFunction = false;
        public Tasto() { }
        public Tasto(Point l_a , Point l_b , Point l_c , Point l_d, string l_funzione, bool l_tastoFunction = false) 
        {
            a = l_a;
            b = l_b;
            c = l_c;
            d = l_d;
            funzione = l_funzione;
            tastoFunction = l_tastoFunction;
        }
    }
}
