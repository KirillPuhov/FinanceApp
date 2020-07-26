using FinanceApp.BL.Model;
using System;
using System.Collections.Generic;

namespace FinanceApp.BL.Controller
{
    public class ArticleController : ControllerBase
    {
        public void Add(string name, string type, string description, double price)
        {
            Article article = new Article(name, type, description, price);
            Save(article);
        }

        public List<Article> LoadFromDB()
        {
            return GetAllArticles<Article>();
        }

        public void RemoveArticle(int Id)
        {
            Remove<Article>(Id);
        }
    }
}
