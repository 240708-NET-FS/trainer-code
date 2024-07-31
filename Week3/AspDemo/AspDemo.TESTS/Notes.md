## Run to install report generator tool (installs globaly, so only needed once)
dotnet tool install -g dotnet-reportgenerator-globaltool

## Run to generate test coverage
dotnet test --collect:"XPlat Code Coverage"

## Find guid inside test result folder and run to generate html report
reportgenerator -reports:".\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html 

## Add to above command to limit coverage report if desire
-classfilters:"+myprojectname.API.Service.*;"