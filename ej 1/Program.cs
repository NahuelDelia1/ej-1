using System;

namespace ejercicio
{
    class ej1
    {

        static void Main(string[] args)
        {
            double altura;
            double area;
            double generatriz;
            double radio;
            double volumen;

            Console.Write("ingrese la altura del cono:");
            altura = Double.Parse(Console.ReadLine());

            Console.Write("ingrese el radio del cono:");
            radio = Double.Parse(Console.ReadLine());

            Console.Write("ingrese la generatriz del cono:");
            generatriz = Double.Parse(Console.ReadLine());
            area = Math.PI * radio * (radio + generatriz);
            volumen = (Math.PI * Math.Pow(radio, 2) * altura) / 3;

            Console.Write("El volumen del cono segun los datos ingresados es: " + volumen + " y el area es: " + area);
        }

    }

}


