using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                Console.WriteLine("1 - Faça uma reserva.");
                Console.WriteLine("2 - Verifique se uma reserva já foi feita.");
                Console.WriteLine("3 - Visualize todas as suas reservas.");
                Console.WriteLine("4 - Exclua sua reserva.");
                Console.WriteLine("5 - Encerre o aplicativo.");
                var input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Insira o nome do hotel que deseja fazer uma reserva:");
                        var reservaAdd = Console.ReadLine();
                        Console.WriteLine("Insira o Id do hotel que deseja fazer uma reserva:");
                        var reservaAddInt = Convert.ToInt32(Console.ReadLine());
                        lista.AddReserva(reservaAdd, reservaAddInt);
                        break;
                    case 2:
                        Console.WriteLine("Insira o nome ou Id do hotel:");
                        var reservaU = Console.ReadLine();
                        bool myBool2 = Regex.IsMatch(reservaU, "^[0-9]+$");
                        if (myBool2 == true)
                        {
                            lista.VerifyRes(Convert.ToInt32(reservaU));
                        }
                        else
                        {
                            lista.VerifyRes(reservaU);
                        }
                        break;
                    case 3:
                        lista.ListaPrintNome();
                        break;
                    case 4:
                        Console.WriteLine("Insira o nome ou Id do hotel que deseje excluir, e caso deseje voltar, digite 0");
                        var del = Console.ReadLine();
                        if (del == "0")
                        {
                            break;
                        }
                        bool myBool = Regex.IsMatch(del, "^[0-9]+$");

                        string nomeHotel = "";
                        int idHotel = -1;
                        if (myBool == true)
                        {
                            idHotel = Convert.ToInt32(del);
                        }
                        else
                        {
                            nomeHotel = del;
                        }
                        lista.Excluir(new Call { IdHotel = idHotel, NomeHotel = nomeHotel }, lista.reservas);
                        break;
                    case 5:
                        return null;
                    default:
                        Console.WriteLine("Opção não encontrada");
                        break;
                }
            }
        }
    }
}
