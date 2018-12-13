using DLL_Library_NET_Project.Persistance.DAO;
using System.Collections.Generic;
using System.Linq;

namespace DLL_Library_NET_Project.Business.Mapper
{
    public class ActionScenarioMapper
    {
        public static ActionScenarioDAO Map(ActionScenario value)
        {
            return new ActionScenarioDAO
            {
                ordre = value.ordre,
                actionId = ActionMapper.Map(value.Action).id,
                scenarioId = ScenarioMapper.Map(value.Scenario).id
            };
        }

        public static ActionScenario Map(ActionScenarioDAO value)
        {
            return new ActionScenario
            {
                ordre = value.ordre,
                Action = ActionMapper.Map(value.Action),
                Scenario = ScenarioMapper.Map(value.Scenario)
            };
        }

        public static List<ActionScenario> Map(List<ActionScenarioDAO> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}