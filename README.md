[![](https://img.shields.io/nuget/v/soenneker.quark.gen.lucide.abstractions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.lucide.abstractions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.lucide.abstractions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.lucide.abstractions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.lucide.abstractions/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.lucide.abstractions/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.gen.lucide.abstractions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.lucide.abstractions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.lucide.abstractions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.lucide.abstractions/actions/workflows/codeql.yml)

# Soenneker.Quark.Gen.Lucide.Abstractions

The SVG-provider contract shared by Quark Lucide components and build-time generation.

## Install

```bash
dotnet add package Soenneker.Quark.Gen.Lucide.Abstractions
```

Most applications should install `Soenneker.Quark.Gen.Lucide`, which references this package and generates an implementation. Reference the abstractions package directly when a library needs the contract without taking a dependency on the generator, or when supplying a custom provider.

## Usage

```csharp
using Soenneker.Quark.Gen.Lucide.Abstractions;

public sealed class IconConsumer(ILucideIconSvgProvider provider)
{
    public string? GetCheckSvg() => provider.GetSvg("Check");
}
```

Icon names use the PascalCase `LucideIcon` member name. `GetSvg` returns `null` when the provider does not contain that icon.

## Custom providers

```csharp
public sealed class CustomLucideIconSvgProvider : ILucideIconSvgProvider
{
    public string? GetSvg(string iconName) => iconName switch
    {
        "Check" => "<svg><!-- trusted markup --></svg>",
        _ => null
    };
}

services.AddScoped<ILucideIconSvgProvider, CustomLucideIconSvgProvider>();
```

The returned string is SVG markup and may be rendered as raw markup by the consuming component. Custom providers should return only trusted or sanitized SVG content.
