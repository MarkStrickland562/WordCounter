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
| The user will enter a word | a | "You entered: a" | A single-letter word is the simplest example of a word |
| The word will consist of English alphabetic characters only | a | "Your word is a valid word." | The letter "a" can be a word and it also exists often in English sentences |
| The word will not contain any non-English alphabetic characters | 1 | "Your word is invalid." | The number "1" is often substituted for "l" or "i" |
| The user will enter a sentence | I am a student | "You entered: I am a student." | This simple sentence contains "a" twice, once as a word and once as part of a word |
| The sentence will consist of English alphabetic characters only | I am a student | "Your sentence is a valid sentence." | N/A |
| The sentence will not contain any non-English alphabetic characters | I @m a student | "Your sentence is invalid." | N/A |
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
