

<h1 align="center">
  <img align="center" width="120px" src="https://github.com/caioavidal/OpenCoreMMO/blob/develop/ocmsquare.png?raw=true" target="_blank"  />
  <br>
  OPENCOREMMO</h1>
<p align="center">
  <a href="https://ci.appveyor.com/project/caioavidal/opencoremmo">
  <img align="center" src="https://ci.appveyor.com/api/projects/status/973j1ut05o6r8ggg?svg=true" target="_blank"  />
  </a>
  <a href="https://codecov.io/gh/caioavidal/OpenCoreMMO">
  <img align="center" src="https://codecov.io/gh/caioavidal/OpenCoreMMO/branch/develop/graph/badge.svg" />
</a>
<a href="https://www.codefactor.io/repository/github/caioavidal/opencoremmo"><img  align="center"  src="https://www.codefactor.io/repository/github/caioavidal/opencoremmo/badge" alt="CodeFactor" /></a>
<a href="https://discord.gg/Kazq9z2">
  <img align="center" src="https://badgen.net/badge/icon/discord?icon=discord&label" />
</a>
<a href="https://github.com/caioavidal/opencoremmo/stargazers">
  <img align="center" src="https://img.shields.io/github/stars/caioavidal/opencoremmo?label=stargazers&logoColor=yellow&style=social" />
  </a>
  <a href="https://github.com/caioavidal/OpenCoreMMO/blob/develop/LICENSE">
  <img align="center" src="https://badgen.net/github/license/caioavidal/opencoremmo" />
  </a>
</p>

> Modern free and open-source MMORPG server emulator written in C#.
> <br>To connect to the server, you can use either [OTClient](https://github.com/edubart/otclient) or [OpenTibiaUnity](https://github.com/slavidodo/OpenTibia-Unity) for version 8.6.

## Demo

<p align="center">
  <img width="700" align="center" src="https://github.com/caioavidal/OpenCoreMMO/blob/develop/opencoremmo.gif?raw=true" alt="demo"/>
</p>

## Latest Builds

| Enviroment | Status |
|------------|--------|
|![linux](https://badgen.net/badge/icon/Ubuntu%20Linux%2018.04%20x64?icon=terminal&label&color=orange)|[![Build Status](https://caiovidal.visualstudio.com/OpenCoreMMO/_apis/build/status/caioavidal.OpenCoreMMO%20Ubuntu?branchName=develop)](https://caiovidal.visualstudio.com/OpenCoreMMO/_build/latest?definitionId=3&branchName=develop)|
|![win](https://badgen.net/badge/icon/Windows?icon=windows&label&color=blue)|[![Build status](https://ci.appveyor.com/api/projects/status/973j1ut05o6r8ggg?svg=true)](https://ci.appveyor.com/project/caioavidal/opencoremmo)|
|![mac](https://badgen.net/badge/icon/macOS%20Latest?icon=apple&label&color=purple&list=1)|[![Build Status](https://caiovidal.visualstudio.com/OpenCoreMMO/_apis/build/status/caioavidal.OpenCoreMMO%20MACOS?branchName=develop)](https://caiovidal.visualstudio.com/OpenCoreMMO/_build/latest?definitionId=2&branchName=develop)|
|![win](https://badgen.net/badge/icon/Windows,.NET%206?icon=windows&label&list=1)|[![Build Status](https://caiovidal.visualstudio.com/OpenCoreMMO/_apis/build/status/caioavidal.OpenCoreMMO?branchName=develop)](https://caiovidal.visualstudio.com/OpenCoreMMO/_build/latest?definitionId=1&branchName=develop)        |

## Usage

```sh
download and install .NET 6: https://dotnet.microsoft.com/download/dotnet/6.0
git clone https://github.com/caioavidal/OpenCoreMMO.git
cd src
dotnet run -p "NeoServer.Server.Standalone"
```
When connecting to the self-hosted server for development connect using the following:
1. IP Address: 127.0.0.1
2. Port: 7171
3. Account Name: 1
4. Password: 1

## What we have done so far

- Reading OTB and OTBM File structure: :heavy_check_mark:
- Loading OTBM Tile Area, Towns and Waypoints: :heavy_check_mark:
- Loading Spawn Areas: :heavy_check_mark:
- Loading OTBM House Tiles: :warning:
- Log In/Out Player on Game: :heavy_check_mark:
- All player movements: :heavy_check_mark:
- Multiplayer connection: :heavy_check_mark:
- Spawn and Respawn Monsters: :heavy_check_mark:
- PvM Combat: :heavy_check_mark:
- Depot: :heavy_check_mark:
- Chats: :heavy_check_mark:
- Guilds: :heavy_check_mark:
- War System: :warning:
- Public Channels: :heavy_check_mark:
  - Loot and Death Channels: :heavy_check_mark:
  - Vip List: :heavy_check_mark:
- PvP Combat: :warning:
- Party: :heavy_check_mark:
  - Basics: :heavy_check_mark:
  - Share Loot: :heavy_check_mark:
  - Shared Experience: :heavy_check_mark:
- NPC System: :heavy_check_mark:
- Lua Scripting: :heavy_check_mark:
- C# Extensions: :heavy_check_mark:
- ArchitectureByCode: :heavy_check_mark:

## Technologies

* C#
* .Net 6
* Database support: InMemory, MySQL, SQL Server and SQLite
* Console Debug Logging
* XUnit Testing
* C4sharp code based documentation

 [![My Skills](https://skillicons.dev/icons?i=dotnet,cs,docker,git,postgres,mysql,sqlite)](https://skillicons.dev)

## Links

* Documentation: https://caioavidal.gitbook.io/opencoremmo/
* Discord Invite: https://discord.gg/Kazq9z2
* TibiaKing Topic: https://tibiaking.com/forums/topic/101402-open-source-tibia-server-c-net-5/

## Architecture

![ContainerDiagram](src/NeoServer.Architecture/c4/container-diagram-for-opencoremmo-c4container.png)

## Author

👤 **Caio Vidal**

* Github: [@caioavidal](https://github.com/caioavidal)
* LinkedIn: [https:\/\/www.linkedin.com\/in\/caiovidal](https:\/\/www.linkedin.com\/in\/caiovidal)

## Contributors

Thank you to all the people who already contributed to OpenCoreMMO!

* 👤 **[Marcus Vinicius(Lowpoc)](https://github.com/Lowpoc)**
* 👤 **[Shelby115](https://github.com/Shelby115)**
* 👤 **[Mun1z](https://github.com/Mun1z)**
* 👤 **[alissonfabiano](https://github.com/alissonfabiano)**
* 👤 **[NINDO-PoS](https://github.com/NINDO-PoS)**
* 👤 **[VictorAmaral](https://github.com/VictorAmaral)**
* 👤 **[jahazielhigareda](https://github.com/jahazielhigareda)**
* 👤 **[emidiovictor](https://github.com/emidiovictor)**
* 👤 **[themaoci](https://github.com/themaoci)**

## Show your support

Give a ⭐️ if this project helped you!
