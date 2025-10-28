@echo off
echo BUILD Cadmus NDP Packages
del .\Cadmus.Ndp.Parts\bin\Debug\*.nupkg
del .\Cadmus.Seed.Ndp.Parts\bin\Debug\*.nupkg

cd .\Cadmus.Ndp.Parts
dotnet pack -c Debug -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd..

cd .\Cadmus.Seed.Ndp.Parts
dotnet pack -c Debug -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd..

pause
