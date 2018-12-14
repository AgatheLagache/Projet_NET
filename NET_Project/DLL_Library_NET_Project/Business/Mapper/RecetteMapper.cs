using DLL_Library_NET_Project.Persistance.DAO;
using System.Collections.Generic;
using System.Linq;

namespace DLL_Library_NET_Project.Business.Mapper
{
    public class RecetteMapper
    {
        public static RecetteDAO Map(Recette value)
        {
            return new RecetteDAO
            {
                id = value.id,
                intitule = value.intitule,
                prix = value.prix,
                temps_prepa = value.temps_prepa,
                typerecetteId = TypeRecetteMapper.Map(value.TypeRecette).id
            };
        }

        public static Recette Map(RecetteDAO value)
        {
            return new Recette
            {
                id = value.id,
                intitule = value.intitule,
                prix = value.prix,
                temps_prepa = value.temps_prepa,
                TypeRecette = TypeRecetteMapper.Map(value.TypeRecette)
            };
        }

        public static List<Recette> Map(List<RecetteDAO> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}