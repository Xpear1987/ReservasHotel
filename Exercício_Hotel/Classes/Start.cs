using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Hotel.Classes
{
    class Start
    {
        public string start(int input)
        {
            Call call = new Call();
            switch (input)
            {
                case input == 1:
                    call.CallByName();
                    return start(input);
                case input == 2:
                    call.CallById();
                    return start(input);
                case input == 3:
                    call.CallBooked();
                    return start(input);
                case input == 4:
                    call.Finish();
                    return call.Finish();
                default:
                    return "Opção não encontrada";
                    // return to start
            }
        }
    }
}
