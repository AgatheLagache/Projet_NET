using DLL_Library_NET_Project.Business;
using DLL_Library_NET_Project.Business.Mapper;
using DLL_Library_NET_Project.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DLL_Library_NET_Project.Service
{
    public class ActionScenarioService
    {
        private Context context;

        public ActionScenarioService()
        {
            context = new Context();
        }

        public void Add(ActionScenario actionScenario)
        {
            var entity = ActionScenarioMapper.Map(actionScenario);
            context.ActionScenario.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id_action, int id_scenario)
        {
            var entity = (from c in context.ActionScenario where c.actionId == id_action && c.scenarioId == id_scenario select c).FirstOrDefault();
            if (entity != null)
            {
                context.ActionScenario.Remove(entity);
                context.SaveChanges();
            }
        }

        public void DeleteAllFromScenarioId(int id)
        {
            var entity = from c in context.ActionScenario where c.scenarioId == id select c;
            if (entity != null)
            {
                foreach (var entities in entity)
                {
                    context.ActionScenario.Remove(entities);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteAllFromActionId(int id)
        {
            var entity = (from c in context.ActionScenario where c.actionId == id select c);
            if (entity != null)
            {
                foreach (var entities in entity)
                {
                    context.ActionScenario.Remove(entities);
                    context.SaveChanges();
                }
            }
        }

        //public void Update(ActionScenario actionScenario)
        //{
        //    var entity = (from c in context.ActionScenario where c.actionId == actionScenario.??? && c.scenarioId == actionScenario.??? select c).FirstOrDefault();
        //    if (entity != null)
        //    {
        //        entity.ordre = actionScenario.ordre;
        //        context.SaveChanges();
        //    }
        //}

        public List<ActionScenario> Get()
        {
            return (from c in context.ActionScenario select ActionScenarioMapper.Map(c)).ToList();
        }

        public List<ActionScenario> GetByActionId(int id_action)
        {
            return (from c in context.ActionScenario.Include(i => i.Action).Include(i => i.Action.Acteur).Include(i => i.Scenario) where c.actionId == id_action select ActionScenarioMapper.Map(c)).ToList();
        }

        public List<ActionScenario> GetByScenarioId(int id_scenario)
        {
            return (from c in context.ActionScenario.Include(i => i.Action).Include(i => i.Action.Acteur).Include(i => i.Scenario) where c.scenarioId == id_scenario select ActionScenarioMapper.Map(c)).ToList();
        }
    }
}