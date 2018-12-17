using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_NET_Project
{
    public static class Parametres
    {
        public static int NumberWaiters { get; set; } = 1;
        public static int NumberCooks { get; set; } = 1;
        public static int NumberScenario { get; set; } = 1;
        public static int NumberHeadwaiters { get; internal set; } = 1;
        public static int NumberClients { get; internal set; } = 1;
    }
}
