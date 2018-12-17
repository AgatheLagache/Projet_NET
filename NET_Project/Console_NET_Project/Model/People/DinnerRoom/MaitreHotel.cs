using Console_NET_Project.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_NET_Project.Model.DinnerRoom
{
    public class MaitreHotel : Person
    {
        private static MaitreHotel uniqueInstance;
        private MaitreHotel()
        {

        }

        public static MaitreHotel Instance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new MaitreHotel();
            }
            return uniqueInstance;
        }

        public void AskNumberPerson()
        {
            /* demande le nombre de client à l'entrée du restaurant */
        }

        public void PlaceCustomer(List<Table> listTable, List<GroupCustomer> listCustomer)
        {
            //listCustomer.Count != 0
            while (true)
            {
                foreach (var table in listTable)
                {
                    Thread.Sleep(500);
                    if (table.Availibility == true)
                    {
                        var groupQuery = (from groups in listCustomer select groups).FirstOrDefault();
                        if (groupQuery != null)
                        {
                            Console.WriteLine("Table Disponible");
                            groupQuery.NumeroTable = table.Id;
                            table.Availibility = false;
                            listGroupCustomerOnTable.Add(groupQuery);
                            listCustomer.Remove(groupQuery);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Table occupée");
                    }
                }
            }
        }

        public void AskHeadWaiter()
        {
            /* appelle le chef de rang pour placer les clients sur la bonne table */
        }

        public void GiveOrder()
        {
            /* donne les ordres au chef de rang */
        }

        public void TakePaysbill()
        {
            /* prend les paiements des clients */
        }
    }
}
