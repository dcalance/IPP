using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_ipp
{
    class Strategy   
    {
        private Car car;

        public Strategy(Car c)
        {
            car = c;
        }
        public void showMe()
        {
            car.showCar();
        }
    }
}
