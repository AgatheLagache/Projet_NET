using Console_NET_Project.Model.DinnerRoom;
using Console_NET_Project.Model.People.DinnerRoom;
using Console_NET_Project.Model.People.Kitchen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_NET_Project.Model
{
    public class RestaurantModel
    {
        public MaitreHotel maitreHotel;
        public GroupCustomer groupCustomer;
        public Chef chef;
        public Cook cook;
        public Waiter waiter;
        public HeadWaiter headWaiter;

        public List<HeadWaiter> listHeadWaiter;
        public List<GroupCustomer> listGroupCustomerWaiting;
        public List<Waiter> listWaiter;
        public List<Cook> listCook;
        public List<Table> listTable;
        public List<Command> listCommand = new List<Command>();
        public RestaurantModel(int nbGroupCustomer, int nbHeadWaiter, int nbCook, int nbWaiter)
        {
            InstanciateTable();
            InstanciateGroupCustomer(nbGroupCustomer);
            InstanciateMaitreHotel();
            InstanciateHeadWaiter(nbHeadWaiter);
            InstanciateChef();
            InstanciateCook(nbCook);
            InstanciateWaiter(nbWaiter);
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
            maitreHotel = MaitreHotel.Instance();
        }

        public void InstanciateChef()
        {
            chef = Chef.Instance();
        }
        public void AfficherGroup()
        {
            foreach (var list in listGroupCustomerWaiting)
            {
                Console.WriteLine("Dans le groupe n°" + list.Id + ", il y a " + list.NbPerson + " personnes");
            }
        }

        public void InstanciateHeadWaiter(int nbHeadWaiter)
        {
            listHeadWaiter = new List<HeadWaiter>();
            for (int i = 0; i < nbHeadWaiter; i++)
            {
                headWaiter = new HeadWaiter();
                listHeadWaiter.Add(headWaiter);
            }
        }

        private void InstanciateCook(int nbCook)
        {
            listCook = new List<Cook>();
            for (int i = 0; i < nbCook; i++)
            {
                cook = new Cook();
                listCook.Add(cook);
            }
        }

        private void InstanciateWaiter(int nbWaiter)
        {
            listWaiter = new List<Waiter>();
            for (int i = 0; i < nbWaiter; i++)
            {
                waiter = new Waiter();
                listWaiter.Add(waiter);
            }
        }

        public void AfficherListe()
        {
            Console.WriteLine("Liste des commandes");
            foreach (var list in listCommand)
            {
                Console.WriteLine("Nom plat : " + list.Dishes + " et état : " + list.IsReady);
            }
        }
    }
}