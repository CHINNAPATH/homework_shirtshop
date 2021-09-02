using System;
using System.Collections.Generic;
///////////////___________________________________________CHINNAPATH JITTAMART 63120501061_________________________________________////////////////
namespace shirtshop
{
    class Program
    {
        static void Main(string[] args)
        {
            User jame = new User("jame");
            jame.name = "jame watson";
            jame.email = "jame@gmail.com";

            TShirt shirt1 = new TShirt("L", "Red", 500);
            TShirt shirt2 = new TShirt("M", "Black", 750);
            TShirt shirt3 = new TShirt("S", "", 625);
            List<TShirt> OderTShirt = new List<TShirt>();
            jame.addlist(shirt1);
            jame.addlist(shirt2);
            jame.addlist(shirt3);
            Address address = new Address();
            Console.WriteLine("Address :" + address.HomeAddress);
            Console.WriteLine("Street :" + address.street);
            Console.WriteLine("City :" + address.City);
            Console.WriteLine("Zipcode :" + address.zipCode);
            jame.getShoppingCart();
            Console.ReadLine();
        }
    }
    class TShirt
    {

        public string size;
        public string color;
        public float price;

        public TShirt(string valuesize, string valuecolor, float valueprice)
        {
            size = valuesize;
            color = valuecolor;
            price = valueprice;
        }

    }
    class ShoppingCart
    {
        private List<TShirt> OderTShirt = new List<TShirt>();
    }
    class User
    {
        public string name;
        public string email;
        private List<TShirt> OderTShirt = new List<TShirt>();

        public User(string valueName)
        {

            OderTShirt = new List<TShirt>();
        }
        public void addlist(TShirt shirt)
        {
            OderTShirt.Add(shirt);

        }

        public void getShoppingCart()
        {
            float i = 0;
            foreach (TShirt item in OderTShirt)
            {
                i = i + item.price;
            }
            Console.WriteLine(("\nTotal Price :  ") + i + (" THB"));

        }

    }
    class Address
    {
        public string HomeAddress, street, City, zipCode;
        public Address()
        {

            street = "   Phutthamonthon";
            City = "     Nakron Prathom";
            zipCode = "  10180";
            HomeAddress = "  131/75";
        }

    }
}
