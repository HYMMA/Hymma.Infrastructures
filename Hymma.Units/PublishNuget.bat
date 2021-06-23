set /p key=Enter Api key:
nuget push "%key%" -Source https://api.nuget.org/v3/index.json