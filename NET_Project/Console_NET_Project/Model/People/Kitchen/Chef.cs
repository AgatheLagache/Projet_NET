using Console_NET_Project.Model.DinnerRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_NET_Project.Model.People.Kitchen
{
    public class Chef : Person
    {
        private static Chef uniqueInstance;
        private Chef()
        {

        }

        public static Chef Instance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Chef();
            }
            return uniqueInstance;
        }
        public void TakeCommand()
        {
            /* prend la commande donnée par le chef de rang */
        }

        public void DispatchTask(List<Cook> listCook, List<Command> listCommand, List<GroupCustomer> listCustomer)
        {
            //listGroupCustomerOnTable.Count != 0
            while (!SocketServer._leave)
            {
                foreach (var list in listCook)
                {
                    Thread.Sleep(500);
                    list.IsBusy = true;
                    var commandQuery = (from command in listCommand where command.IsReady == "No" select command).FirstOrDefault();
                    if (commandQuery != null)
                    {
                        if(list.IsBusy == true)
                        {
                            Console.WriteLine("Le chef donne le " + commandQuery.Dishes + " à faire au cuisinier n°" + list.Id);
                            commandQuery.IsReady = "In progress";
                        }
                    }
                }
                //var cookQuery = (from cook in listCook where cook.IsBusy == false select cook).FirstOrDefault();
                //if (cookQuery != null)
                //{
                //    cookQuery.IsBusy = true;
                //    Thread.Sleep(500);
                //    var commandQuery = (from command in listCommand where command.IsReady == "No" select command).FirstOrDefault();
                //    if (commandQuery != null)
                //    {
                //        Console.WriteLine("distribu plat");
                //        commandQuery.IsReady = "In progress";
                //    }
                //}
                //foreach (var list in listCommand.ToList())
                //{
                //    if(list.IsReady == "No")
                //    {
                //        var cookQuery = (from cook in listCook where cook.IsBusy == false select cook).FirstOrDefault();
                //        if (cookQuery != null)
                //        {
                //            cookQuery.IsBusy = true;
                //            list.IsReady = "In progress";
                //        }
                //    }
                //}
            }
        }

        public void SortOrder()
        {
            /* trie les commandes afin d'optimiser la production des commandes */
        }
    }
}
