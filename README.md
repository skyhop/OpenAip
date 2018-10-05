OpenAip
=======

This repository contains a library written in C# to read .aip files from the OpenAIP project.

Please note that currently only the parsing of airspace files is supported.

## Installation
In order to use this library; add it via [NuGet](https://www.nuget.org/packages/Boerman.OpenAip):

```
Install-Package Boerman.OpenAip
```

or 

```
dotnet add package Boerman.OpenAip
```

## Roadmap
There are several things on the to do list. For a full and updated list, check out the issues.

Amongst the issues are the following things:

- Add the ability to also parse airport and navigation files. (I think hotspots is a kind of useless feature, at least, in the Netherlands. If someone would like me to also support that one, please open an issue!)
- Add the ability to automagically download .aip files from OpenAIP.
- A feature to have schedulers automatically download up-to-date files.
