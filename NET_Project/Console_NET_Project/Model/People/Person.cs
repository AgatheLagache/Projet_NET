using Console_NET_Project.Model.DinnerRoom;
using Console_NET_Project.Model.People.DinnerRoom;
using Console_NET_Project.Model.People.Kitchen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_NET_Project.Model.People
{
    public class Person
    {
        public List<GroupCustomer> listGroupCustomer;
        public List<HeadWaiter> listHeadWaiter;
        public List<Waiter> listWaiter;
        public MaitreHotel maitreHotel;
        public Chef chef;
        public List<CommisChef> listCommisChef;
        public List<Cook> listCook;

        public bool IsBusy { get; set; } = true;
        public Person()
        {
            /* faire des for each pour remplir les listes en fonctions du paramètre envoyé et leur attribué un état busy pour chaque personne */
            /* pour les groupes clients il faut leur attribuer le numéro de table et leur etat */

            listGroupCustomer = new List<GroupCustomer>();
            listHeadWaiter = new List<HeadWaiter>();
            maitreHotel = MaitreHotel.Instance();
            listWaiter = new List<Waiter>();
            chef = new Chef();
            listCommisChef = new List<CommisChef>();
            listCook = new List<Cook>();
        }
    }
}