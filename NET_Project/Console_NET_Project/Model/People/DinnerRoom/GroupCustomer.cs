using Console_NET_Project.Model.People;
using DLL_Library_NET_Project.Business;
using DLL_Library_NET_Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using WPF_NET_Project;

namespace Console_NET_Project.Model.DinnerRoom
{
    public class GroupCustomer : Person
    {
        public int bill = 0;
        private int priceMenu;
        //private int customerNumber;

        public int NumeroTable { get; set; }
        public int NbPerson { get; private set; }
        public bool IsServed { get; set; }
        public GroupCustomer(int nbPerson, int id)
        {
            NbPerson = nbPerson;
            Id = id;
            IsServed = false;
        }

        public void IsHere()
        {
            IsServed = false;
            /* client vient d'arriver */
        }

        public static void ExitRestaurant(int id, List<Table> listTable)
        {
            var groupQuery = (from groups in listGroupCustomerOnTable where groups.Id == id select groups).FirstOrDefault();
            if (groupQuery != null)
            {
                var groupTableQuery = (from table in listTable where table.Id == groupQuery.NumeroTable select table).FirstOrDefault();

                groupTableQuery.Availibility = true;
                listGroupCustomerOnTable.Remove(groupQuery);
                Console.WriteLine("Le groupe de client n°" + groupQuery.Id + " part du restaurant");
            }
            else
            {

            }
        }

        public void Paysbill()
        {
            /* méthode de paiement */
            //bill = priceMenu * customerNumber;
        }

        public void Behaviour()
        {

        }

        public void ChooseStarter()
        {
            /* Choix de l'entrée */
        }

        public static string ChooseDishes()
        {
            Random rand = new Random();
            RecetteService recetteService = new RecetteService();
            List<Recette> recettes = recetteService.GetByTypeId(2);
            int nb = rand.Next(recettes.Count);
            string command = recettes[nb].intitule;
            return command;
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
