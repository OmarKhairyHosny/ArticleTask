using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArticleTask.DAL;

namespace ArticleTask.Managers
{
    public class CommentManager : Repository<Comment, TaskEntities>
    {
        public CommentManager() : base(MainDataBase.MainDatabase)
        {

        }
    }
}