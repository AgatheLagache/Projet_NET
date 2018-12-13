using DLL_Library_NET_Project.Business;
using DLL_Library_NET_Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Library_NET_Project
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

        public static List<Scenario> GetAllScenarioFromDB()
        {
            ScenarioService scenarioService;
            scenarioService = new ScenarioService();
            List<Scenario> scenarioList = scenarioService.Get();
            return scenarioList;
        }
    }
}