# VTimeline (API)

![logo_banner](https://imgur.com/vYrOcrm.png)

VTimeline is a content management system that allows you to create a vertical full screen timeline, where you can easily add, update or delete events. So let's say that you need a way to present a number of historical events or your life story for that matter, then this is the solution for you. You are able to add an image, title, description, start and end date to your event. The events will automatically be ordered ascending based on the start date.

## Prerequisites

### System

Software that the system requires to be able to run this repository.

- [.NET Core](https://dotnet.microsoft.com/) - .NET Core is a free and open-source managed computer software framework for the Windows, Linux, and macOS operating systems.

- [Docker](https://www.docker.com/products/docker-desktop) - Docker is a computer program that performs operating-system-level virtualization, also known as "containerization".

### Repositories

List of other repositories that you need to have up and running, to be able to run this repository without getting any errors.

- [Database](https://github.com/AjUthaya/vtimeline-database-mysql) (vtimeline-database-mysql)

### Configuration

A list of the configuration files that you have to create, for every configuration file listed below there should a file with the suffix "\_example" before the extention. So all you have to do is copy that file and replace the values.

- config/application.json

## Run

### Development

1. Coming soon

### Production

1. Coming soon

## Test

1. Coming soon

## Application

### Linter

Coming soon

### Architecture

![application_architecture](https://imgur.com/t9ZFuZz.png)

### Responce object

```JS
{
  "_meta": {
    "page": "",
    "per_page": "",
    "total": "",
    "total_pages": ""
  },
  "title": "",
  "message": "",
  "results": [],
  "error": false,
  "error_object": {
    "title": "",
    "message": "",
    "errors": []
  },
  "_links": {}
}
```

## Versioning

We use git for versioning. For the versions available, see the [tags on this repository](https://github.com/AjUthaya/vtimeline-api-dotnet/tags).

### Add a new version tag

1. Update the CHANGELOG file with a new section and the "Unreleased Changes" link with the new tag version

2. Create a new tag `git tag X.X.X`

3. Push the new tag to remote `git push origin --tags`

### Add a version tag for an older commit

1. Type in `git log` in the root of the repo, to list all the commits with ID's

   - Press <kbd>Q</kbd> to get out of the list view

2. Create a tag for an older commit `git tag -a X.X.X COMMIT_ID`

3. Push the tag to remote `git push origin --tags`

### Remove a version tag

1. Remove tag `git tag -d X.X.X`

2. Remove tag from remote `git push -d origin X.X.X`

## Technologies

### [ASP.NET MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)

The ASP.NET MVC is a web application framework developed by Microsoft, which implements the model–view–controller pattern. It is open-source software, apart from the ASP.NET Web Forms component which is proprietary.

### [NuGet](https://www.nuget.org/)

NuGet is the package manager for .NET. The NuGet client tools provide the ability to produce and consume packages. The NuGet Gallery is the central package repository used by all package authors and consumers.

### [Entity Framework](https://docs.microsoft.com/en-us/ef/)

Entity Framework is an object-relational mapper (O/RM) that enables .NET developers to work with a database using .NET objects. It eliminates the need for most of the data-access code that developers usually need to write.

### [Cypress](https://www.cypress.io/)

Cypress is a next generation front end testing tool built for the modern web. We address the key pain points developers and QA engineers face when testing modern applications.
