# VTimeline (API)

![logo_banner](https://imgur.com/vYrOcrm.png)

Description, replace this text it is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.

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

## Application Architecture

![application_architecture](https://imgur.com/t9ZFuZz.png)

## API

### Responce structure

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

1. Update the CHANGELOG file with a new section and the "Unreleased Changes" link with the new tag version

2. Create a new tag `git tag X.X.X`

3. Push the new tag to remote `git push origin --tags`

## Built with

- Coming soon
