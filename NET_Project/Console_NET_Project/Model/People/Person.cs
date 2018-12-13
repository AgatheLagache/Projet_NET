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
        List<GroupCustomer> listGroupCustomer;
        List<HeadWaiter> listHeadWaiter;
        List<Waiter> listWaiter;
        MaitreHotel maitreHotel;
        Chef chef;
        List<CommisChef> listCommisChef;
        List<Cook> listCook;
        public Person()
        {
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