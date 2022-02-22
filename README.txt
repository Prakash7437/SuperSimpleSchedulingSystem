Getting started with SchedulingSystem.WebApi
--------------------------------------------

To get executed the application please do the following changes and run the application

1. change the connection string in App.config of SchedulingSystem.DataAccess as well as in web.config file of SchedulingSystem.WebApi projects.
2. Enable the migrations on SchedulingSystem.DataAccess application by run the below command in package manager console.
   PM> enable-migrations
3. Add migration by run the below command in package manager console
   PM> add-migration migration-name(Ex: PM> add-migration InitialModels)
4. Run the migration on Database by run the below command in package manager console.
   PM> update-database (This will create the database and tables in Database)   
5. To test the application, swagger is enabled for the SchedulingSystem.WebApi project. Run the application in Visual Studio and navigate to URL Ex: http://localhost:51306/swagger

6. Sample data of students and Courses can be created using the post methods of application or by running the below queries 

SQL Queries for test data:
-------------------------
-- Insert into Courses Table
Insert into Courses values ('C#','Programing Language')
Insert into Courses values ('ASP.NET','Web Application Developement')
Insert into Courses values ('SQL Server','Datanase Training')
Insert into Courses values ('Web API','Web API Framework for building RESTFul Services')
GO

-- Insert into Students Table
Insert into Students values ('Igor','Beylin')
Insert into Students values ('Kritsda','Jiwatrakan')
GO

-- Insert into StudentCourses Table
Insert into StudentCourses values (1, 1, Getdate())
Insert into StudentCourses values (1, 2, Getdate())
Insert into StudentCourses values (2, 1, Getdate())
Insert into StudentCourses values (2, 2, Getdate())
Insert into StudentCourses values (2, 3, Getdate())
GO