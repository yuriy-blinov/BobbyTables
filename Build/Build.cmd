Nuget.exe restore ../BobbyTables.sln
MsBuild.exe ../BobbyTables.sln /t:Build /p:Configuration=Release
Nuget.exe pack ../Package.nuspec