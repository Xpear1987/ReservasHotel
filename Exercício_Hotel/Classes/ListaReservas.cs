using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Hotel.Classes
{
    class ListaReservas
    {
        List<string> reservas = new List<string>;
        
        public void ListaAdd(string reserva)
        {
            reservas.Add(reserva);
        }

        public void ListaPrint()
        {
            foreach (string i in reservas)
            {
                Console.WriteLine(i);
            }
        }
    }
}
