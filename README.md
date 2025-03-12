# Backend API for Formula1 project 🏎️
This is the backend part of the Formula1 project, built using C# and .NET. It provides RESTful API endpoints for managing Formula 1 data, including drivers, teams and races. The backend interacts with a database using Entity Framework Core and supports varios API actions for managing and retrieving data. 
  Frontend part: https://github.com/annabelleraaberg/ReactApplication.git 

## Setup
Setup for running backend and frontend at the same time

1. Install the required dependencies:
   ```bash
   npm install

2. If running backend at the same time:
   ```bash
   dotnet run

   dotnet watch

3. Run frontend app:
   ```bash
   npm run dev
**Note**: press O to open in browser.

## Features
1. ### Driver Management: 
* **Get All Drivers**: Retrieves a list of all Formula 1 drivers stored in the database.
* **Get Driver by ID**: Retrieves detailed information for a specific driver based on their unique ID.
* **Get Driver by Name**: Allows for searching and retrieving a driver based on their name.
* **Add New Driver**: Endpoint to create a new driver, including their name, age, nationality and image.
* **Edit Driver**: Modify existing driver details.
* **Delete Driver**: Remove a driver from the database based on their ID.

2. ### Image Upload
* **Upload Image**: Allows uploading images associated with drivers (image of driver). 

3. ### Database Integration
* **Entity Framework Core**: Uses EF Core for database context and migrations, enabling data interaction for CRUD operations.

4. ### API Structure
* All API endpoints follow RESTful conventions, including HTTP status codes for responses.
* The API uses Controller-based routing to manage request to the backend.

## API Endpoints
* GET /api/drivers
* GET /api/drivers/{id}
* GET /api/drivers/GetDriverByName/{name}
* POST /api/drivers
* PUT /api/drivers
* DELETE /api/drivers/{id}

## Teach Stack
* **C#** & **.NET**: Backend framework
* **Entity Framework Core**: ORM for database interaction
* **SQL Database**: Relational database to store Formula 1 data
* **ASP.NET Core**: Framework for building APIs
