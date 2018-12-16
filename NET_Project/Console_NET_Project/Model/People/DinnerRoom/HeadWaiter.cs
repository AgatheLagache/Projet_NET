using Console_NET_Project.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_NET_Project.Model.DinnerRoom
{
    public class HeadWaiter : Person
    {
        public HeadWaiter()
        {

        }
        public void ReceiveOrder()
        {
            /* reçoit les ordres du maitre d'hotel */
        }

        public void GiveMenu()
        {
            /* donne les menu aux clients */
        }

        public void TakeOrder()
        {
            int orderTimeAverage = (10/60); //Temps moyen pour prendre une commande (10s/client avec modif échelle de temps)
            int number = GroupCustomer.groupCustomer.Count();
            Thread.Sleep(orderTimeAverage*number*1000);
        }

        public void GiveOrderToCommisChef()
        {
            /* donne les commandes aux commis de cuisine */
        }

        public void PutTable()
        {
            /* met la table après le passage de client */
        }
    }
}
