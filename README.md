# Random User API Integration
This C# and .NET implementation provides a simple API application that requests random user data from the RandomUser API.

## Installation
To run this application, you'll need to have the following installed:

.NET 5.0
Once you have .NET installed, you can clone this repository to your local machine:
git clone https://github.com/YOUR-USERNAME/YOUR-REPOSITORY

## Configuration
Before you can run the application, you'll need to provide your own RandomUser API key. You can obtain a free key by signing up on the RandomUser API website.

Once you have your API key, open the appsettings.json file in the root of the project and replace the value of the RandomUserApiSettings:ApiKey field with your key.

## Running the application
To run the application, open a terminal or command prompt and navigate to the root of the project. <br />
Then, run the following command:
dotnet run
The application will start up and listen for requests on port 5000 by default. <br />
You can test the API by sending a GET request to the /users endpoint:<br />

http://localhost:5000/users<br />

## API Documentation
This API allows you to request random user data from the external getRandomUser API. Below are the available endpoints:
### GET /users/random

This endpoint returns a random user data. The response includes the following fields:

name (object), 
title (string), 
first (string), 
last (string), 
email (string), 
phone (string), 
picture (object), 
large (string), 
medium (string), 
thumbnail (string) 

### GET /users/random/{count}
This endpoint returns the specified number of random user data. The response is an array of user objects, where each object includes the same fields as described in endpoint #1.

### GET /users/{id}

This endpoint returns user data for a specific user ID. The response includes the same fields as described in endpoint #1.

### POST /users

This endpoint allows you to create a new user. The request body should include the following fields:

name (object), 
title (string), 
first (string), 
last (string), 
email (string), 
phone (string), 
picture (object), 
large (string), 
medium (string), 
thumbnail (string) <br />
The response includes the newly created user object.

### PUT /users/{id}

This endpoint allows you to update an existing user. The request body should include the same fields as described in endpoint #4. The response includes the updated user object.

### DELETE /users/{id}

This endpoint allows you to delete a user. The response is a message indicating whether the deletion was successful or not.
