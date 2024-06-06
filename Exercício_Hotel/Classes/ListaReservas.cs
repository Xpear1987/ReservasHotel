using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Hotel.Classes
{
    class ListaReservas
    {
        public List<Call> reservas = new List<Call>()
        { new Call { IdHotel = 456, NomeHotel = "hotel sp" },
           new Call { IdHotel = 789, NomeHotel = "hotel mg" }, 
           new Call { IdHotel = 123, NomeHotel = "hotel ms" } };


        public void AddReserva(string reserva, int reservaint)
        {
            List<Call> verf1 = (from r in reservas
                                where reserva == r.NomeHotel
                                select r).ToList();
            List<Call> verf2 = (from t in reservas
                                where reservaint == t.IdHotel
                                select t).ToList();
            Console.WriteLine(verf1.Count);
            Console.WriteLine(verf2.Count);
            switch (verf1.Count == 0 && verf2.Count == 0)
            {
                case true:
                    Call call = new Call
                    {
                        //var call = new Call { NomeHotel = reserva, IdHotel = 0 };
                        NomeHotel = reserva,
                        IdHotel = reservaint
                    };
                    reservas.Add(call);
                    Console.WriteLine("Cadastro feito com sucesso.");
                    break;
                case false:
                    if (verf1.Count != 0)
                    {
                        Console.WriteLine("Nome de hotel indisponível.");
                    }
                    if (verf2.Count != 0)
                    {
                        Console.WriteLine("Id de hotel indisponível.");
                    }
                    break;
            }
        }

        public void ListaPrintNome()
        {
            /*IEnumerable<string> temp = reservas.OfType<string>();
            foreach (string i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(".");*/
            var j = 1;
            List<Call> listaNome =
                (from r in reservas
                 orderby r.NomeHotel
                 select r).ToList();
            foreach (Call r in listaNome)
            {
                Console.WriteLine($"{j++}- Nome: {r.NomeHotel} Id: {r.IdHotel}.");
            }
        }
        
        public void Excluir(Call del, List<Call> listDel)
        {
            //var remove = del.NomeHotel == String.Empty ? listDel.SingleOrDefault(s => s.IdHotel == del.IdHotel) : listDel.SingleOrDefault(s => s.NomeHotel == del.NomeHotel);
            var remove = (from s in listDel 
                            where del.NomeHotel == s.NomeHotel
                            || del.IdHotel == s.IdHotel
                            select s).FirstOrDefault();
            if (listDel.Contains(remove))
            {
                Console.WriteLine($"A reserva encontrada foi essa:\n Nome: {remove.NomeHotel} Id: {remove.IdHotel}.");
                Console.WriteLine("Confirma que deseja excluir essa reserva? 1 para sim, qualquer outra tecla para não.");
                var conf = Console.ReadLine();
                if (conf == "1")
                {
                    listDel.Remove(remove);
                    Console.WriteLine("Sua reserva foi excluida.");
                }
            }
            else
            {
                Console.WriteLine("Reserva não existente.");
            }
        }

        public void VerifyRes(string reserva)
        {
            var result = (from r in reservas
                         where reserva == r.NomeHotel
                         select r).FirstOrDefault();
            //var result = reservas.SingleOrDefault(r => r.NomeHotel == reserva);
            if (result != null)
            {
                Console.WriteLine($"Sua reserva é essa:\n Nome: {result.NomeHotel} Id: {result.IdHotel}.");
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }
        public void VerifyRes(int reserva)
        {
            var result = (from r in reservas
                          where reserva == r.IdHotel
                          select r).FirstOrDefault();
            //var result = reservas.SingleOrDefault(r => r.NomeHotel == reserva);
            if (result != null)
            {
                Console.WriteLine($"Sua reserva é essa:\n Nome: {result.NomeHotel} Id: {result.IdHotel}.");
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }
    }
}
