using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace DevCard_MVC.ViewComponents
{
    public class LastestArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"Top 3 JavaScript Frameworks","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient...\r\n\r\n","blog-post-thumb-card-1.jpg"),
                new Article(2,"About Remote Working","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient...\r\n\r\n","blog-post-thumb-card-2.jpg"),
                new Article(3,"A Guide to Becoming a Full-Stack Developer","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient...\r\n\r\n","blog-post-thumb-card-3.jpg"),
            };
            return View("_lastestArticles",articles);
        }
    }
}
