using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Carta
    {
        [Key]
        public int CartaId { get; set; }

        public DateTime Fecha { get; set; }

        public int DestinatarioId { get; set; }

        public string Cuerpo { get; set; }


        public Carta()
        {
            CartaId = 0;
            Fecha = DateTime.Now;
            DestinatarioId = 0;
            Cuerpo = string.Empty;
        }

        public Carta(int cartaId, DateTime fecha, int destinatarioId, string cuerpo)
        {
            CartaId = cartaId;
            Fecha = fecha;
            DestinatarioId = destinatarioId;
            Cuerpo = cuerpo;
        }
    }
}
