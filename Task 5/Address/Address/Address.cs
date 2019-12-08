using System;
using System.Collections.Generic;
using System.Text;

namespace Address
{
    class Address
    {   
        public int Index { get; set; }
        
        public int House { get; set; }

        public int Apartment { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }


        public Address (string country, string city, string street, 
                        int house, int index, int apartment)
        {
            Country = country;
            City = city;
            Street = street;
            House = house;
            Index = index;
            Apartment = apartment;
        }

        internal void Show ()
        {
            Console.WriteLine(" Страна - {0} \n Город - {1} \n Улица - {2} \n Дом № - {3} \n " +
                "Индекс - {4} \n Квартира № - {5}", Country, City, Street, House, Index, Apartment);
        }
    }
}
