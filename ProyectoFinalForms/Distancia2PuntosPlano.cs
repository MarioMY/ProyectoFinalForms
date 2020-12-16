using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalForms
{
    class Distancia2PuntosPlano 
    {
        decimal x1;
        decimal x2;
        decimal y1;
        decimal y2;
       

        public decimal X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public decimal X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public decimal Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public decimal Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        

        public Distancia2PuntosPlano()
        {
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
            
        }

        public decimal OperacionPlano(decimal x1, decimal x2, decimal y1, decimal y2)
        {
            double operacion2;
            operacion2 = Math.Sqrt(Math.Pow(double.Parse(x1+"") - double.Parse(x2+""), 2) + Math.Pow(double.Parse(y1+"") - double.Parse(y2+""), 2));
            return (decimal)operacion2;
        }

        internal decimal OperacionPlano()
        {
            throw new NotImplementedException();
        }
    }
}
