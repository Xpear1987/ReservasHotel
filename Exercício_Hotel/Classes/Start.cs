using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Hotel.Classes
{
    class Start
    {
        public string FStart(int input)
        {
            Call call = new Call();
            switch (input)
            {
                case 1:
                    call.CallByName();
                    return FStart(input);
                case 2:
                    call.CallById();
                    return FStart(input);
                case 3:
                    call.CallBooked();
                    return FStart(input);
                case 4:
                    call.Finished();
                    return null;
                default:
                    return "Opção não encontrada";
                    // return to start
            }
        }
    }
}
