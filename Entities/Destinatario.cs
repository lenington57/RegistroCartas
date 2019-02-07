using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Destinatario
    {
        [Key]
        public int DestinatarioId { get; set; }

        public DateTime Fecha { get; set; }

        public string Nombres { get; set; }

        public int CantidadCartas { get; set; }


        public Destinatario()
        {
            DestinatarioId = 0;
            Fecha = DateTime.Now;
            Nombres = string.Empty;
            CantidadCartas = 0;
        }

        public Destinatario(int destinatarioId, DateTime fecha, string nombres, int cantidadCartas)
        {
            DestinatarioId = destinatarioId;
            Fecha = fecha;
            Nombres = nombres;
            CantidadCartas = cantidadCartas;
        }
    }
}
