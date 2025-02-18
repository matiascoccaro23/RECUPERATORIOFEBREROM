using System;
using System.Collections.Generic;
using System.Linq;

namespace PoligonoRegularApp
{
    public class RepositorioDePoligonos
    {
        private List<PoligonoRegular> listaPoligonos;

        public RepositorioDePoligonos()
        {
            listaPoligonos = new List<PoligonoRegular>();
        }

        
        public int Cantidad => listaPoligonos.Count;

       
        public bool PoligonoRepetido(PoligonoRegular poligono)
        {
            return listaPoligonos.Any(p =>
                p.Lado == poligono.Lado &&
                p.CantidadLados == poligono.CantidadLados &&
                p.Color == poligono.Color &&
                p.Material == poligono.Material);
        }

     
        public void AgregarPoligono(PoligonoRegular poligono)
        {
            if (!PoligonoRepetido(poligono))
            {
                listaPoligonos.Add(poligono);
            }
            else
            {
                throw new InvalidOperationException("El polígono ya existe en el repositorio.");
            }
        }

        
        public List<PoligonoRegular> ObtenerLista()
        {
            return listaPoligonos;
        }
        public void GuardarEnArchivo(string rutaArchivo)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                foreach (var poligono in listaPoligonos)
                {
                    writer.WriteLine($"{poligono.Lado};{poligono.CantidadLados};{poligono.Color};{poligono.Material}");
                }
            }

        }
        public void OrdenarPor(string criterio, bool ascendente)
        {
            switch (criterio)
            {
                case "Perímetro":
                    listaPoligonos = ascendente
                        ? listaPoligonos.OrderBy(p => p.Perimetro).ToList()
                        : listaPoligonos.OrderByDescending(p => p.Perimetro).ToList();
                    break;
                case "Área":
                    listaPoligonos = ascendente
                        ? listaPoligonos.OrderBy(p => p.Area).ToList()
                        : listaPoligonos.OrderByDescending(p => p.Area).ToList();
                    break;
            }
        }


    }

}
