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
            while (!SocketServer._leave)
            {
                foreach (var table in listTable)
                {
                    Thread.Sleep(1500);
                    if (table.Availibility == true)
                    {
                        var groupQuery = (from groups in listCustomer select groups).FirstOrDefault();
                        if (groupQuery != null)
                        {
                            groupQuery.NumeroTable = table.Id;
                            table.Availibility = false;
                            listGroupCustomerOnTable.Add(groupQuery);
                            listCustomer.Remove(groupQuery);
                            Console.WriteLine("Le maitre d'hotel a réservé la table n°" + table.Id + " au groupe n°" + groupQuery.Id);
                        }
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
