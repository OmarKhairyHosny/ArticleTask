using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleTask.Managers
{
    public static class Mgrs
    {
        private static ArticleManager articleManager;
        public static ArticleManager ArticleManager
        {
            get
            {
                if (articleManager == null)
                    articleManager = new ArticleManager();
                return articleManager;
            }
        }
        private static CategoryManager categoryManager;
        public static CategoryManager CategoryManager
        {
            get
            {
                if (categoryManager == null)
                    categoryManager = new CategoryManager();
                return categoryManager;
            }
        }
        private static CommentManager commentManager;
        public static CommentManager CommentManager
        {
            get
            {
                if (commentManager == null)
                    commentManager = new CommentManager();
                return commentManager;
            }
        }
    }
}
