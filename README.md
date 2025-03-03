# Real Estate API

## Overview
This is a simple RESTful API for managing real estate listings, built using .NET 8. The API allows users to create, retrieve, update, and delete property listings. The application uses an in-memory database for simplicity and is containerized using Docker.

## Features
- Create a real estate listing
- Retrieve all listings
- Retrieve a single listing by ID
- Update a listing
- Delete a listing

## Prerequisites
Ensure you have the following installed on your system:
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started)

## Getting Started

### Clone the Repository
```sh
git clone <your-repo-url>
cd RealEstateAPI
```

### Run the Application
```sh
dotnet run
```
The API will be available at `https://localhost:5001/swagger` for testing.

### API Endpoints

| Method | Endpoint           | Description                |
|--------|-------------------|----------------------------|
| POST   | `/api/listings`   | Create a new listing      |
| GET    | `/api/listings`   | Retrieve all listings     |
| GET    | `/api/listings/{id}` | Retrieve a listing by ID |
| PUT    | `/api/listings/{id}` | Update a listing        |
| DELETE | `/api/listings/{id}` | Delete a listing        |

## Using Docker

### Build the Docker Image
```sh
docker build -t real-estate-api .
```

### Run the Docker Container
```sh
docker run -p 5000:5000 real-estate-api
```
The API will be available at `http://localhost:5000/swagger`.


