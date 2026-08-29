[![](https://img.shields.io/nuget/v/soenneker.quark.gen.lucide.abstractions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.lucide.abstractions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.lucide.abstractions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.lucide.abstractions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.gen.lucide.abstractions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.lucide.abstractions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.lucide.abstractions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.lucide.abstractions/actions/workflows/codeql.yml)

# Soenneker.Quark.Gen.Lucide.Abstractions

Provides SVG markup for Lucide icons by name. Implement and register when using the `Lucide` element with Soenneker.Quark.Gen.Lucide.

## Install

```bash
dotnet add package Soenneker.Quark.Gen.Lucide.Abstractions
```

## Quick start

```csharp
using Soenneker.Quark.Gen.Lucide.Abstractions;

ILucideIconSvgProvider lucideIconSvgProvider = /* resolve from DI */;
var result = lucideIconSvgProvider.GetSvg("value");
```

Returns the SVG markup for the given Lucide icon name (PascalCase), or null if not found.

## What you get

- `ILucideIconSvgProvider` — Provides SVG markup for Lucide icons by name. Implement and register when using the `Lucide` element with Soenneker.Quark.Gen.Lucide.
