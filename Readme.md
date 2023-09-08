## ASP .NET Web API application
This repository contains a straightforward ASP .NET Web API application that adheres to a 3-tier architecture and follows SOLID principles for maintainability and scalability. The application also utilizes Microsoft SQL Server as the backend database.

## Overview

-   **ASP .NET Web API**: This application serves as the backend for your web or mobile application, providing RESTful endpoints for data retrieval and manipulation.
    
-   **3-Tier Architecture**: The application is structured into three distinct layers:
    
    1.  **Application Layer**: Responsible for handling incoming HTTP requests, routing them to the appropriate controllers, and serializing responses back to the client.
    2.  **Business Logic Layer**: Contains the core application logic, handling data processing, validation, and orchestration of operations.
    3.  **Data Access Layer**: Manages interactions with the Microsoft SQL Server database, including reading and writing data.
-   **SOLID Principles**: The codebase adheres to SOLID principles:
    
    -   **Single Responsibility Principle (SRP)**: Each class has a single responsibility.
    -   **Open/Closed Principle (OCP)**: The code is open for extension but closed for modification.
    -   **Liskov Substitution Principle (LSP)**: Subtypes can be substituted for their base types without altering the correctness of the program.
    -   **Interface Segregation Principle (ISP)**: No client should be forced to depend on methods it does not use.
    -   **Dependency Inversion Principle (DIP)**: High-level modules should not depend on low-level modules, but both should depend on abstractions.
-   **Microsoft SQL Server**: The application stores and retrieves data using Microsoft SQL Server, a robust and widely-used relational database management system.
    

## Getting Started

To get started with this project, follow these steps:

1.  Clone the repository to your local machine.
2.  Configure your Microsoft SQL Server connection in the appsettings.json file.
3.  Build and run the application.
4.  Access the API endpoints to interact with the application.

## Prerequisites

To work with this project, you need:

-   [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.
-   A running instance of Microsoft SQL Server or a connection to an existing SQL Server database.

## Usage

The API provides endpoints for various operations. Refer to the API documentation or explore the controllers for details on available endpoints and their functionality.

## Acknowledgments

-   Special thanks to the ASP .NET Core and SOLID principles communities for their valuable resources and inspiration.