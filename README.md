# Introduction 
   Centauri Report

## For Checking
* Add proper xml comments
* Add unit tests

## Git Flow Setup
      
1. Fork the official repo 
* Choose Fork instead of Clone
* Name your fork in this format:   "mlomio.centauri"
* Make sure to choose the project
* Include All branches
* Click Fork
    
2. Clone your forked repo to your local machine

    *Note*: You can use Source Tree or Visual Studio 2019 to clone your fork repository.

          git clone url

3. Add remote upstream to the official repo

            git remote add upstream url

## Development Flow 

    *Note*: You can use Source Tree or Visual Studio 2019. But below is the development flow.

1. Checkout develop branch

         git checkout develop

2. Pull latest copy of develop branch from upstream (official repo)

         git pull upstream develop

3. Create a new feature branch

      *Note*: Give a descriptive name to your feature branch based on the feature you are working on.

         git checkout -b "feature branch"

4. Make changes to your repository:  add or modify files

5. Stage changes

         git add file1 file2

6. Commit changes with proper comments

         git commit -m "[ADD] Create login "

         NOTE:  
            Let us use prefix for commit messages:
            [ADD] For new feature
            [MOD] Modification of features
            [FIX] Bug fixes
            [IMP] For improvements
            

7. Push the feature branch to your own repository

         git push origin "feature branch"


## Submitting Pull Requests

1. Go to your azure devops repository and submit a pull request of the feature branch  to  the official repository's develop branch

      origin "feature branch"  ->   upstream develop

2. Reviewer(s) will review the PR

3. Reviewer(s) approves, request for changes, or comments PR

4. feature-branch deleted

## Maintainer Merges changes to master


