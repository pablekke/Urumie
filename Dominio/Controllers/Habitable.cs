using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Controllers
{
    public class Habitable
    {
        public string? NombreCalle { get; set; }
        public int? NumeroPuerta { get; set; }
        public string? Apto { get; set; }
        public int? CantidadBaños { get; set; }
        public int? CantidadCuartos { get; set; }
        public int? MetrosCuadrados { get; set; }
        public int? Pisos { get; set; }
        public Habitable()
        {
        }
        public void EsValido()
        {
            if (string.IsNullOrEmpty(NombreCalle))
            {
                throw new ArgumentNullException(nameof(NombreCalle), "El nombre de la calle es requerido.");
            }

            if (NumeroPuerta == null || NumeroPuerta <= 0)
            {
                throw new ArgumentException("El número de puerta es requerido y debe ser mayor que cero.");
            }

            if (CantidadBaños == null || CantidadBaños < 0)
            {
                throw new ArgumentException("La cantidad de baños no puede ser negativa.");
            }

            if (CantidadCuartos == null || CantidadCuartos < 0)
            {
                throw new ArgumentException("La cantidad de cuartos no puede ser negativa.");
            }

            if (MetrosCuadrados == null || MetrosCuadrados <= 0)
            {
                throw new ArgumentException("Los metros cuadrados son requeridos y deben ser mayores que cero.");
            }

            if (Pisos == null || Pisos <= 0)
            {
                throw new ArgumentException("La cantidad de pisos es requerida y debe ser mayor que cero.");
            }
        }
    }
}
