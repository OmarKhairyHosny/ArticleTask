using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArticleTask.Managers;

namespace ArticleTask.Controllers
{
    public class ArticleController : Controller
    {
        public List<Category> Categories { get; set; }
        public ArticleController()
        {
            Categories = Mgrs.CategoryManager.GetAllBind();
        }
        // GET: Article
        public ActionResult Index()
        {
          
            return View(Categories);
        }
        [HttpPost]
        public ActionResult AddArticle(string Name, int CategoryId)
        {
            Article article = new Article() { Name = Name, CategoryId_FK = CategoryId };
            Mgrs.ArticleManager.Add(article);
            var Categories = Mgrs.CategoryManager.GetAllBind();
            return PartialView("_ArticalTable", Categories);
        }
        [HttpPost]
        public ActionResult FillterArticles(int CategoryId)
        {
            if (CategoryId == 0)
                return PartialView("_ArticalTable", Categories);

            var categories = Categories.Where(c => c.Id == CategoryId).ToList();
            return PartialView("_ArticalTable", categories);
        }
        [HttpPost]
        public ActionResult GetArticleComments(int ArticleId)
        {
            var Comments = Mgrs.ArticleManager.GetAll().Where(a => a.Id == ArticleId).FirstOrDefault().Comment.ToList();
            return PartialView("_Comments", Comments);
        }
        [HttpPost]
        public ActionResult AddComment(int ArticleId,string Description,string UserName)
        {
            Comment comment = new Comment() { Description = Description, ArticleId_FK = ArticleId, UserName = UserName };
            Mgrs.CommentManager.Add(comment);
            var Comments = Mgrs.ArticleManager.GetById(ArticleId).Comment.ToList() ;
             return PartialView("_Comments", Comments);
        }
    }
}