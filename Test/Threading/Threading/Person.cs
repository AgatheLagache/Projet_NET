using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public abstract class Person
    {
        public static List<GroupCustomer> listGroupCustomerOnTable = new List<GroupCustomer>();
        protected bool IsBusy { get; set; }
        public int Id { get; protected set; }
        public Person()
        {
            
        }
    }
}