using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Usuario
    {
        public int UltimoId = 1;
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email  { get; set; }
        public string? Foto { get; set; }
        public string? Pass { get; set; }


}
}
