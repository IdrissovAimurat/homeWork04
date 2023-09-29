using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork04
{
    public partial class Car
    {
        public void Drive()
        {
            if (isRunning)
            {
                Console.WriteLine("прт тра тра тра рррррррыыаааааааааааааааааааааааааа, АВТООООООООООМООБИИИИИИИИИЛЬ в движении.");
            }
            else
            {
                Console.WriteLine("Заведите ААААААААААААВТОМОООООБИИИИЛЬ перед началом движения.");
            }
        }
    }
}
