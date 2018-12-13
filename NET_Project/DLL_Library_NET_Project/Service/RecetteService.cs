using DLL_Library_NET_Project.Business;
using DLL_Library_NET_Project.Business.Mapper;
using DLL_Library_NET_Project.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DLL_Library_NET_Project.Service
{
    public class RecetteService
    {
        private Context context;

        public RecetteService()
        {
            context = new Context();
        }

        public void Add(Recette recette)
        {
            var entity = RecetteMapper.Map(recette);
            context.Recette.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = (from c in context.Recette where c.id == id select c).FirstOrDefault();
            if (entity != null)
            {
                context.Recette.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(Recette recette)
        {
            var entity = (from c in context.Recette where c.id == recette.id select c).FirstOrDefault();
            if (entity != null)
            {
                entity.intitule = recette.intitule;
                entity.prix = recette.prix;
                entity.temps_prepa = recette.temps_prepa;
                entity.temps_cuiss = recette.temps_cuiss;
                entity.temps_repos = recette.temps_repos;
                //entity.typerecetteId = recette.TypeRecette;
                context.SaveChanges();
            }
        }

        public List<Recette> Get()
        {
            return (from c in context.Recette select RecetteMapper.Map(c)).ToList();
        }

        public Recette GetById(int id)
        {
            return (from c in context.Recette where c.id == id select RecetteMapper.Map(c)).FirstOrDefault();
        }

        public List<Recette> GetByTypeId(int id)
        {
            return (from c in context.Recette.Include(i => i.TypeRecette) where c.typerecetteId == id select RecetteMapper.Map(c)).ToList();
        }
    }
}