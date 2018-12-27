[![NuGet Status](https://img.shields.io/nuget/v/Altairis.Fakturoid.Client.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Altairis.Fakturoid.Client/)

# Fakturoid API C#/.NET client

This projects aims to create C#/.NET client for API of Czech online accounting service [Fakturoid](http://www.fakturoid.cz).

Please note that some more obscure functions are not (yet) supported - like API access to generators, reports etc. I'll implement them once I would need them, or you can do it in your fork (I accept pull request). The infrastructure is all here.

The library is developed in C#, Microsoft .NET version 4.6.1 and uses _[Microsoft ASP.NET Web API Client Libraries](http://www.asp.net/web-api)_ (NuGet: `Microsoft.AspNet.WebApi.Client`).

Since version 2.5, the library exposes fully asynchronnous Task-based API for use with `async` and `await`.

## How to use in your project

Install current version of library as a NuGet package `Altairis.Fakturoid.Client` from the [NuGet Gallery](http://www.nuget.org):

    install-package Altairis.Fakturoid.Client

## Upgrade from version 1.x


Current version supports [Fakturoid API v2](http://docs.fakturoid.apiary.io/). 

The only **breaking change** from v1 is that constructor of `FakturoidContext` class now requires the `email` argument as well and that its `AuthenticationName` arg and property was renamed to `AccountName` to avoid confusion.

## Documentation

* Look into the `Altairis.Fakturoid.Client.DemoApp` project for usage.
* All public members have XML documentation that will show up in IntelliSense.
* The `Documentation.chm` file build from the XML documentation is available for download. 

> This project is developed and maintained by [Michal A. Valášek](http://www.rider.cz), (of [ASPNET.CZ](http://www.aspnet.cz/) fame) and the [Altairis](http://www.altairis.cz) corporation. This project has no official relation to the Fakturoid service or its owner.

## Contributor Code of Conduct

This project adheres to No Code of Conduct. We are all adults. We accept anyone's contributions. Nothing else matters.

For more information please visit the [No Code of Conduct](https://github.com/domgetter/NCoC) homepage.
