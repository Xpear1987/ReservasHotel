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
            start.FStart(input);

        }
    }
}
