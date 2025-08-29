Flight Management System - C# Console Application
Overview

This project is a C# console application developed as part of a school partial exam. It simulates a simple flight management system, showcasing object-oriented programming concepts such as inheritance, polymorphism, and collections.

Features

  Flight Management
  
  Register flights (CAereo) with code, origin, destination, price, and type.
  
  Store and manage flights in a catalog (CCatalogo).
  
  Remove individual flights or clear the entire catalog.
  
  Pricing
  
  Flight prices can be queried with different installment options: 1, 3, 6, or 12 payments.
  
  A static tax can be applied to all flights.
  
  Inheritance
  
  CViaje is the abstract base class for all flights.
  
  CAereo inherits from CViaje and adds specific flight details like flight type and tax.

Project Structure

Entities:
  
  CViaje (abstract class for general flights)
  
  CAereo (concrete flight class with tax and flight type)
  
  Catalog:
  
  CCatalogo (manages the flight collection)

Usage

  Clone the repository.
  
  Open the project in Visual Studio or Visual Studio Code with the C# extension.
  
  Build and run the application.
  
  Use the console interface to register, query, and manage flights.

Notes

  This project demonstrates OOP principles in C#, including inheritance, polymorphism, and collections.
  
  Some parts are designed for exam purposes and may not be fully complete.
