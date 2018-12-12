using System.ComponentModel.DataAnnotations.Schema;

namespace DLL_Library_NET_Project.Persistance.DAO
{
    [Table("Action")]
    public class ActionDAO
    {
        public int id { get; set; }
        public string description { get; set; }
        public int acteurId { get; set; }

        [ForeignKey("acteurId")]
        public virtual ActeurDAO Acteur { get; set; }
    }
}