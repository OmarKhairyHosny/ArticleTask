using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleTask.DAL
{
    public interface IRepository<TEntity>
    {
        TEntity Add(TEntity entity);
        IQueryable<TEntity> GetAll();
        List<TEntity> GetAllBind();
        TEntity GetById(params object[] id);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
