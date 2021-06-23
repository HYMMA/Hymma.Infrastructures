set /p nupkg=Enter nupkg filename without extension:

set /p key=Enter Api key:
nuget push "%nupkg%".nupkg "%key%" -Source https://api.nuget.org/v3/index.json