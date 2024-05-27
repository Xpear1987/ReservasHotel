using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Hotel.Classes
{
    class Start
    {
        public string FStart()
        {
            var lista = new ListaReservas();
            while (true)
            {
                Console.WriteLine("Por favor, insira sua opção:");
                Console.WriteLine("1 - Faça uma reserva pelo nome do hotel.");
                Console.WriteLine("2 - Faça uma reserva pelo número do hotel.");
                Console.WriteLine("3 - Visualize suas reservas");
                Console.WriteLine("4 - Encerre o aplicativo");
                var input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Insira o nome do hotel que deseja fazer uma reserva:");
                        var reserva = Console.ReadLine();
                        lista.FCall(reserva);
                        break;
                    case 2:
                        Console.WriteLine("Insira o ID do hotel que deseja fazer uma reserva:");
                        var reservaInt = Console.ReadLine();
                        lista.FCall(Convert.ToInt32(reservaInt));
                        break;
                    case 3:
                        lista.ListaPrint();
                        break;
                    case 4:
                        return "";
                    default:
                        Console.WriteLine("Opção não encontrada");
                        break;
                }
            }
        }
    }
}
