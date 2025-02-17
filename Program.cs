using System;

namespace PoligonoRegularApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese la longitud del lado del polígono:");
                double lado = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de lados (5, 6 o 7):");
                int cantidadLados = int.Parse(Console.ReadLine());

                Console.WriteLine("Seleccione el color (1: Blanco, 2: Rojo, 3: Azul, 4: Verde, 5: Negro):");
                Color color = (Color)int.Parse(Console.ReadLine());

                Console.WriteLine("Seleccione el material (1: Plástico, 2: Cristal, 3: Bronce):");
                Material material = (Material)int.Parse(Console.ReadLine());

                PoligonoRegular poligono = new PoligonoRegular(lado, cantidadLados, color, material);

                Console.WriteLine("\nDatos del polígono:");
                poligono.MostrarDatos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

    }
}
