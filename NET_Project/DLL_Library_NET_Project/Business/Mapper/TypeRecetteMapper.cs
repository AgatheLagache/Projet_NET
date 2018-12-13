using DLL_Library_NET_Project.Persistance.DAO;
using System.Collections.Generic;
using System.Linq;

namespace DLL_Library_NET_Project.Business.Mapper
{
    public class TypeRecetteMapper
    {
        public static TypeRecetteDAO Map(TypeRecette value)
        {
            return new TypeRecetteDAO
            {
                id = value.id,
                type = value.type
            };
        }

        public static TypeRecette Map(TypeRecetteDAO value)
        {
            return new TypeRecette
            {
                id = value.id,
                type = value.type
            };
        }

        public static List<TypeRecette> Map(List<TypeRecetteDAO> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}