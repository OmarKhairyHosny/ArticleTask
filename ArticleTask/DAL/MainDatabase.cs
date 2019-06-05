using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleTask;
using ArticleTask.Models;

namespace ArticleTask.DAL
{
    public static class MainDataBase
    {
        private static TaskEntities mainDatabase;

        public static TaskEntities MainDatabase
        {
            get
            {
                if (mainDatabase == null)
                    mainDatabase = new TaskEntities();
                return mainDatabase;
            }
        }
        
    }
}
