# Readme

This is a sample project to demonstrate how to create a Nuget package and include content files.
The files will not be included in the consuming projects, they will be copied to the output directory.
The files will also be copied when the consuming pacakge is a transitive dependency in other projects.

## Pack Nugget Package

dotnet pack MyNugetPackage/MyNugetPackage.csproj -c Release -o ./nupkg -p:PackageVersion=1.0.0


## Build and Publish

dotnet build -c Debug .\ConsumingApplication\ConsumingApplication.csproj

dotnet publish -c Release -o .\publish .\ConsumingApplication\ConsumingApplication.csproj

## Links

- https://learn.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files
- https://github.com/NuGet/Home/wiki/Allow-package--authors-to-define-build-assets-transitive-behavior
- https://learn.microsoft.com/en-us/nuget/reference/msbuild-targets#including-content-in-a-package