@echo off
echo PRESS ANY KEY TO INSTALL TO LOCAL NUGET FEED
echo Remember to generate the up-to-date package.
c:\exe\nuget add .\Cadmus.Ndp.Parts\bin\Debug\Cadmus.Ndp.Parts.0.0.1.nupkg -source C:\Projects\_NuGet
c:\exe\nuget add .\Cadmus.Seed.Ndp.Parts\bin\Debug\Cadmus.Seed.Ndp.Parts.0.0.1.nupkg -source C:\Projects\_NuGet
pause
