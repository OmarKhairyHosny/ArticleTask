using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleTask.DAL
{
    public class Repository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        TContext ctx;
        DbSet<TEntity> set;
        public Repository(TContext ctx)
        {
            this.ctx = ctx;
            set = ctx.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            set.Add(entity);
            return ctx.SaveChanges() > 0 ? entity : null;
        }

        public bool Delete(TEntity entity)
        {
            set.Remove(entity);
            return ctx.SaveChanges() > 0;
        }

        public IQueryable<TEntity> GetAll()
        {
            return set;
        }

        public List<TEntity> GetAllBind()
        {
            return set.ToList();
        }

        public TEntity GetById(params object[] id)
        {
            return set.Find(id);
        }

        public bool Update(TEntity entity)
        {
            set.Attach(entity);
            ctx.Entry(entity).State = EntityState.Modified;
            return ctx.SaveChanges() > 0;

        }
    }
}
