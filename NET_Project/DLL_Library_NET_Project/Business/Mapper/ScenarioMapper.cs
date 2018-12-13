using DLL_Library_NET_Project.Persistance.DAO;
using System.Collections.Generic;
using System.Linq;

namespace DLL_Library_NET_Project.Business.Mapper
{
    public class ScenarioMapper
    {
        public static ScenarioDAO Map(Scenario value)
        {
            return new ScenarioDAO
            {
                id = value.id,
                titre = value.titre
            };
        }

        public static Scenario Map(ScenarioDAO value)
        {
            return new Scenario
            {
                id = value.id,
                titre = value.titre
            };
        }

        public static List<Scenario> Map(List<ScenarioDAO> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}