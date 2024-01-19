# Onion-Architecture.Web
<br/>
Onion architecture is one of the best existing architectures for implementing Testability, Maintainability and Dependability in the software structure.

The main goal of this architecture is to build programs with minimal dependencies or so-called loosely coupled, as well as the maximum separation of communication between layers in the program, which simplifies the development, testing, and maintenance of codes.

In this method, the existing layers are connected with each other using Interface, and all the connections are towards the core.

Also, all external dependencies such as web services are known as external layer.

<br/>

Implementation : .NET Core 6
<br/>
First step: implementation of the architecture 
<br/>
Use IOC
<br/>
To use Ninject IOC (Inversion of Control) in an MVC application with .NET Core 6, you need to Install the required NuGet packages:
<br/>
Install-Package Ninject.Web.AspNetCore 
<br/>
Install-Package Ninject.Extensions.Conventions
<br/>
Use UnitOfWork architecture
<br/>
The purpose of the first step is to implement the Application Core layers 
<br/>
to be continuous .....
