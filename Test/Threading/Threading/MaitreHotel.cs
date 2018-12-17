using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    public class MaitreHotel : Person
    {
        public MaitreHotel()
        {

        }
        public void PlaceCustomer(List<Table> listTable, List<GroupCustomer> listCustomer)
        {
            while(listCustomer.Count != 0)
            {
                foreach (var table in listTable)
                {
                    if (table.Availibility == true)
                    {
                        var groupQuery = (from groups in listCustomer select groups).FirstOrDefault();
                        if(groupQuery != null)
                        {
                            Console.WriteLine("Table Disponible");
                            groupQuery.NumeroTable = table.Id;
                            table.Availibility = false;
                            listGroupCustomerOnTable.Add(groupQuery);
                            listCustomer.Remove(groupQuery);
                        }
                    }
                    else
                    {
                        //Console.WriteLine("Table occupée");
                    }
                }
            }
        }
    }
}
