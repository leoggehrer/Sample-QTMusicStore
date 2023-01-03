# DotNet Commands

## Create migration (database)

dotnet ef migrations add InitDb --startup-project QTMusicStore.ConApp --project QTMusicStore.AppLogic
dotnet ef migrations add InitDb --startup-project QTMusicStore.Logic.UnitTest --project QTMusicStore.AppLogic

## Update database

dotnet ef database update --startup-project QTMusicStore.ConApp --project QTMusicStore.AppLogic
