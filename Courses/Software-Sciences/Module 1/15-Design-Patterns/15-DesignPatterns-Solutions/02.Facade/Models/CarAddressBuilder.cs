using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Facade
{
    public class CarAddressBuilder : CarBuilderFacade
    {
        public CarAddressBuilder(Car car)
        {
            Car = car;
        }

        public CarAddressBuilder InCity(string city)
        {
            Car.City = city;
            return this;
        }

        public CarAddressBuilder AtAddress(string address)
        {
            Car.Address = address;
            return this;
        }
    }
}
