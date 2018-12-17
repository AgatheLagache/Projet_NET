using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    public class Restaurant
    {
        public MaitreHotel maitreHotel;
        public GroupCustomer groupCustomer;
        public List<GroupCustomer> listGroupCustomerWaiting;

        public List<Table> listTable;
        public Restaurant(int nbGroupCustomer)
        {
            InstanciateTable();
            InstanciateGroupCustomer(nbGroupCustomer);
            InstanciateMaitreHotel();
        }

        public void InstanciateGroupCustomer(int nombre)
        {
            Random rand = new Random();

            listGroupCustomerWaiting = new List<GroupCustomer>();
            for (int i = 0; i < nombre; i++)
            {
                groupCustomer = new GroupCustomer(rand.Next(2, 10), i);
                listGroupCustomerWaiting.Add(groupCustomer);
            }
        } 

        public void InstanciateTable()
        {
            listTable = new List<Table>();

            Table table = new Table(3, 0);
            listTable.Add(table);
            Table table1 = new Table(6, 1);
            listTable.Add(table1);
            Table table2 = new Table(9, 2);
            listTable.Add(table2);
            Table table3 = new Table(5, 3);
            listTable.Add(table3);
        }

        public void InstanciateMaitreHotel()
        {
            maitreHotel = new MaitreHotel();
        }
        public void AfficherGroup()
        {
            foreach (var list in listGroupCustomerWaiting)
            {
                Console.WriteLine("Dans le groupe n°" + list.Id + ", il y a " + list.NbPerson + " personnes");
            }
        }
        public void AfficheTable()
        {
            foreach (var list in listTable)
            {
                Console.WriteLine("La table n°" + list.Id + " possède " + list.NbPlace + " places. " + list.Availibility);
            }
        }
    }
}
