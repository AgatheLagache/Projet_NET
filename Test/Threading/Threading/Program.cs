using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant(10);
            restaurant.AfficherGroup();

            /* Thread du MaitreHotel */
            Thread threadMaitreHotel = new Thread(() => restaurant.maitreHotel.PlaceCustomer(restaurant.listTable, restaurant.listGroupCustomerWaiting));
            threadMaitreHotel.Start();

            //Thread threadCustomer = new Thread(() => restaurant.groupCustomer.Exit(3, restaurant.listTable));
            //threadCustomer.Start();

            //restaurant.AfficheTable();

            Thread.Sleep(5000);
            restaurant.groupCustomer.Exit(3, restaurant.listTable);
            Thread.Sleep(5000);
            restaurant.groupCustomer.Exit(2, restaurant.listTable);
            Console.ReadKey();
        }
    }
}