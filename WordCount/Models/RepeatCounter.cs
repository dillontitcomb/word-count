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
			string newString = text.Replace("!","");
			string newString2 = newString.Replace(",","");
			string newString3 = newString2.Replace(".","");
			string newString4 = newString3.Replace("[","");
			string newString5 = newString4.Replace("]","");
			string newString6 = newString5.Replace("@","");
			string newString7 = newString6.Replace("#","");
			string newString8 = newString7.Replace("$","");
			string newString9 = newString8.Replace("%","");
			string newString10 = newString9.Replace("^","");
			string newString11 = newString10.Replace("&","");
			string newString12 = newString11.Replace("*","");
			string newString13 = newString12.Replace("(","");
			string newString14 = newString13.Replace(")","");
			string newString15 = newString14.Replace("-","");
			string newString16 = newString15.Replace("_","");
			string newString17 = newString16.Replace("+","");
			string newString18 = newString17.Replace("=","");
			return newString18;
		}
		// public string GetSearchedStringNoPunctuation()
		// {
		// 	return _searchedString.Replace;
		// }

		// public List<string> GetSearchedStringList()
		// {
		// 	List<string> newList = _searchedString.ToLowerCase().Split();
		// }
  }
}
