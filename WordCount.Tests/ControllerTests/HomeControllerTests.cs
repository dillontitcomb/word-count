using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCount.Controllers;
using WordCount.Models;


namespace WordCount.Tests
{
    [TestClass]
    public class HomeControllerTest
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
				[TestMethod]
				public void Results_HasCorrectModelType_RepeatCounter()
				{
						//Arrange
		        HomeController controller = new HomeController();
		        IActionResult actionResult = controller.Results();
		        ViewResult resultsView = controller.Results() as ViewResult;
            //Act
            var result = resultsView.ViewData.Model;
						Console.WriteLine(result + " and " + typeof(RepeatCounter));
            //Assert

            Assert.IsInstanceOfType(result, typeof(RepeatCounter));
				}

    }
}
