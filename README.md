# Student Grade Manager

A C# console application that allows users to enter, store, and analyze student grades. This project was enhanced with application logging and Docker containerization to demonstrate software development and deployment practices.

## Features

* Store grades in a List
* Display all grades entered
* Calculate the average grade
* Log application events to a file
* Run the application in a Docker container
* Demonstrates loops, lists, methods, and file handling

## Technologies Used

* C#
* .NET 10
* Docker
* Git
* GitHub

## Application Logging

The application generates an `app.log` file containing:

* Application startup events
* Grades entered by the user
* Average grade calculations
* Application shutdown events

Example:

2026-06-16 19:35:00 - Application started

2026-06-16 19:35:05 - Grade entered: 90

2026-06-16 19:35:10 - Grade entered: 80

2026-06-16 19:35:15 - Average calculated: 85.00

2026-06-16 19:35:15 - Application finished

## Running Locally

### Prerequisites

* .NET SDK

### Run

```bash
dotnet run
```

## Running with Docker

### Build the Docker Image

```bash
docker build -t student-grade-manager .
```

### Run the Container

```bash
docker run -it student-grade-manager
```

## Screenshots

See the `screenshots` folder for:

* Docker image build
* Docker container execution
* Application log output

## Skills Demonstrated

* C# Development
* .NET Console Applications
* Data Structures (Lists)
* File Logging
* Docker Containerization
* Git Version Control
* GitHub Collaboration
