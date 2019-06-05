using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArticleTask.DAL;

namespace ArticleTask.Managers
{
    public class ArticleManager : Repository<Article, TaskEntities>
    {
        public ArticleManager() : base(MainDataBase.MainDatabase)
        {
        }
    }
}