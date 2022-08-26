using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealData.Context;
using RealData.Model;

namespace RealData.NewFolder
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (WarrenContext warrenContext = new WarrenContext()) //o using faz a conexão com o banco de dados ser fechada, para gerar mais segurança
            {
                list = warrenContext.Set<T>().ToList(); //transformando a classe em genérica
            }
            return list;
        }

        public virtual string Create(T model)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Set<T>().Add(model);
                //adiciona a info em baixo sempre que faz uma alteração no banco
                warrenContext.SaveChanges();
            }

            return "Created";
        }
    

        public virtual string Delete(int id)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Entry<T>(this.GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                warrenContext.SaveChanges();
            }
            return "Deletado pourran";
        }

       

        public virtual T GetById(int id)
        {
            T model = null;
           
            using (WarrenContext warrenContext = new WarrenContext()) //o using faz a conexão com o banco de dados ser fechada, para gerar mais segurança
            {
                model = warrenContext.Set<T>().Find(id); //transformando a classe em genérica
            }
            return model;
        }

        public virtual string Update(T model)
        {
            using(WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                warrenContext.SaveChanges();
            }

            return "Alterado";
        }
    }
}
