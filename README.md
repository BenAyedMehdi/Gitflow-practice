# A practice exercice to get familiar with Gitflow

We will work as a team to create a simple calculator project using C# while applying Gitflow practice. The calculator project will simply perform addition, subtraction, multiplication and devision. In order to complete this project, we will assign tasks to each team member and synchronise the workflow.

## Setup
+ The C# project is already created
+ The latest changes are pushed to the "main" branch
+ "develop" branch is already created
+ I finished my tasks, now comes your part

## Task 
1. Mehdi: Create the C# project (Done)
2. Mehdi: Create "IEquation" interface (Done)
3. Njoura: Create "Addition" class and add implementation in Program.cs
4. Khabir: Create "Subtraction" class and add implementation in Program.cs
5. Khabir: Create "Multiplication" class and add implementation in Program.cs
6. Njoura: Create "Division" class and add implementation in Program.cs
7. Khabir: Write this last line of code: 
```javascript
Console.ReadLine();
```
## Rules 
+ You should never commit or push directly to develop or main branch
+ The tasks should be completed in the right order
+ Each class you create should implement IEquation interface
+ Njoura should work on task #3 on a branch called "njoura/addition"
+ Khabir should work on task #4 on a branch called "khabir/subtraction"
+ The last 3 task (#5, #6, #7) should be developed on a branch called "team/multiplication-division"
+ The final version should be released in main branch

## Steps:
1. Clone the repository
2. Checkout to develop
3. Njoura create a branch "njoura/addition"
4. Njoura push his changes and merge his branch to develop (task #3)
5. Kahbir pull the latest changes in develop
6. Khabir create a branch "khabir/subtraction"
7. Khabir push his changes and merge his branch to develop (task #4)
8. Khabir create a branch "team/multiplication-divion"
9. Khabir push his changes to "team/multiplication-divion" (task #5)
10. Njoura pull the latest changes in develop
11. Njoura checkout to "team/multiplication-divion" branch
12. Njoura pull the latest changes in "team/multiplication-divion"
13. Njoura push his changes to "team/multiplication-divion" (task #6)
14. Khabir pull the latest changes in "team/multiplication-divion"
15. Khabir push his changes to "team/multiplication-divion" and merge the branch to develop (task #7)
16. Njoura merge develop to main

## Resources: 
This repository contains everything you need: [Exemple to follow](https://github.com/BenAyedMehdi/Calculator-Exemple-To-Follow)

* The solution for each task is already available in the exemple to follow
* You can check the commits history to know what to do in each task
* Check the branches graph in the repository -> Insights -> Network
* I created a git cheat cheet in the readme file, you can use it to find the right git command to execute 

# Git cheat sheet
## Cloning an remote repository to your local machine
To copy an online repository to your local machine, use the following command:

```bash
git clone <url>
```
This will create a new directory with the same name as the online repository and download all the files and history from the remote repository to your local machine.

## Creating a new develop branch

To create a new develop branch from the master branch, use the following command:

```bash
git checkout -b develop
```
## Checking the status of your working directory

To check the status of your working directory, use the following command:

```bash
git status
```

## Adding changes to the staging area

To add changes to the staging area, use the following command:

```bash
git add .
```

## Committing changes to the local repository

To commit changes to the local repository, use the following command:

```bash
git commit -m "Your commit message"
```

## Pushing changes to the remote repository

To push changes to the remote repository, use the following command:

```bash
git push origin develop
```

## Merging feature branch into develop

To merge a feature branch into develop, use the following commands:

```bash
git checkout develop # switch to develop branch
git pull origin develop # update develop branch from remote
git merge feature # merge feature branch into develop
git push origin develop # push changes to remote
```
## Pulling changes from the remote repository

To get changes from the remote repository, use the following command:

```bash
git pull origin <branch-name>
```
This will download the latest changes from the remote origin repository and merge them into your local branch. You may need to resolve any merge conflicts that arise during the process.

Pulling changes from the remote repository is useful when you want to update your local branch with the latest changes made by other developers or yourself on another machine. You should always pull changes before pushing your own changes to avoid conflicts and keep your branches in sync.
## Listing branches

To list all the branches in your local repository, use the following command:

```bash
git branch
```
This will show you the names of all the branches and mark the current branch with an asterisk (*).