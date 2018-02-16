using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCount.Models
{
  public class RepeatCounter
  {
		private string _searchedString;
		private string _keyword;
		private int _wordTotal = 0;
		private List<string> _wordsList;

		public RepeatCounter (string searchedString, string keyword)
		{
			_searchedString = searchedString;
			_keyword = keyword;
		}
//Getters
		public string GetSearchedString()
		{
			return _searchedString;
		}
		public string GetKeyword()
		{
			return _keyword;
		}
		public int GetWordTotal()
		{
			return _wordTotal;
		}
		public List<string> GetWordsList()
		{
			return _wordsList;
		}
//Setters
		public void SetSearchedString(string newString)
		{
			_searchedString = newString;
		}
		public void SetKeyword(string newString)
		{
			_keyword = newString;
		}
		public void SetWordTotal(int newInt)
		{
			_wordTotal = newInt;
		}
//Manipulation Methods
		public string RemovePunctuation(string text)
		{
			string newString = text.Replace("!","").Replace(",","").Replace(".","").Replace("[","").Replace("]","").Replace("@","").Replace("#","").Replace("$","").Replace("%","").Replace("^","").Replace("&","").Replace("*","").Replace("(","").Replace(")","").Replace("-","").Replace("_","").Replace("+","").Replace("=","");
			return newString;
		}
		public void CreateSearchedStringList()
		{
			string newString = RemovePunctuation(_searchedString);
			string[] newArray = newString.ToLower().Split();
			List<string> newList = new List<string>(newArray);
			_wordsList = newList;
		}
		public int CalculateWordTotal()
		{
			foreach (var word in _wordsList)
			{
				if (word == _keyword)
				{
					_wordTotal += 1;
				}
			}
			return _wordTotal;
		}
  }
}
