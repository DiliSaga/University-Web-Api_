#Student Management Web API

This project is a web API built using .NET and Entity Framework that manages student data along with their guardians and courses. It serves as a backend for a student management system, providing endpoints to handle CRUD operations and other functionalities related to students, guardians, and courses.

Technologies Used
.NET Web API
Entity Framework Core
AutoMapper
Swagger

Getting Started
To get started with this project, follow the steps below:

Clone the repository to your local machine.

Ensure you have .NET SDK and Visual Studio installed.

Open the solution file in Visual Studio.

In the Package Manager Console, run the following command to apply the database migrations:


Update-Database
Build the solution to resolve any dependencies.

Running the API
After setting up the project, you can run the API in the following way:

Set the API project as the startup project in Visual Studio.
Press F5 or click the "Run" button to start the development server.
The API should now be up and running, and you can access it through the following URL:

bash
Copy code
https://localhost:{port}/api/
API Endpoints
The API provides several endpoints to interact with the student data. You can explore and test these endpoints using Swagger, which is integrated into the project.

To access the Swagger UI, navigate to the following URL after running the API:
Update-Database

(make sure youu changed the connection string according to your environment in SQL server)

bash
Copy code
https://localhost:{port}/swagger/index.html
From the Swagger UI, you can browse all the available endpoints, view their request/response details, and even test them directly.

Data Models
The API works with the following data models:

Student
Guardian
Course

Contributing
If you wish to contribute to this project, feel free to fork the repository and create a new branch. Once you've made your changes, submit a pull request, and we will review it together.

Issues
If you encounter any issues or have suggestions for improvements, please open an issue on GitHub. We appreciate your feedback!

License
This project is licensed under the MIT License. Feel free to use, modify, and distribute it as you see fit.

Thank you for checking out this project! We hope it proves to be a valuable resource for your student management needs. If you have any questions or need further assistance, don't hesitate to reach out. Happy coding!
