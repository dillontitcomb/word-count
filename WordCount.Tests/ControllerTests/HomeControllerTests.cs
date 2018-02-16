using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCount.Controllers;
using WordCount.Models;


namespace WordCount.Tests
{
    [TestClass]
    public class HomeControllerTests : Controller
    {
				[TestMethod]
				public void Index_ReturnsCorrectView_True()
				{
					//Arrange
					HomeController controller = new HomeController();
					//Act
					IActionResult indexView = controller.Index();
					ViewResult result = indexView as ViewResult;
					//Assert
					Assert.IsInstanceOfType(result, typeof(ViewResult));
				}
    }
}
