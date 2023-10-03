## Installation Instructions

```SH
dotnet new nunit
```

```SH
dotnet add package Selenium.WebDriver
```

### Running Tests

```SH
dotnet run
```

OR

```SH
dotnet run ./someDir/someTestFile.cs
```

## How To Run Tests Article
<br>

[nunit-3-testing-net](https://alteridem.net/2016/06/18/nunit-3-testing-net-core-rc2/)


## Configuration File Sample Set
<br>

[Runsettings](https://github.com/nunit/nunit3-vs-adapter/blob/master/.runsettings)


```SH
dotnet test ./BrowserState.cs
```

```SH
dotnet clean
```

```SH
dotnet restore
```