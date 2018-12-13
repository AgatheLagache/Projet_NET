using Console_NET_Project.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_NET_Project.Model.DinnerRoom
{
    public class GroupCustomer : Person
    {
        List<Customer> groupCustomer;

        public GroupCustomer()
        {
            groupCustomer = new List<Customer>();
        }
        public void IsHere()
        {
            /* client vient d'arriver */
        }

        public void GetNumberPerson()
        {
            /* retourner le nombre de client dans la liste */
        }

        public void ExitRestaurant()
        {
            /* suppression du groupe de client */
        }

        public void Paysbill()
        {
            /* méthode de paiement */
        }
    }
}
