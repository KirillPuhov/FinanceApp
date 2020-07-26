using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanceApp.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.BL.Controller.Tests
{
    [TestClass()]
    public class ArticleControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            var name = Guid.NewGuid().ToString();
            var type = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();
            var rnd = new Random();
            var price = rnd.Next(50, 500);
            var articleController = new ArticleController();

            //Act
            articleController.Add(name, type, description, price);

            //Assert
            Assert.AreEqual(name, articleController.LoadFromDB().First().Name);
        }
    }
}