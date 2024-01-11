using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Controllers
{
    public class Preferencias
    {
        public Genero? GeneroPreferido { get; set; }
        public int? ZonaPreferida { get; set; }
        public List<int>? ZonasAlternativas { get; set; }
        public int? PresupuestoMin { get; set; }
        public int? PresupuestoMax { get; set; }
        public int? EdadMin { get; set; }
        public int? EdadMax { get; set; }
        public bool NoFumador { get; set; }
        public bool TengoPerro { get; set; }
        public bool TengoGato { get; set; }
        public bool SoyEstudiante { get; set; }
        public bool LGBTFriendly { get; set; }
        public bool CannabisFriendly { get; set; }


        public Preferencias()
        {
            ZonasAlternativas = new List<int>();
        }
        public void EsValido()
        {
            if (GeneroPreferido == null)
            {
                throw new ArgumentNullException(nameof(GeneroPreferido), "El género preferido es requerido.");
            }

            if (ZonaPreferida == null)
            {
                throw new ArgumentNullException(nameof(ZonaPreferida), "La zona preferida es requerida.");
            }

            if (PresupuestoMin == null || PresupuestoMax == null || PresupuestoMin > PresupuestoMax)
            {
                throw new ArgumentException("Los valores de presupuesto son inválidos.");
            }

            if (EdadMin == null || EdadMax == null || EdadMin > EdadMax)
            {
                throw new ArgumentException("Los valores de edad son inválidos.");
            }
        }
    }
}
