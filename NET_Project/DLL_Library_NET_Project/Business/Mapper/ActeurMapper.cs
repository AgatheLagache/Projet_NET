using DLL_Library_NET_Project.Persistance.DAO;
using System.Collections.Generic;
using System.Linq;

namespace DLL_Library_NET_Project.Business.Mapper
{
    public class ActeurMapper
    {
        public static ActeurDAO Map(Acteur value)
        {
            return new ActeurDAO
            {
                id = value.id,
                role = value.role
            };
        }

        public static Acteur Map(ActeurDAO value)
        {
            return new Acteur
            {
                id = value.id,
                role = value.role
            };
        }

        public static List<Acteur> Map(List<ActeurDAO> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}