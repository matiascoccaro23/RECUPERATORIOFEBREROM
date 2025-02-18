using System;

namespace PoligonoRegularApp
{
   
    public enum Color
    {
        Blanco = 1,
        Rojo,
        Azul,
        Verde,
        Negro
    }

    
    public enum Material
    {
        Plástico = 1,
        Cristal,
        Bronce
    }

    
    public class PoligonoRegular
    {
        // Atributos
        public double Lado { get; set; }
        public int CantidadLados { get; set; } // Debe ser 5, 6 o 7
        public Color Color { get; set; }
        public Material Material { get; set; }

      
        public PoligonoRegular(double lado, int cantidadLados, Color color, Material material)
        {
            if (cantidadLados < 5 || cantidadLados > 7)
                throw new ArgumentException("La cantidad de lados debe ser 5, 6 o 7.");

            Lado = lado;
            CantidadLados = cantidadLados;
            Color = color;
            Material = material;
        }

       
        public double CalcularPerimetro()
        {
            return Lado * CantidadLados;
        }

      
        private double CalcularApotema()
        {
            return Lado / (2 * Math.Tan(Math.PI / CantidadLados));
        }

      
        public double CalcularArea()
        {
            double perimetro = CalcularPerimetro();
            double apotema = CalcularApotema();
            return (perimetro * apotema) / 2;
        }

      
        public string TipoDePoligono()
        {
            return CantidadLados switch
            {
                5 => "Pentágono",
                6 => "Hexágono",
                7 => "Heptágono",
                _ => "Desconocido"
            };
        }

        
        public void MostrarDatos()
        {
            Console.WriteLine($"Lado: {Lado}");
            Console.WriteLine($"Cantidad de Lados: {CantidadLados}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Material: {Material}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Tipo de Polígono: {TipoDePoligono()}");
        }
    }
}
