## This is how we setup the test so far.
- dotnet new xunit --name {myprojectname}.TESTS -o ./{myprojectname}.TESTS
- dotnet add package Moq

## Run to install report generator tool (installs globaly, so only needed once)
- dotnet tool install -g dotnet-reportgenerator-globaltool

## Run to generate test coverage
- dotnet test --collect:"XPlat Code Coverage"

## Find guid inside test result folder and run to generate html report
- reportgenerator -reports:".\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html 

## Add to above command to limit coverage report if desire
- -classfilters:"+myprojectname.Services.*;"
