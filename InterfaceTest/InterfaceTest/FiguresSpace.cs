using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceTest
{
    interface IFigura
    {
        double Perimetr();
        double Ploshad();
    }

    class Treug : IFigura
    {
        public double a;
        public double b;
        public double c;

        public double p { get { return (a + b + c) / 2.0; } }
        
        public double Perimetr()
        {
            return a + b + c;
        }
        public double Ploshad()
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
      
       
    }
    
    class Kvadrat : IFigura
    {
        public double a;
        
        public double  Perimetr()
        {
            return 4 * a;
        }
        public double Ploshad()
        {
            return a * a;
        }
    }
}
