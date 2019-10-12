[![Build status](https://ci.appveyor.com/api/projects/status/12xcihj4ak5vuhou/branch/master?svg=true)](https://ci.appveyor.com/project/ThiagoBarradas/type-extensions/branch/master)

# TypeUtility

Demo project to create an opensource nuget package with multi targeting.

## Getting Starter

Works with `net standard 1.0` and `net framework 4.0`;

```c#

class Program
{
    static void Main(string[] args)
    {
        var type1 = typeof(IEnumerable);
        var type2 = typeof(Array);

        var result = type1.IsAssignableFrom(type2);

        Console.WriteLine(result); // output "True"
    }
}
```

## Install via NuGet

```
PM> Install-Package TypeUtility
```

## How can I contribute?
Please, refer to [CONTRIBUTING](.github/CONTRIBUTING.md)

## Found something strange or need a new feature?
Open a new Issue following our issue template [ISSUE_TEMPLATE](.github/ISSUE_TEMPLATE.md)

## Changelog
See in [nuget version history](https://www.nuget.org/packages/Nancy.Scaffolding)

## Did you like it? Please, make a donate :)

if you liked this project, please make a contribution and help to keep this and other initiatives, send me some Satochis.

BTC Wallet: `1G535x1rYdMo9CNdTGK3eG6XJddBHdaqfX`

![1G535x1rYdMo9CNdTGK3eG6XJddBHdaqfX](https://i.imgur.com/mN7ueoE.png)
