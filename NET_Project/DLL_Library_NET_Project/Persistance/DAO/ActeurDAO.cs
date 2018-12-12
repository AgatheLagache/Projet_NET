using System.ComponentModel.DataAnnotations.Schema;

namespace DLL_Library_NET_Project.Persistance.DAO
{
    [Table("Acteur")]
    public class ActeurDAO
    {
        public int id { get; set; }
        public string role { get; set; }
    }
}