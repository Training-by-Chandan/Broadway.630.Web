using Microsoft.VisualStudio.TestTools.UnitTesting;
using Broadway._630.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Broadway._630.Web.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexNullTest()
        {
            var controller = new HomeController();
            var res = controller.Index() as ViewResult;
            Assert.IsNotNull(res);
        }

        [TestMethod()]
        public void IndexNullId0Test()
        {
            var controller = new HomeController();
            var res = controller.Index(0);
            Assert.IsNull(res);
        }

        [TestMethod()]
        public void IndexInstanceOfTest()
        {
            var controller = new HomeController();
            var res = controller.Index();
            Assert.IsInstanceOfType(res, typeof(ViewResult));
        }
    }
}