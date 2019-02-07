using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Metodos
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);

            return retorno;
        }

        public static List<Destinatario> FiltrarCuentas(int index, string criterio, DateTime desde, DateTime hasta)
        {
            Expression<Func<Destinatario, bool>> filtro = p => true;
            Repositorio<Destinatario> repositorio = new Repositorio<Destinatario>();
            List<Destinatario> list = new List<Destinatario>();

            int id = ToInt(criterio);
            switch (index)
            {
                case 0://Todo
                    break;

                case 1://Todo por fecha
                    filtro = p => p.Fecha >= desde && p.Fecha <= hasta;
                    break;

                case 2://DestinatarioId
                    filtro = p => p.DestinatarioId == id && p.Fecha >= desde && p.Fecha <= hasta;
                    break;

                case 3://Nombres
                    filtro = p => p.Nombres.Contains(criterio) && p.Fecha >= desde && p.Fecha <= hasta;
                    break;
            }

            list = repositorio.GetList(filtro);

            return list;
        }

        public static List<Carta> FiltrarDepositos(int index, string criterio, DateTime desde, DateTime hasta)
        {
            Expression<Func<Carta, bool>> filtro = p => true;
            Repositorio<Carta> repositorio = new Repositorio<Carta>();
            List<Carta> list = new List<Carta>();

            int id = ToInt(criterio);
            switch (index)
            {
                case 0://Todo
                    break;

                case 1://Todo por fecha
                    filtro = p => p.Fecha >= desde && p.Fecha <= hasta;
                    break;

                case 2://CartaId
                    filtro = p => p.CartaId == id && p.Fecha >= desde && p.Fecha <= hasta;
                    break;

                case 3://DestinatarioId
                    filtro = p => p.DestinatarioId == id && p.Fecha >= desde && p.Fecha <= hasta;
                    break;

                case 4://Inicio del Cuerpo
                    filtro = p => p.Cuerpo.Contains(criterio) && p.Fecha >= desde && p.Fecha <= hasta;
                    break;
            }

            list = repositorio.GetList(filtro);

            return list;
        }

    }
}
