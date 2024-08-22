using System;

class CALCULO

{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su Nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su Edad");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Double EdadMeses = Edad * 12;
        Double EdadDias = Edad * 365;
        Double EdadHoras = Edad * 365 * 24;
        Console.WriteLine("la edad en meses es:" + EdadMeses + " Meses");
        Console.WriteLine("La Edad en dias es:" + EdadDias + " Dias");
        Console.WriteLine("La Edad en Horas es:" + EdadHoras + " Horas");
    }
}
   


 
