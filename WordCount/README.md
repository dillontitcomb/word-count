# _Dillon's Word Counter_

#### C# Exercise for Epicodus, 2.16.2018

#### By _**Dillon Titcomb**_

## Description

_This webpage allows users to input a string and a keyword. If the searched string contains the keyword, a value of the number of times that occurred will be displayed. The program will only add to the keyword tally if the entire keyword is present in  the searched string._

## Specifications

* _Program takes an input for the string to be searched:_
	* _Example input: "hello, hello, hello! how are you doing?"_
	* _Example output: none_

* _Program takes an input for keyword:_
	* _Example input: "hello"_
	* _Example output: none_

* _Program removes all punctuation from string:_
	* _Example input: "hello, hello, hello! HOW ARE YOU DOING?"_
	* _Example output: "hello hello hello HOW ARE YOU DOING"_

* _Program changes all letters to lowercase:_
	* _Example input: "hello hello hello HOW ARE YOU DOING"_
	* _Example output: "hello hello hello how are you doing"_

* _Program splits string to be searched into a list of words:_
	* _Example input: "hello hello hello how are you doing"_
	* _Example output: "hello", "hello", "hello", "how", "are", "you", "doing"_

* _Program tracks a value that increases for each word successfully searched:_
	* _Example input: "hello", "hello", "hello", "how", "are", "you", "doing"_
	* _Example output: 3_

* _Program displays to user the number of times searched word exists within string:_
	* _Example input: "hello, hello, hello! how are you doing?", "hello"_
	* _Example output: "3"_

* _Program counts a search as successful only if the entire searched word is present as standalone word:_
	* _Example input: "hello, hello, hello! how are you doing?", "ello"_
	* _Example output: "0"_

## Setup/Installation Requirements

* _Clone this repository_
* _On a Mac, run the following commands in terminal:_
* _dotnet restore_
* _dotnet build_
* _dotnet run_
* _Navigate to "localhost:5000" in browser_
* _Input a string to be searched and a keyword_

## Known Bugs

_No known bugs._

## Support and contact details

_Please contact me at dillontitcomb@gmail.com with inquiries._

## Technologies Used

* _CSHTML_
* _CSS_
* _Bootstrap_
* _C#_

## Link to page

https://github.com/dillontitcomb/word-count

### License

*The software is licensed under the MIT license.*

Copyright (c) 2018 **_Dillon Titcomb_**
