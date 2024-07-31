# Onion Architecture Project

This repository contains the code for Onion Architecture with ASP.NET CORE and topics that I have worked on, based on a comprehensive YouTube playlist and additional resources by [Cem Keskin](https://www.youtube.com/@cemkeskinn) and [@cemkeskin12](https://github.com/cemkeskin12).

## Table of Contents

- [About the Project](#about-the-project)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Topics Covered](#topics-covered)
- [Project Structure](#project-structure)
- [Acknowledgments](#acknowledgments)

## About the Project

This project is built by following the YouTube playlist "[.Net Core Web Api Project - Onion Architecture & CQRS](https://youtube.com/playlist?list=PLrSCwxkucNmw_sjxZZHaWj6ySakPgSCbv&feature=shared)". The playlist provides in-depth tutorials on Onion Architecture. The code in this repository reflects the examples and projects demonstrated in the videos.

## Getting Started

### Prerequisites

Before you begin, ensure you have met the following requirements:
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (if your project uses a database)

### Installation

1. Clone the repository
   ```sh
   git clone https://github.com/Sunnrise/Onion-Architecture-Project.git
## Topics Covered

This repository covers various topics in Entity Framework Core Each topic is handled in a separate commit or project folder:

- **All Project**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project)
- **Entity**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Entity)
- **Database**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Database)
- **Generic Repository**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Generic_Repository)
- **Unit of Work**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Unit_Of_Work)
- **CQRS**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/CQRS)
- **Auto Mapper**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/AutoMapper)
- **CRUD CQRS**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/CRUD_CQRS)
- **Global Exceptions**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/GlobalExceptions)
- **Fluent Validation**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Fluent_Validation)
- **Base Rules**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Base_Rules)
- **Auth**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Auth)
- **JWT Register**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Jwt_Register)
- **JWT Login**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Jwt_Login)
- **JWT Logout**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Jwt_Logout)
- **Redis**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Redis)



## Project Structure

A brief overview of the project structure with links to each directory or file:

- **All Project**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project)
  - The main branch encompassing all aspects of the Onion Architecture Project.

- **Entity**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Entity)
  - Contains entity definitions and configurations used throughout the project.

- **Database**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Database)
  - Includes database context and migration files for managing data persistence.

- **Generic Repository**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Generic_Repository)
  - Implements a generic repository pattern for accessing data in a flexible manner.

- **Unit of Work**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Unit_Of_Work)
  - Provides a Unit of Work pattern to manage transactions and maintain data integrity.

- **CQRS**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/CQRS)
  - Implements Command Query Responsibility Segregation (CQRS) to separate read and write operations.

- **Auto Mapper**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/AutoMapper)
  - Integrates AutoMapper for object-to-object mapping, simplifying data transfer between layers.

- **CRUD CQRS**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/CRUD_CQRS)
  - Demonstrates CRUD operations using the CQRS pattern.

- **Global Exceptions**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/GlobalExceptions)
  - Implements global exception handling to manage and log errors uniformly.

- **Fluent Validation**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Fluent_Validation)
  - Utilizes FluentValidation library for model validation in a fluent and readable manner.

- **Base Rules**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Base_Rules)
  - Contains base rules and validation logic shared across the project.

- **Auth**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Auth)
  - Manages authentication mechanisms and user identity management.

- **JWT Register**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Jwt_Register)
  - Implements user registration using JWT (JSON Web Tokens).

- **JWT Login**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Jwt_Login)
  - Provides login functionality with JWT for secure authentication.

- **JWT Logout**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Jwt_Logout)
  - Handles user logout and token invalidation using JWT.

- **Redis**: [View Branch](https://github.com/Sunnrise/Onion-Architecture-Project/tree/Redis)
  - Integrates Redis for caching and improving application performance.


## Acknowledgments

- [Asp.Net Core Web API Documentation](https://dotnet.microsoft.com/en-us/apps/aspnet/apis)
- YouTube Playlist: Onion Architecture & CQRS  Tutorial by [@cemkeskin12](https://github.com/cemkeskin12)


## Resources

This project is based on tutorials and examples from the following resources:

- **YouTube Playlist**: [Asp.Net Core Web Api Project - Onion Architecture & CQRS](https://youtube.com/playlist?list=PLrSCwxkucNmw_sjxZZHaWj6ySakPgSCbv&feature=shared)
- **YouTube Channel**: [Cem Keskin](https://www.youtube.com/@cemkeskinn)
- **GitHub Account**: [@cemkeskin12](https://github.com/cemkeskin12)




The playlist provides in-depth tutorials on Onion Architecture, covering various topics and practical examples. Check out the YouTube channel for more tutorials and the GitHub account for additional resources and projects.

