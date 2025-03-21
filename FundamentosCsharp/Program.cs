using System;
using FundamentosCsharp.Models;// añadimos un models del directorio clases.cs 



internal class Program()
{
    static void Main(string[]args)
    {
        //clases,objetos y constructores
        Bebida bebida = new Bebida("Coca cola",1000);
        bebida.Beberse(500);
       
        Console.WriteLine(bebida.Cantidad);

        //Listas y Arreglos
        int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,0};

        for(int i=0; i<numeros.Length /*condicion*/; i++ /*indicamos el cambiio*/)// metodo For
        {
            Console.WriteLine("iteracion: "+i+"-"+numeros[i]);
        }
        foreach(var numero in numeros)// metodo ForEach
        {
            Console.WriteLine(numero);
        }
        Console.WriteLine("*******************************************");
        Console.WriteLine("LISTA");

        List<int> lista = new List<int>() { 1,2,3,4,5,6,7,8};
        lista.Add(9);
        lista.Add(0);
        

        foreach(var numero in lista)
        {
            Console.WriteLine("Elemento: "+numero);
        }

        List<Cerveza> cervezas = new List<Cerveza>(){new Cerveza(10,"cerveza premium")};
        cervezas.Add(new Cerveza(500));
        Cerveza brahama = new Cerveza(500," cerveza de cebada");
        cervezas.Add(brahama);

        foreach (var cervezass in cervezas)
        {
            Console.WriteLine("cerveza: "+cervezass.Nombre);
        }
        Console.WriteLine("*******************************************");
        Console.WriteLine("Interfaces");

        var bebidaAlcoholica = new Cerveza(100);
        MostrarRecomendacion(bebidaAlcoholica);

        Console.WriteLine("*******************************************");
        Console.WriteLine("Conexion a base de datos y obtencion de informacion");

        CervezaBD cervezaBD = new CervezaBD();
        var cerveza = cervezaBD.Get();

        foreach(var cervezaa in cerveza)
        {
            Console.WriteLine(cervezaa.Nombre);
        }

    }
    static void MostrarRecomendacion(IBebidaAlcoholica bebida)
    {
        bebida.MaxRecomendado();
    }
}
