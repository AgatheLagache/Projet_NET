using Console_NET_Project.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if ()
            {

            }
        }

        public void ChooseTable()
        {
            /* choix de la table en fonction du nombre de personnes */
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
