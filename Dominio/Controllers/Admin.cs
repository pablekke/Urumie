using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Controllers
{
    public class Admin : Usuario
    {
        public Admin() : base()
        {
        }
        public override void EsValido()
        {
            base.EsValido();
        }
    }
}
