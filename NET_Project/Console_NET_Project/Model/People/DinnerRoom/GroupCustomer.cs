using Console_NET_Project.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using WPF_NET_Project;

namespace Console_NET_Project.Model.DinnerRoom
{
    public class GroupCustomer : Person
    {
        public static List<Customer> groupCustomer { get; set; }
        private bool IsWaiting { get; set; }
        public int bill = 0;
        private Random NumberRandom = new Random();
        private int priceMenu;
        private int customerNumber;

        public GroupCustomer()
        {
            groupCustomer = new List<Customer>();
            customerNumber = NumberRandom.Next(1, 11);
        }

        public void IsHere()
        {
            IsWaiting = false;
            /* client vient d'arriver */
        }

        public static int GetNumberPerson()
        {
            int number = groupCustomer.Count();
            return number;
        }

        public void ExitRestaurant()
        {
            /* suppression du groupe de client */
        }

        public void Paysbill()
        {
            /* méthode de paiement */
            bill = priceMenu * customerNumber;
        }

        public void Behaviour()
        {

        }

        public void ChooseStarter()
        {
            /* Choix de l'entrée */
        }

        public void ChooseDishes()
        {
            /* choix du menu */
        }

        public void ChooseDessert()
        {
            /* choix du dessert */
        }
        
        public void CommandOrder()
        {
            switch (Parametres.NumberScenario)
            {
                case 0: //Entrée-Plat
                    ChooseStarter();
                    ChooseDishes();
                    priceMenu = 20;
                    break;

                case 1: //Plat-Dessert
                    ChooseDishes();
                    ChooseDessert();
                    priceMenu = 25;

                    break;

                case 2: //Entrée-Plat-Dessert
                    ChooseStarter();
                    ChooseDishes();
                    ChooseDessert();
                    priceMenu = 35;
                    break;

                default:
                    break;
            }
        }
    }
}
