# space-video-game

I want to make a game about space! 

Probably will take inspiration from games like Noita, FTL, and Asteroid.

# Notes on how to make projects:

## Getting Started

Helpful links:
* https://docs.monogame.net/articles/getting_started/1_setting_up_your_development_environment_windows.html
* https://medium.com/learning-c-by-developing-games/getting-started-with-c-monogame-in-vs-code-2c26c7f198c2

1. Install .NET SDK 
    - Run `dotnet` to check installation
2. Run the following (mgcb editor): 

`dotnet tool install --global dotnet-mgcb-editor` 

We can use the pipeline tool with `dotnet mgcb-editor`

3. Run the following (MonoGame Project Templates):

`dotnet new --install MonoGame.Templates.CSharp`

4. To create a new project, run the following:

`dotnet new mgdesktopgl -o ProjectName`

5. Go to project root, then you can run with `dotnet run`

## Monogame fundamentals

Look at the shooting-game tutorial folder (TODO: add link?) or the following:

http://rbwhitaker.wikidot.com/monogame-tutorials

TODO: make this more detailed - use the comments I wrote from the shooting gallery video

## (Unit) Testing

Refer to the following video:
https://www.youtube.com/watch?v=HQmbAdjuB88&ab_channel=codingisforyou

1. Get C#, NuGet Package Manager from VScode Extensions
2. Use NuGet Package manager (CTRL+Shift+P > NuGet Package Manager) to install the following:
    - Microsoft.NET.Test.Sdk
    - xunit
    - xunit.runner.visualstudio
3. Make a file for your tests (.cs extension)
4. Add `using Xunit`
5. Make a test class (can put it in a folder), add a member function which will be the actual test, and prepend either [Fact] or [Theory] before the function
6. Run tests using `dotnet test`

TODO: learn more about Xunit testing 