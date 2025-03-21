using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCsharp.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("el maximo permitido son 3 copas");
        }
        public Vino(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad)
        {

        }
    }
}
