using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Hotel.Classes
{
    class ListaReservas
    {
        List<Call> reservas = new List<Call>();
        Call call = new Call();
        public void FCall(string reserva)
        {
            //var call = new Call { NomeHotel = reserva, IdHotel = 0 };
            call.NomeHotel = reserva;
            call.IdHotel = 0;
            reservas.Add(call);
        }
        public void FCall(int reserva)
        {
            //var call = new Call { IdHotel = reserva, NomeHotel = "" };
            call.NomeHotel = "";
            call.IdHotel = reserva;
            reservas.Add(call);
        }

        public void ListaPrint()
        {
            foreach (Call i in reservas)
            {
                call.Exibir();
            }
        }
    }
}
