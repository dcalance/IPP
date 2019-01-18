using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_ipp
{
    class CarDecorator : Car
    {
        protected Car car;

        public CarDecorator(Car c)
        {
            this.car = c;
        }

        public virtual void showCar()
        {
            car.showCar();
        }
    }
}
