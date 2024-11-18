# C# BOOTCAMP SECTION 301
**This repository is based on C# Bootcamp published by Murat Yücedağ on Youtube and is a continuation of the previous 101-201 repository. You can browse the details covered in each section from the bottom.**

## 📌 Episode 11: Module OOP: N Architecture Entity Layer with C#
In chapter 301, we started by creating a new solution. Created Entity, DataAccess, Business and Presentation/UI layers that we will use in our projects. We created a folder called Concrete for the EntityLayer class. This Contrete usually contains concrete, that is, classes. We created tables over C# without using SQL and this process is called Code First. Normally a database table created on SQL is transferred to C# via query, while in this method a class is created (the name of the class must be the name of the table) and this created class is transferred to SQL as a table. The properties created in the class represent the columns. BusinessLayer, DataAccessLayer, EntityLayer and PresentationLayer are created and a solution is prepared for the next lesson.
**Notes**
**Access Modifiers:** 1-) Public: Accessible from all the classes under solution. 2-) Private: Accessible from only its own class. 3-) Internal: Accessible only from the layer it's in. 4-) Protected: Accessible only from classes that inherited class.
**Field - Variable - Property:** 1-) Field: Variables defined directly in the class. 2-) Variable: Variables that are defined not directly in the class but, in a method in the class. 3-) Property: When the variable structure receives get; set; values at the end, it becomes property. If you want to read the value of this variable, GET method works. If you want to assign a value of the variable, SET method works.
**Code First:** In the Code First approach, name of the class must be the same and Id must be written at the en in order to recognise that the ID value is the primary key and auto-incrementing. (CategoryId, ProductId etc.)

## 📌 Episode 12: Module OOP: Data Access Layer and Context Class



## 📌 Episode 13: Module OOP: Migration operations and Abstract Interfaces



## 📌 Episode 14: Orm Structure: Create Model with DbFirst in Entity Framework



## 📌 Episode 15: Project Implementation with Entity Framework 


