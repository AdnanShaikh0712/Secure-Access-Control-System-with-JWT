Secure Role-Based Access Control System with JWT v1
This project implements a Secure Role-Based Access Control (RBAC) System using JSON Web Tokens (JWT) for managing user authentication and authorization. The system is built with a RESTful API and utilizes OAS 3.0 for documentation and integration. The main purpose of this system is to manage users, roles, and access control to various resources.

API Documentation
You can access the Swagger UI for the API at the following URL:

Swagger UI

Endpoints
1. Authentication
POST /api/Auth/login
This endpoint is used for logging in a user.

Request Body:

json
Copy code
{
  "username": "string",
  "password": "string"
}
Response:

Code 200: Successful login, returns a JWT token.
Media Type: text/plain
Example Response:
json
Copy code
"your-jwt-token-here"
POST /api/Auth/assignRole
This endpoint assigns roles to a user.

Request Body:

json
Copy code
{
  "userId": 0,
  "roleIds": [0]
}
Response:

Code 200: Successful role assignment.
Media Type: text/plain
Example Response:
json
Copy code
true
POST /api/Auth/addUser
This endpoint creates a new user.

Request Body:

json
Copy code
{
  "id": 0,
  "name": "string",
  "username": "string",
  "password": "string"
}
Response:

Code 200: User successfully added.
Media Type: text/plain
Example Response:
json
Copy code
{
  "id": 0,
  "name": "string",
  "username": "string",
  "password": "string"
}
POST /api/Auth/addRole
This endpoint creates a new role.

Request Body:

json
Copy code
{
  "id": 0,
  "name": "string",
  "description": "string"
}
Response:

Code 200: Role successfully added.
Media Type: text/plain
Example Response:
json
Copy code
{
  "id": 0,
  "name": "string",
  "description": "string"
}
2. Employee
GET /api/Employee
This endpoint retrieves a list of all employees.

Response:
Code 200: Returns a list of employees.
Media Type: text/plain
Example Response:
json
Copy code
[
  {
    "id": 0,
    "name": "string",
    "company": "string",
    "position": "string"
  }
]
POST /api/Employee
This endpoint adds a new employee.

Request Body:

json
Copy code
{
  "id": 0,
  "name": "string",
  "company": "string",
  "position": "string"
}
Response:

Code 200: Employee successfully added.
Media Type: text/plain
Example Response:
json
Copy code
{
  "id": 0,
  "name": "string",
  "company": "string",
  "position": "string"
}
3. WeatherForecast
GET /WeatherForecast
This endpoint retrieves weather forecast data.

Response:
Code 200: Returns a weather forecast.
Media Type: text/plain
Example Response:
json
Copy code
[
  {
    "date": "2024-12-01T00:00:00Z",
    "temperatureC": 22,
    "summary": "Sunny"
  }
]
Schema Definitions
AddUserRole
Defines the schema for adding user roles.

json
Copy code
{
  "userId": "integer",
  "roleIds": ["integer"]
}
Employee
Defines the schema for employee data.

json
Copy code
{
  "id": "integer",
  "name": "string",
  "company": "string",
  "position": "string"
}
LoginRequest
Defines the schema for the login request.

json
Copy code
{
  "username": "string",
  "password": "string"
}
Role
Defines the schema for role data.

json
Copy code
{
  "id": "integer",
  "name": "string",
  "description": "string"
}
User
Defines the schema for user data.

json
Copy code
{
  "id": "integer",
  "name": "string",
  "username": "string",
  "password": "string"
}

How to Run the Application

1.Clone the repository.
2.Navigate to the project directory.
3.Run the application using your preferred method (e.g., using Visual Studio, VS Code with .NET, etc.).