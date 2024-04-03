using System;

class Arbol
{
    public double Peso { get; set; }
    public double PesoPromedio { get; set; }
    public int Altura { get; set; }

    public Arbol(double peso, double pesoPromedio, int altura)
    {
        Peso = peso;
        PesoPromedio = pesoPromedio;
        Altura = altura;
    }

    // Se calcula el nuevo peso y altura en base a la cantidad de arboles.
    public static Arbol operator +(Arbol a1, Arbol a2)
    {
        double nuevoPeso = a1.Peso + a2.Peso;
        double nuevoPesoPromedio = (a2.PesoPromedio) / a2.Altura;
        int nuevaAltura = Math.Max(a1.Altura, a2.Altura);
        return new Arbol(nuevoPeso, nuevoPesoPromedio, nuevaAltura);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de árboles:");
        int cantidadArboles = int.Parse(Console.ReadLine());

        Arbol[] arboles = new Arbol[cantidadArboles];
        for (int i = 0; i < cantidadArboles; i++)
        {
            arboles[i] = new Arbol(4, 7, cantidadArboles); // Datos fijos del arbol
        }

        Arbol arbolSuma = SumarArboles(arboles);

        Console.WriteLine("Peso total de los árboles: " + arbolSuma.Peso);
        Console.WriteLine("Peso promedio de los árboles: " + arbolSuma.PesoPromedio);
        Console.WriteLine("Altura máxima de los árboles: " + arbolSuma.Altura);
    }

    static Arbol SumarArboles(Arbol[] arboles)
    {
        Arbol resultado = new Arbol(0, 0, 0);
        foreach (var arbol in arboles)
        {
            resultado += arbol;
        }
        return resultado;
    }
}
