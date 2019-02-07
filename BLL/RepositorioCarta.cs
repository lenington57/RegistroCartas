using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositorioCarta : Repositorio<Carta>
    {
        public override bool Guardar(Carta carta)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Carta.Add(carta);
                contexto.Destinatario.Find(carta.DestinatarioId).CantidadCartas += 1;
                contexto.SaveChanges();
                paso = true;

            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }

        public override bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Carta carta = contexto.Carta.Find(id);
                contexto.Destinatario.Find(carta.DestinatarioId).CantidadCartas -= 1;
                contexto.Carta.Remove(carta);
                contexto.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static void CambiarBalances(Carta carta, Carta cartaAnt)
        {
            Repositorio<Destinatario> repositorio = new Repositorio<Destinatario>();
            Repositorio<Destinatario> repository = new Repositorio<Destinatario>();
            Contexto contexto = new Contexto();
            var Destinatario = contexto.Destinatario.Find(carta.DestinatarioId);
            var DestinatarioAnt = contexto.Destinatario.Find(cartaAnt.DestinatarioId);

            Destinatario.CantidadCartas += 1;
            DestinatarioAnt.CantidadCartas -= 1;
            repositorio.Modificar(Destinatario);
            repository.Modificar(DestinatarioAnt);
        }

        public override bool Modificar(Carta carta)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Carta CartaAnt = contexto.Carta.Find(carta.CartaId);

                var destinatario = contexto.Destinatario.Find(carta.DestinatarioId);

                if (carta.DestinatarioId != CartaAnt.DestinatarioId)
                {
                    CambiarBalances(carta, CartaAnt);
                }
                else
                {
                    destinatario.CantidadCartas += 1;
                }
                contexto = new Contexto();
                contexto.Entry(carta).State = EntityState.Modified;

                contexto.SaveChanges();
                paso = true;

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
    }
}
