using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Solicitud
    {
        private static int _ultimoId { get; set; }
        public int Id { get; set; }
        public Inquilino Solicitante { get; set; }
        public Inquilino Solicitado { get; set; }
        public Estado Estado { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime? FechaAceptada { get; set; }
        public DateTime? FechaRechazada { get; set; }

        #region Constructors
        public Solicitud(Inquilino solicitante, Inquilino solicitado)
        {
            Id = _ultimoId++;
            Solicitante = solicitante;
            Solicitado = solicitado;
            Estado = Estado.Pendiente;
            FechaSolicitud = DateTime.Now;
            FechaAceptada = null;
            FechaRechazada = null;
        }

        public Solicitud()
        {
            Id = _ultimoId++;
            Estado = Estado.Pendiente;
            FechaSolicitud = DateTime.Now;
            FechaAceptada = null;
            FechaRechazada = null;
        }

        #endregion

        #region Methods
        /*public void Aceptar()
        {
            Estado = Estado.Aprobada;
            Solicitante.AddAmigo(Solicitado);
            Solicitado.AddAmigo(Solicitante);
            FechaAceptada = DateTime.Now;
        }*/

        public void Declinar()
        {
            Estado = Estado.Rechazada;
            FechaRechazada = DateTime.Now;
        }

        public void EsValido()
        {
            /*if (Solicitante.Bloqueado)
            {
                throw new Exception("Solicitante bloqueado");
            }*/

            if (Solicitante == null)
            {
                throw new Exception("Solicitante vacío");
            }

            if (Solicitado == null)
            {
                throw new Exception("Solicitado vacío");
            }

            if (Solicitado == Solicitante)
            {
                throw new Exception("Miembros iguales");
            }
        }

        /*public override string ToString()
        {
            return $"Solicitante:{Solicitante.Nombre} {Solicitante.Apellido}\nSolicitado: {Solicitado.Nombre} {Solicitado.Apellido}";
        }*/
        #endregion
    }
}