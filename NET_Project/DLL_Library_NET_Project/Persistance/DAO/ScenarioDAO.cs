using System.ComponentModel.DataAnnotations.Schema;

namespace DLL_Library_NET_Project.Persistance.DAO
{
    [Table("Scenario")]
    public class ScenarioDAO
    {
        public int id { get; set; }
        public string titre { get; set; }
    }
}