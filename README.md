# `compendium-adapter-stripe`

Stripe billing adapter for the [Compendium](https://github.com/sassy-solutions/compendium) event-sourcing framework: subscriptions, checkouts, customer portal, and HMAC-signed webhooks via the official [Stripe.net](https://github.com/stripe/stripe-dotnet) SDK.

Extracted from `sassy-solutions/compendium` per [ADR-0006](https://github.com/sassy-solutions/compendium/blob/main/docs/adr/0006-multi-repo-adapter-split.md) (multi-repo adapter split). Built from [`template-compendium-adapter-dotnet`](https://github.com/sassy-solutions/template-compendium-adapter-dotnet).

## Install

```bash
dotnet add package Compendium.Adapters.Stripe
```

```csharp
services.AddStripeBilling(builder.Configuration.GetSection("Stripe"));
```

See [`docs/README.md`](docs/README.md) for full configuration, webhook setup, and usage examples.

## Versioning

This package continues the version sequence of `Compendium.Adapters.Stripe` originally published from the framework monorepo (last framework-published version: `1.0.0-preview.8`). The first release from this repo is `v1.0.0-preview.9`. Versions are driven by git tags via [MinVer](https://github.com/adamralph/minver) — see [`docs/RELEASE.md`](docs/RELEASE.md).

## Repository conventions

| Aspect | Choice |
|---|---|
| Target | .NET 9, C# 13 |
| Test framework | xUnit 2.9.3 + FluentAssertions 6.12.1 + NSubstitute 5.1.0 |
| Coverage gate | ≥ 90 % line on unit-testable surface (currently **99.78 %** / 118 tests) |
| HTTP mocking | `RichardSzalay.MockHttp` 7.0.0 |
| Result pattern | `Result<T>` from `Compendium.Abstractions` |
| Test naming | `{SUT}Tests` / `{Method}_{Scenario}_{Expected}` + AAA explicit |
| Slash commands | `/tests`, `/coverage` (Claude Code) |

## Build & test locally

```bash
dotnet restore
dotnet build -c Release
dotnet test -c Release --collect:"XPlat Code Coverage"
```

## Releasing

Tag with a `v` prefix on `main` to publish to nuget.org + GitHub Packages:

```bash
git tag v1.0.0-preview.9
git push origin v1.0.0-preview.9
```

See [`docs/RELEASE.md`](docs/RELEASE.md) for the full release procedure, MinVer setup, and required secrets.

## License

[MIT](LICENSE) — Copyright © 2026 Sassy Solutions.
