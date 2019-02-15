# _Word Counter_

#### _02/15/2019_
## Author
 _**Name:  Mark Strickland**_

 _**Email: markstrickland562@hotmail.com**_


## Description
**_This program gathers a word and a sentence from a user and counts how many times the_**
**_full word appears in the sentence. Only full words count, not when the word appears as_**
**_part of another word._**

## Specifications
|   Behavior                          | Input Example | Output Example | Explanation |
| ------------------------------------|:-------------:| :-------------:| :----------:|
| An instance of a Word object can be created | "test" | The type of word instance is correct | Simple verification that the Word constructor works |
| The value of the word can be obtained successfully | "test" | The instance of Word has the value of "test" | Simple verification of the Word Getter method |
| An instance of a Word can be updated | "newtest" | The updated instance of a Word is "newtest" | Simple verification of the Word Setter method |
| An entered word must have a value | Blank, ie "" | "No word was entered" | Verification that a word was entered |
| Only one word can be entered | "two words" | "More than one word was entered" | Verification that there are no spaces in the entered string |
| An entered word will consist of English alphabetic characters only | a | "Your word is a valid word." | The letter "a" can be a word and it also exists often in English sentences |
| The word will not contain any non-English alphabetic characters | 1 | "Your word is invalid." | The number "1" is often substituted for "l" or "i" |
| An instance of a Sentence object can be created | "I am a student" | The type of sentence instance is correct | Simple verification that the Sentence constructor works |
| The value of the sentence can be obtained successfully | "I am a student" | The instance of Sentence has the value of "I am a student" | Simple verification of the Sentence Getter method |
| An instance of a Sentence can be updated | "I am a good student" | The updated instance of a Sentence is "I am a good student" | Simple verification of the Sentence Setter method |
| An entered sentence must have a value | Blank, ie "" | "No sentence was entered" | Verification that a sentence was entered |  
| An entered sentence will consist of English alphabetic characters only | "I am a student" | "Your sentence is a valid sentence." | N/A |
| The sentence will not contain any non-English alphabetic characters | "I @m a student" | "Your sentence is invalid." | N/A |
| A count will be taken of the number of times that the word exists in the sentence. A correct count will only include instance of the standalone word. | word="a" sentence="I am a student" | 1 | The word "a" exists once in "I am a student" |
| An incorrect count will exclude existences of the word as part of another word | word="a" sentence="I am a student" | 2 | If the count is 2, the existence of "a" in another word has been counted in error |


## Instructions
mcs WordCounert.cs Models/Counter.cs; mono WordCounter.exe

## Technologies Used
* _Mono_
* _C#_
* _ATOM_
* _Git_


## License

**

Copyright (c) 2019 **_Mark Strickland_**
