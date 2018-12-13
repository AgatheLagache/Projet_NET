using System.ComponentModel.DataAnnotations.Schema;

namespace DLL_Library_NET_Project.Persistance.DAO
{
    public class RecetteDAO
    {
        public int id { get; set; }
        public string intitule { get; set; }
        public double prix { get; set; }
        public int temps_prepa { get; set; }
        public int typerecetteId { get; set; }

        [ForeignKey("typerecetteId")]
        public virtual TypeRecetteDAO TypeRecette { get; set; }
    }
}