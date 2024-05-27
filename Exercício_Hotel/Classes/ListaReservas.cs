using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Hotel.Classes
{
    class ListaReservas
    {
        private List<Call> reservas = new List<Call>();
        
        public void FCall(string reserva)
        {
            Call call = new Call();
            //var call = new Call { NomeHotel = reserva, IdHotel = 0 };
            call.NomeHotel = reserva;
            call.IdHotel = 0;

            reservas.Add(call);
        }
        public void FCall(int reserva)
        {
            Call call = new Call();
            //var call = new Call { IdHotel = reserva, NomeHotel = "" };
            call.NomeHotel = "";
            call.IdHotel = reserva;
            reservas.Add(call);
        }

        public void ListaPrint()
        {
            foreach (Call i in reservas)
            {
                i.Exibir();
            }
        }
    }
}
