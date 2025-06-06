# Project Overview
This is a backend project built with a modular monolith structure and Onion Architecture. It follows clean architecture principles by separating concerns across layers: Presentation (API), Application, Domain, and Infrastructure.

# Key features include:

- **CQRS pattern to split read and write operations for better maintainability.**

- **AutoMapper with DTOs to decouple domain logic from application services.**

- **Repository Pattern for database access and abstraction.**

- **Code-First approach using Entity Framework for modeling and migrations.**

- **The architecture is designed for scalability, testability, and clarity.**

![image](https://github.com/user-attachments/assets/7c270ef8-f7cd-4e3f-8b5c-bbc14c150bb8)


# Colegio Project Setup Instructions

This guide will help you set up and run the Colegio project on your local machine.

## Prerequisites

Before you begin, ensure you have the following installed on your machine:

- **Microsoft SQL Server Management Studio**: For database management.
- **.NET 6.0**: To build and run the backend API.
- **Node.js and npm (Node Package Manager)**: To manage frontend dependencies.
- **Angular 15.2.11**: To serve the Angular frontend application.

## Step-by-Step Instructions

### 1. Set Up the Database

1. **Open Microsoft SQL Server Management Studio**.

2. **Run the Database Script**:
In this repo go to:
```Colegio-CRUD/DB/Restore/ColegioDBCreationScript.sql```

and run the script

OR use the backup .bak file in the DB folder

### 2. Configure the Backend

1. **Open the .NET Solution**:
   - Navigate to the folder containing the .NET backend solution.
   - Open the solution in your preferred IDE (e.g., Visual Studio, Visual Studio Code).

![image](https://github.com/user-attachments/assets/35f89b7e-712d-4ee3-9b6c-5260b34da0ac)


2. **Update Database Credentials**:
   - Locate the `appsettings.json` file in the .NET project.
   - Update the connection string with your SQL Server credentials to connect to the Colegio database.

![image](https://github.com/user-attachments/assets/246234f5-d05f-4a65-9edd-9c500a76ec45)


   **Example**:
```
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=Colegio;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;"
     }
   }
```

3. **Run the API**:
   - Build and run the .NET project to start the backend API.

![image](https://github.com/user-attachments/assets/63ee3c39-dbfe-4ef0-8253-648980f9a1a0)


### 3. Set Up the Frontend

1. **Open the Frontend Folder**:
   - Navigate to the folder containing the Angular frontend project.

2. **Install Dependencies**:
   - Open a terminal or command prompt in the frontend folder.

![image](https://github.com/user-attachments/assets/16451cd5-97d7-4f1f-a0fd-343a82c9131e)

   - Run the following command to install all necessary dependencies:

```
   npm install
```
3. **Run the Angular Application**:
   - Start the Angular development server by running:

   ```
   ng serve
   ```
   
4. **Access the Application**:
   - Open your web browser and navigate to `http://localhost:4200` to use the application.

![image](https://github.com/user-attachments/assets/659fbf0b-5459-4ca8-b31d-12afd91b97bc)


Congratulations! You have successfully set up the Colegio project on your local machine. You can now start exploring it!
Any question to : juand.salazar.m@gmail.com

