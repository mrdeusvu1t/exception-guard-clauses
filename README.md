# Refactoring Exception Guard Clauses

A beginner level task for practicing refactoring and exception throwing.


## Get the Project

* [Open a project from your remote repository](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo) or [get your local copy](https://docs.microsoft.com/en-us/azure/devops/repos/git/clone#clone-from-another-git-provider) with Visual Studio.


## Complete the Task

Read articles in *See also* section first.

The [ThrowingExceptions.cs](ExceptionGuardClauses\ThrowingExceptions.cs) file contains methods that throws exceptions in case of passing incorrect pararameters. The problem is the code uses wrong exception classes, and you have to replace the exception classes with the classes that suits the best in each situation.


## Fix Compiler Issues

Additional style and code checks are enabled for the projects in this solution to help you maintaining consistency of the project source code and avoiding silly mistakes. [Review the Error List](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-the-error-list) in Visual Studio to see all compiler warnings and errors.

If a compiler error or warning message is not clear, [review errors details](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-errors-in-detail) or google the error or warning code to get more information about the issue.


## Save Your Work

* [Rebuild your solution](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio) in Visual Studio.
* Check out the [Error List window](https://docs.microsoft.com/en-us/visualstudio/ide/reference/error-list-window) for compiler errors and warnings. If you have any of those issues, **fix issues** and rebuild the solution again.
* [Run all unit tests with Test Explorer](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer) and make sure there are **no failed unit tests**. Fix your code to [make all your unit tests GREEN](https://stackoverflow.com/questions/276813/what-is-red-green-testing).
* Review all your changes **before** saving your work.
    * Open "Changes" view in [Team Explorer](https://docs.microsoft.com/en-us/visualstudio/ide/reference/team-explorer-reference).
    * Click with your right mouse button on a modified file.
    * Click on "Compare with Unmodified" menu item to open a comparison window.
* [Stage your changes](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#stage-your-changes) and [create a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#create-a-commit).
* Share your changes by [pushing them to remote repository](https://docs.microsoft.com/en-us/azure/devops/repos/git/pushing).


## See also

* [Guard Clauses Explained](https://medium.com/@maximegel/what-are-guard-clauses-and-how-to-use-them-350c8f1b6fd2)
* [Using Standard Exception Types](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/using-standard-exception-types)
* .NET API
  * [ArgumentException Class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)
  * [ArgumentNullException Class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)
  * [ArgumentOutOfRangeException Class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)
  * [IndexOutOfRangeException Class](https://docs.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception)
