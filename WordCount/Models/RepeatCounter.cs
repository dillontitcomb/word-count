using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCount.Models
{
  public class RepeatCounter
  {
		private string _searchedString;
		private string _keyword;
		private int _wordCount = 0;

		public RepeatCounter (string searchedString, string keyword)
		{
			_searchedString = searchedString;
			_keyword = keyword;
		}

		public string GetSearchedString()
		{
			return _searchedString;
		}
		public string GetKeyword()
		{
			return _keyword;
		}
		public void SetSearchedString(string newString)
		{
			_searchedString = newString;
		}
		public void SetKeyword(string newString)
		{
			_keyword = newString;
		}
		public string RemovePunctuation(string text)
		{
			string newString = text.Replace("!","").Replace(",","").Replace(".","").Replace("[","").Replace("]","").Replace("@","").Replace("#","").Replace("$","").Replace("%","").Replace("^","").Replace("&","").Replace("*","").Replace("(","").Replace(")","").Replace("-","").Replace("_","").Replace("+","").Replace("=","");
			return newString;
		}
		public List<string> GetSearchedStringList()
		{
			string newString = RemovePunctuation(_searchedString);
			string[] newArray = newString.ToLower().Split();
			List<string> newList = new List<string>(newArray);
			return newList;
		}
  }
}
