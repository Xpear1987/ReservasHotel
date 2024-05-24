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
        public void CallByName()
        {
            Console.WriteLine("Insira o nome do hotel que deseja fazer uma reserva:");
            reserva = Console.ReadLine();
            ListaReservas.ListaAdd(reserva);
            // return to start
        }
        public void CallByNumbe()
        {
            Console.WriteLine("Insira o Id do hotel que deseja fazer uma reserva:");
            reserva = Console.ReadLine();
            ListaReservas.ListaAdd(reserva);
            // return to start
        }
        public void CallBooked()
        {
            Console.WriteLine("Aqui estão as suas reservas:");
            ListaReservas.ListaPrint();
            // return to start
        }
        public void Finished()
        {
            // encerra aplicação
        }
}
