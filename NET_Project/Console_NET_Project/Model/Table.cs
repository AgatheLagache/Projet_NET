using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_NET_Project.Model
{
    public class Table
    {
        private int nbPlace;

        private bool isAvailable;

        List<Table> listTable;

        Table(int nbPlace, bool isAvailable)
        {
            /* faire la création des tables une par une en leur ajoutant les attributs respectifs et ensuite stocker les tables dans la liste */
            listTable = new List<Table>();
            this.SetNbPlace(nbPlace);
            this.SetAvailability(isAvailable);
        }

        public int GetNbPlace()
        {
            return 0;
        }

        public void SetNbPlace(int place)
        {
            this.nbPlace = place;
        }

        public bool GetAvailability()
        {
            return true;
        }

        public void SetAvailability(bool available)
        {
            this.isAvailable = available;
        }
    }
}
