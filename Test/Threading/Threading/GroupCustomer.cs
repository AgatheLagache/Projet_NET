using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    public class GroupCustomer : Person
    {
        public int NumeroTable { get; set; }
        public int NbPerson { get; private set; }
        public GroupCustomer(int nbPerson, int id)
        {
            NbPerson = nbPerson;
            Id = id;
        }

        public void Exit(int id, List<Table> listTable)
        {
            var groupQuery = (from groups in listGroupCustomerOnTable where groups.Id == id select groups).FirstOrDefault();
            var groupTableQuery = (from table in listTable where table.Id == groupQuery.NumeroTable select table).FirstOrDefault();
            groupTableQuery.Availibility = true;
            listGroupCustomerOnTable.Remove(groupQuery);
            Console.WriteLine("aurevoir");
        }
    }
}