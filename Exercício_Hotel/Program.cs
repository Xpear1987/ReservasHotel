using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_Hotel.Classes;

namespace Exercício_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            Start start = new Start();
            start(input);

        }
    }
}

/* 
classe para ler o input do usuario
classe para achar hotel por número
classe para achar hotel por nome
classe para readline os hotéis com reserva
encerrar aplicação
*/