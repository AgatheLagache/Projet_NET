﻿using Console_NET_Project.Model.DinnerRoom;
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
        public static List<GroupCustomer> listGroupCustomerOnTable = new List<GroupCustomer>();
        public bool IsBusy { get; set; }
        public int Id { get; protected set; }
        public Person()
        {

        }
    }
}