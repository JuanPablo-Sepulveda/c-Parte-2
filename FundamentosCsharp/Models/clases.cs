using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCsharp.Models
{
    internal class Bebida
    {
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public Bebida(string Nombre, int Cantidad)// el constructor recibe los parametros que queramos modificar y su funcion a realizar
        {
            this.Nombre= Nombre;// declaramos que el nombre que recibamos en el parametro nombre va a ser nuestra nueva bebida
            this.Cantidad = Cantidad;
        }

        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;
        }
    }
}
