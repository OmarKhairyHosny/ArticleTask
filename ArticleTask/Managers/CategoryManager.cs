using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArticleTask.DAL;

namespace ArticleTask.Managers
{
    public class CategoryManager : Repository<Category, TaskEntities>
    {
        public CategoryManager( ) : base(MainDataBase.MainDatabase)
        {

        }
    }
}