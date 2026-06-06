# 🏨 Grand Azure Hotel Management System
![C#](https://img.shields.io/badge/C%23-Programming-blue?style=for-the-badge&logo=csharp)
![.NET](https://img.shields.io/badge/.NET-Console_App-purple?style=for-the-badge&logo=dotnet)
![OOP](https://img.shields.io/badge/OOP-Principles-orange?style=for-the-badge)
![Status](https://img.shields.io/badge/Project-Completed-success?style=for-the-badge)
![License](https://img.shields.io/badge/License-Educational-lightgrey?style=for-the-badge)

A console-based Hotel Management System built using C# and Object-Oriented Programming principles.

---

## 📌 Project Description

The Grand Azure Hotel Management System is a simulation of a real hotel system where a manager can:

- Add guests
- Add rooms
- Book rooms
- Cancel bookings
- View available and booked rooms
- Search for guest bookings
- Display hotel statistics

This project was developed to practice OOP concepts, collections (List<T>), encapsulation, and console application design.

---

## ⚙️ Technologies Used

- C#
- .NET Console Application
- Object-Oriented Programming (OOP)
- List<T> Collections

---

## 🧠 OOP Concepts Applied

- Classes & Objects
- Encapsulation (private fields + properties)
- Static Members (Guest counter, Booking ID)
- Constructors (parameterized constructors)
- Methods (instance + static methods)
- Object relationships (Booking → Guest + Room)
- Collections using List<T>

---

## 🏗️ Features

### 👤 Guests
- Add new guest
- Prevent duplicate National ID
- Track total guests created

### 🏨 Rooms
- Add rooms (Standard / Deluxe / Suite)
- Prevent duplicate room numbers
- Track availability

### 📅 Booking System
- Book rooms for guests
- Generate unique booking ID
- Prevent double booking
- Cancel bookings safely

### 📊 Reports
- Available rooms
- Booked rooms
- Guest search with bookings
- Hotel statistics dashboard

---
## 🚀 How to Run

1. Clone the repository
2. Open project in Visual Studio
3. Run the program
4. Use console menu to interact

---

### ⭐ Validation & Business Rules


## ✅ Business Rules

The application enforces several real-world hotel management rules:

- A room cannot be booked twice simultaneously.
- Guest National IDs must be unique.
- Room numbers must be unique.
- Bookings can only be cancelled if they exist.
- Room availability is automatically updated after booking or cancellation.
---

## 🏗️ System Architecture

The system follows an Object-Oriented Design where each entity is represented by a dedicated class.

Guest
  │
  ▼
Booking
  ▲
  │
Room

HotelManager
  │
  ├── Manage Guests
  ├── Manage Rooms
  └── Manage Bookings
---

## 📷 Sample Output

Console-based menu system with formatted tables and colored outputs.
![Project Screenshot](https://github.com/Anoudalsaidi/Grand-Azure-Hotel-Management-System/blob/master/menu.png)

---
