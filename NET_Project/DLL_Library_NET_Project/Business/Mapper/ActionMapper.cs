using DLL_Library_NET_Project.Persistance.DAO;
using System.Collections.Generic;
using System.Linq;

namespace DLL_Library_NET_Project.Business.Mapper
{
    public class ActionMapper
    {
        public static ActionDAO Map(Action value)
        {
            return new ActionDAO
            {
                id = value.id,
                description = value.description,
                acteurId = ActeurMapper.Map(value.Acteur).id
            };
        }

        public static Action Map(ActionDAO value)
        {
            return new Action
            {
                id = value.id,
                description = value.description,
                Acteur = ActeurMapper.Map(value.Acteur)
            };
        }

        public static List<Action> Map(List<ActionDAO> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}