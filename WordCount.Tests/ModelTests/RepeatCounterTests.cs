using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;
using System;
using System.Collections.Generic;
using WordCount.Models;

namespace WordCount.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void GetSearchedString_ReturnStringToBeSearched_String()
    {
			//Arrange
		 	RepeatCounter newRepeatCounter = new RepeatCounter("hello hello hello", "hello");
			//Act
			string newString = newRepeatCounter.GetSearchedString();
			//Assert
      Assert.AreEqual("hello hello hello", newString);
    }
		[TestMethod]
		public void GetKeyword_ReturnSearchKeyword_String()
		{
		 //Arrange
		 RepeatCounter newRepeatCounter = new RepeatCounter("hello hello hello", "hello");
		 //Act
		 string newString = newRepeatCounter.GetKeyword();
		 //Assert
			Assert.AreEqual("hello", newString);
		}
		[TestMethod]
    public void SetSearchedString_ReturNewString_String()
    {
			//Arrange
		 	RepeatCounter newRepeatCounter = new RepeatCounter("hello hello hello", "hello");
			//Act
			newRepeatCounter.SetSearchedString("goodbye");
			//Assert
      Assert.AreEqual("goodbye", newRepeatCounter.GetSearchedString());
    }
		[TestMethod]
    public void SetKeyword_ReturNewKeyword_String()
    {
			//Arrange
		 	RepeatCounter newRepeatCounter = new RepeatCounter("hello hello hello", "hello");
			//Act
			newRepeatCounter.SetKeyword("goodbye");
			//Assert
      Assert.AreEqual("goodbye", newRepeatCounter.GetKeyword());
		}
		[TestMethod]
		public void RemovePunctuation_ReturnLettersOnly_String()
		{
		 //Arrange
		 RepeatCounter newRepeatCounter = new RepeatCounter("Hello!@#$%^&*()_+.", "hello");
		 //Act
		 string newString = newRepeatCounter.RemovePunctuation(newRepeatCounter.GetSearchedString());
		 //Assert
			Assert.AreEqual("Hello", newString);
		}
		[TestMethod]
		public void GetSearchedStringList_ReturnCleanList_List()
		{
			//Arrange
 		 RepeatCounter newRepeatCounter = new RepeatCounter("Hello!@#$%^&*()_+. hello", "goodbye");
 		 //Act
 		 List<string> newList = newRepeatCounter.GetSearchedStringList();
		 List<string> secondList = new List<string> {"hello", "hello"};
		 Console.WriteLine("Generated list: " + newList[0] + "static list: " + secondList[0]);
 		 //Assert
 			CollectionAssert.AreEqual(secondList, newList);
		}

		// [TestMethod]
		// public void ToLowerCase_ReturnLowerCaseLetters_String()
		// {
		//  //Arrange
		//  RepeatCounter newRepeatCounter = new RepeatCounter("Hello!@#$%^&*()_+.", "hello");
		//  //Act
		//  string newString = newRepeatCounter.RemovePunctuation(newRepeatCounter.GetSearchedString());
		//  //Assert
		// 	Assert.AreEqual("Hello", newString);
		// }
  }
}
