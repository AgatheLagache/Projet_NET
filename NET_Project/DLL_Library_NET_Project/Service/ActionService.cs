using DLL_Library_NET_Project.Business;
using DLL_Library_NET_Project.Business.Mapper;
using DLL_Library_NET_Project.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DLL_Library_NET_Project.Service
{
    public class ActionService
    {
        private Context context;

        public ActionService()
        {
            context = new Context();
        }

        public void Add(Action action)
        {
            var entity = ActionMapper.Map(action);
            context.Action.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = (from c in context.Action where c.id == id select c).FirstOrDefault();
            if (entity != null)
            {
                context.Action.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(Action action)
        {
            var entity = (from c in context.Action where c.id == action.id select c).FirstOrDefault();
            if (entity != null)
            {
                entity.description = action.description;
                //entity.acteurId = action.Acteur;
                context.SaveChanges();
            }
        }

        public List<Action> Get()
        {
            return (from c in context.Action select ActionMapper.Map(c)).ToList();
        }

        public Action GetById(int id)
        {
            return (from c in context.Action where c.id == id select ActionMapper.Map(c)).FirstOrDefault();
        }

        public List<Action> GetByActeurId(int id)
        {
            return (from c in context.Action.Include(i => i.Acteur) where c.acteurId == id select ActionMapper.Map(c)).ToList();
        }
    }
}