using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_NET_Project.Model
{
    public class History
    {
        private int scenario;

        public History()
        {
            this.SetScenario(this.ChooseScenario());
            this.InitializeScenario(this.scenario);
        }

        public int ChooseScenario()
        {
            /* faire un random ou par variable entrée en paramètre */
            return 0;
        }

        public void InitializeScenario(int numberScenario)
        {
            /* initialisation du scenario */
        }

        public int GetScenario()
        {
            return 0;
        }

        public void SetScenario(int numberScenario)
        {
            this.scenario = numberScenario;
        }
    }
}
