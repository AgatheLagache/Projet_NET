using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLL_Library_NET_Project.Persistance.DAO
{
    [Table("ActionScenario")]
    public class ActionScenarioDAO
    {
        public int id { get; set; }
        public int ordre { get; set; }
        public int actionId { get; set; }
        public int scenarioId { get; set; }

        [ForeignKey("actionId")]
        public virtual ActionDAO Action { get; set; }

        [ForeignKey("scenarioId")]
        public virtual ScenarioDAO Scenario { get; set; }
    }
}