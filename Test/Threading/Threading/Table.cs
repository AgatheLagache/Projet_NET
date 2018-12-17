using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class Table
    {
        public bool Availibility { get; set; }
        public int Id { get; private set; }
        public int NbPlace { get; private set; }
        public Table(int nbPlace, int id)
        {
            Availibility = true;
            NbPlace = nbPlace;
            Id = id;
        }
    }
}