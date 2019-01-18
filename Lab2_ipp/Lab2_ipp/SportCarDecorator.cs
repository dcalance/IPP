using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_ipp
{
    class SportCarDecorator : CarDecorator
    {
        public SportCarDecorator(Car c) : base(c)
        {
        }
        public override void showCar()
        {
            base.showCar();
            Console.WriteLine("and is a sport model");
        }
    }
}
