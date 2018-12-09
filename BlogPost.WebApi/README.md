This is example project for blog Basics series. You can find blog here: https://progressdesire.com with Basics tag. 

# Requirements
Our client wants us to create for him simple school API. For now it should keep a list of students and let him add, update and remove students. Additionally every student can choose one Course and be assigned to it. Information kept about student should be minimalist, only Name the same about course. Client wants only to know which courses, students pick the most.

# Architecture
It is simple project which uses ASP.Net WebAPI and Entity Framework to access data from database. In this example Entities are used as Domain Model and are returned from WebAPI. Controllers were generated in Visual Studio.

# Usage
You need MS SQL Server installed on your machine to run project. On the first run, application will create database and seed it with sample data. Additionally you need .Net Core 2.1 SDK installed.

After you run project, open swagger documentation, you can find it here: http://localhost:57298/swagger. Application has minimal functionality, it's very simple to make it easier to learn basics about WebAPI and Entity Framework Core.