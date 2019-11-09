using System;
using System.Collections.Generic;
using System.Text;

namespace Address
{
    class Address
    {
        int index, house, apartment;
        string country, city, street;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public Address (string country, string city, string street, 
                        int house, int index, int apartment)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.index = index;
            this.apartment = apartment;
        }

        public void Show ()
        {
            Console.WriteLine(" Страна - {0} \n Город - {1} \n Улица - {2} \n Дом № - {3} \n " +
                "Индекс - {4} \n Квартира № - {5}", country, city, street, house, index, apartment);
        }
    }
}
