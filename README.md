# VTimeline (API)

![logo_banner](https://imgur.com/vYrOcrm.png)

VTimeline is a content management system that allows you to create a vertical full screen timeline, where you can easily add, update or delete events. So let's say that you need a way to present a number of historical events or your life story for that matter, then this is the solution for you. You are able to add an image, title, description, start and end date to your event. The events will automatically be ordered ascending based on the start date.

## Prerequisites

### System

- [.NET Core](https://dotnet.microsoft.com/) - .NET Core is a free and open-source managed computer software framework for the Windows, Linux, and macOS operating systems.

- [MySQL](https://www.mysql.com/) - MySQL is an open source relational database management system.

- [Docker](https://www.docker.com/products/docker-desktop) - Docker is a computer program that performs operating-system-level virtualization, also known as "containerization".

### Repostories

- [Database](https://github.com/AjUthaya/vtimeline-database-mysql) (vtimeline-database-mysql)

## Configuration

- Coming soon

## Run

### Dev

1. Coming soon

### Staging

1. Coming soon

### Prod

1. Coming soon

## Test

### Dev

1. Coming soon

### Staging

1. Coming soon

### Prod

1. Coming soon

## Application

### Architecture

![application_architecture](https://imgur.com/t9ZFuZz.png)

### API Responce structure

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

### Remove version tag

1. Remove tag `git tag -d X.X.X`

2. Remove tag from remote `git push -d origin X.X.X`

## Built with

### [ASP.NET MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)

The ASP MVC is a web application framework developed by Microsoft, which implements the model–view–controller pattern. It is open-source software, apart from the ASP Web Forms component which is proprietary.

### [NuGet](https://www.nuget.org/)

NuGet is a free and open-source package manager designed for the Microsoft development platform. Since its introduction in 2010, NuGet has evolved into a larger ecosystem of tools and services. Starting with Visual Studio 2012, NuGet comes pre-installed by default.

### [Entity Framework](https://docs.microsoft.com/en-us/ef/)

Entity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is stored.
