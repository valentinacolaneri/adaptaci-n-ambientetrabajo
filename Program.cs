using System;

namespace Csharp
{
    interface Figura
    {
        double CalcularArea();
        double CalcularPerimetro();
    }
    //a
    class Rectangulo : Figura
    {
        public double Base;
        public double Altura;

        public Rectangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }

        public double CalcularArea() => Base * Altura;

        public double CalcularPerimetro() => 2 * (Base + Altura);
    }

    //b
    class Cuadrado : Figura
    {
        public double Lado;

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public double CalcularArea() => Lado * Lado;

        public double CalcularPerimetro() => 4 * Lado;
    }

    //c
    class Triangulo : Figura
    {
        public double Lado;
        public double Altura;

        public Triangulo(double lado, double altura)
        {
            Lado = lado;
            Altura = altura;
        }

        public double CalcularArea() => (Lado * Altura) / 2;

        public double CalcularPerimetro() => 3 * Lado;
    }

    //d
    class Circulo : Figura
    {
        public double Radio;
        public static double Pi;

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea() => Pi * Radio * Radio;

        public double CalcularPerimetro() => 2 * Pi * Radio;
    }

    class Programa
    {
        static void Main()
        {
            Figura[] figuras = new Figura[4];
            figuras[0] = new Rectangulo(4, 5);
            figuras[1] = new Cuadrado(4);
            figuras[2] = new Triangulo(3, 4);
            figuras[3] = new Circulo(2);

            for (int i = 0; i < figuras.Length; i++)
            {
                Console.WriteLine($"Figura {i + 1}:");
                Console.WriteLine($"Área: {figuras[i].CalcularArea()}");
                Console.WriteLine($"Perímetro: {figuras[i].CalcularPerimetro()}");
                Console.WriteLine();
            }
        }
    } 
}
