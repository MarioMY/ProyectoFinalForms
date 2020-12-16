using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalForms
{
    public class Distancia2PuntosRecta
    {
        decimal V1;
        decimal V2;
        decimal operacion1;

        public decimal Valor1
        {
            get { return V1; }
            set { V1 = value; }
        }

        public decimal Valor2
        {
            get { return V2; }
            set { V2 = value; }
        }

        public decimal Operacion1
        {
            get { return operacion1; }
            set { operacion1 = value; }
        }


        public Distancia2PuntosRecta()
        {
            V1 = 0;
            V2 = 0;
            operacion1 = 0;
        }

        public decimal Operacion(decimal  V1, decimal V2)
        {
            operacion1 = Math.Abs(V1 - V2);
            return operacion1;
        }
       
    }
}
