[![NuGet Status](https://img.shields.io/nuget/v/Altairis.Fakturoid.Client.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Altairis.Fakturoid.Client/)

# Fakturoid API C#/.NET client

> Toto je knihovna určená pro další vývojáře. 
> [Máte zájem o vývoj na zakázku?](DEVELOPMENT.md)
>
> This is library intended for other developers. 
> [Are you interested in custom development?](DEVELOPMENT.md)

This projects aims to create C#/.NET client for API of Czech online accounting service [Fakturoid](http://www.fakturoid.cz) and implements the API v3.

The library is written in C# and targets .NET Standard 2.0, so it can be used both in current .NET ("Core") and the legacy .NET Framework.

## How to use in your project

Install current version of library as a NuGet package `Altairis.Fakturoid.Client` from the [NuGet Gallery](http://www.nuget.org):

    install-package Altairis.Fakturoid.Client

## What is supported and what is not

The library currently supports the following features of the Fakturoid API:

* Client Credentials Flow
* The following entities:
  * BankAccounts
  * Events
  * Invoices
  * NumberFormats
  * Subjects
  * Todos

The following features are not supported yet:

* Authorization Code Flow.
* Proper handling of the rate limiting. If you hit a rate limit, the library will throw an exception, but currently does not provide any way get information on how many requests are remaining in current period and when the period will reset.
* Other entities than the mentioned above. There are models prepared for them, but the proxies are not implemented yet.

## Further development

Originally I developed this library for a project of mine and it supported the features that the Facturoid API provided at that time. Scope of the Fakturoid service (and its API) was vastly extended since then, and I don't have time to keep up with all the changes. I am not using this library anymore, so I am not actively developing it. Also, I don't know how many users this library actually has and if it makes sense to add new features. 

I will make reasonable efforts to fix bugs, but I don't plan to add new features. However I am open to pull requests and I am available for paid custom development of this library or any other .NET project.

## Upgrade from version 2.x

If you used version 2.x of this library, you will need to make some changes in your code. Most changes are related to the new API version 3, which has a new logic in many places and completely new authentication system. In addition, there are mainly the following breaking changes:

* The interface is now fully asynchronous, and the synchronous methods are not available anymore.
* The models, originally called `JsonSomething` , are now called just `Something` and were moved to `Altairis.Fakturoid.Client.Models` namespace.
* The model properties are now in `PascalCase` (as is common in C#) instead of `snake_case` (as in the original API).

## Documentation

* Look into the `Altairis.Fakturoid.Client.DemoApp` project for usage.
* All public members have XML documentation that will show up in IntelliSense.
* The [API Reference](API-Reference.md) is available.

## Contributor Code of Conduct

This project adheres to No Code of Conduct. We are all adults. We accept anyone's contributions. Nothing else matters.

For more information please visit the [No Code of Conduct](https://github.com/domgetter/NCoC) homepage.

> This project is developed and maintained by [Michal A. Valášek](http://www.rider.cz) and the [Altairis](http://www.altairis.cz) corporation. This project has no official relation to the Fakturoid service or its owner.