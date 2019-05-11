## name-sorter --Solution 



## Application-Properties-
 -name-sorter is a Console Application designed using C# language targeted framework .NET  Core 2.2.

## Projects-
 - name-sorter includes three projects:
1. name-sorter : 
 - Main start up project to execute. It accepts a name of textfile as a Command Line      Argument which has unsorted list of person names to be sort.
 - It is designed using SOLID principles and open to expand with features such as      "Dependecny Injection".
 - Given a set of names, order that set first by last name, then by any given names the        person may have. 
 - A name must have at least 1 given name and may have up to 3 given names
 - Empty names or names with more than 3 given names will be ignored by sorting parser

2. NameSorter.Test:
 - Main Test project for different Unit Tests. Roy Osherove's Naming Convention is used for  - UnitTest Methods Which include following format:
   [UnitOfWork_StateUnderTest_ExpectedBehavior]

3. NameSorter.Library:
 - Class Library project which contains comman funcationalities to be used into different      projects. Can be expanded in future 


## Requirements

- 
 - Load the text file name unsorted-names-list.txt into name-sorter directory 
 - Load the text file name unsorted-names-list.txt into \name-sorter\bin\Debug   \netcoreapp2.2 directory 
 - If executing using cli pass name of file - "unsorted-names-list.txt" as  a command line    argument with executable
 - If executing using Visual Studio GUI - set Application Argument for name-sorter project    Debug with file name: unsorted-names-list.txt



## Build - 



 - Built pipeline using AppVeyor that execute build and test steps
 - Find build on: https://ci.appveyor.com/project/Shilpa-V/name-sorter
