using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_ipp
{
    class Program
    {
        static void Main(string[] args)
        {
            new LuxuryCarDecorator(new Niva()).showCar();
            var st1 = new Strategy(new LuxuryCarDecorator(new Mercedes()));
            var st2 = new Strategy(new SportCarDecorator(new Mercedes()));

            st1.showMe();
            st2.showMe();

            CarFactory.getSportMerecedes().showCar();

            Console.ReadKey();
        }
    }
}
