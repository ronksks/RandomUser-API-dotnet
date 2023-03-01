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
To run the application, open a terminal or command prompt and navigate to the root of the project. Then, run the following command:
dotnet run
The application will start up and listen for requests on port 5000 by default. You can test the API by sending a GET request to the /users endpoint:

http://localhost:5000/users
## API Documentation
### GET /users
Returns a list of 10 random user objects.

Parameters
None.

Response
A JSON array of user objects, each with the following properties:

id (string) - The user's unique ID.
name (object) - The user's name, with the following properties:
title (string) - The user's title (e.g. "Mr", "Mrs", etc.).
first (string) - The user's first name.
last (string) - The user's last name.
email (string) - The user's email address.
phone (string) - The user's phone number.
picture (object) - The user's profile picture, with the following properties:
large (string) - The URL of the user's large profile picture.
medium (string) - The URL of the user's medium profile picture.
thumbnail (string) - The URL of the user's thumbnail profile picture.
