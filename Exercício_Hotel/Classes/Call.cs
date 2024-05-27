using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Hotel.Classes
{
    class Call
    {
        public string NomeHotel { get; set; }
        public int IdHotel { get; set; }


        public void Exibir()
        {
            Console.WriteLine("Aqui estão as suas reservas:");
            Console.WriteLine(NomeHotel + ", " + IdHotel);
            Console.WriteLine("----------------------------");
        }
    }
}
