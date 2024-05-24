using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Hotel.Classes
{
    class Call
    {
        string reserva;
        ListaReservas lista = new ListaReservas();
        public void CallByName()
        {
            Console.WriteLine("Insira o nome do hotel que deseja fazer uma reserva:");
            reserva = Console.ReadLine();
            lista.ListaAdd(reserva);
            // return to start
        }
        public void CallById()
        {
            Console.WriteLine("Insira o Id do hotel que deseja fazer uma reserva:");
            reserva = Console.ReadLine();
            lista.ListaAdd(reserva);
            // return to start
        }
        public void CallBooked()
        {
            Console.WriteLine("Aqui estão as suas reservas:");
            lista.ListaPrint();
            // return to start
        }
        public void Finished()
        {
            // encerra aplicação
        }
}
