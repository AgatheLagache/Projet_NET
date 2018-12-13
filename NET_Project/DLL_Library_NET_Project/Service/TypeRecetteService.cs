using DLL_Library_NET_Project.Business;
using DLL_Library_NET_Project.Business.Mapper;
using DLL_Library_NET_Project.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Library_NET_Project.Service
{
    public class TypeRecetteService
    {
        private Context context;

        public TypeRecetteService()
        {
            context = new Context();
        }

        public void Add(TypeRecette typeRecette)
        {
            var entity = TypeRecetteMapper.Map(typeRecette);
            context.TypeRecette.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = (from c in context.TypeRecette where c.id == id select c).FirstOrDefault();
            if (entity != null)
            {
                context.TypeRecette.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(TypeRecette typeRecette)
        {
            var entity = (from c in context.TypeRecette where c.id == typeRecette.id select c).FirstOrDefault();
            if (entity != null)
            {
                entity.type = typeRecette.type;
                context.SaveChanges();
            }
        }

        public List<TypeRecette> Get()
        {
            return (from c in context.TypeRecette select TypeRecetteMapper.Map(c)).ToList();
        }

        public TypeRecette GetById(int id)
        {
            return (from c in context.TypeRecette where c.id == id select TypeRecetteMapper.Map(c)).FirstOrDefault();
        }
    }
}