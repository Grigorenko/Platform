# Platform
Easy way for using db in ASP.NET Core

## Introduction
Platform is cross-platform framework for creating extendable web applications based on ASP.NET Core.

Platform consists of two general packages and five optional basic extensions.

### General Packages

Platform general packages are:

* Core;
* Sources.

#### Core

This package contains basic libraries for working with a database.

#### Sources

This package contains main web application. Also, there are libraries for the entities, repositories abstractions, and repositories.

### Basic Extensions

Platform basic extensions are:

* Core.Data;
* Core.Data.Dapper;
* Core.Extensions;
* Core.Infrastructure;
* Core.Infrastructure.Mvc;

#### Core.Data

Contains some interfaces for entities, repositories and Storage interface for single storage context.

#### ExtCore.Data.Dapper

Implementation interfaces from Core.Data.

#### Core.Extensions

Contains extensions for web application with MVC. This extension initializes MVC, makes it possible to use controllers, view components, views and static content.

#### Core.Infrastructure

Contains AssemblyProvider and ExtensionManager for getting instances and implementations.

#### Core.Infrastructure.Mvc

Contains actions for using MVC in main web application.

## Getting Started

For getting started use extendable web application is:

* download project from GitHub;
* remove sources folder with projects or extendible existing;

if you wanted to create new web application you should create recommended architecture (include projects):
* Data.Entities (Core.Data)
* Data.Abstractions (Core.Data and your Data.Entities)
* Data.Dapper (Core.Data.Dapper and your Data.Entities, Data.Abstractions)
* Web (Core.Data.Dapper, Core.Extensions, Core.Infrastructure.Mvc and all your projects) - empty web application
* In ConfigureServices (Startup.cs) add middleware AddCore and in Configure use middleware UseCore

### Sample

In this sample used Sqlite database and [Dapper](http://dapper-tutorial.net/)
