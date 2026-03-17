# InhPoly
# OOP Fundamentals: Vehicles & Shapes

This solution, titled **BankingSystem**, contains two primary projects designed to demonstrate the core principles of Object-Oriented Programming (OOP) in C#: **Inheritance**, **Polymorphism**, **Abstraction**, and **Encapsulation**.

---

## 🛠 Tech Stack
* **Language:** C# 12.0
* **Framework:** .NET 8.0
* **Environment:** Windows 11 (khalos-dev)
* **Shell:** PowerShell 7.5.4

---

## 🏎 Project 1: Vehicles
This project explores class hierarchies and the relationship between different types of transport and their engines.

### Key Features
* **Engine Encapsulation:** Implements a base `Engine` class with specific specialisations like `CarEngine` and `MotorcycleEngine`.
* **Constructor Chaining:** Demonstrates how to pass data from child classes (like `Car` or `Motorcycle`) up to the `Vehicle` base class using the `base` keyword.
* **Logic:**
    * `StartEngine()`: Initialises the vehicle state.
    * `Drive()`: Checks if the engine is running before allowing movement.

---

## 📐 Project 2: Shapes (2D & 3D)
A mathematical implementation of geometric shapes, focusing on **Method Overriding** and **Downcasting**.

### 2D Shapes
All 2D shapes inherit from a `public abstract class Shape` and implement their own version of `CalculateArea()`.
* **Circle:** $\pi \times r^2$
* **Rectangle:** $Length \times Width$
* **Triangle:** $(Base \times Height) / 2$

### 3D Shapes
The `Shape3D` project takes 2D shapes as a base to calculate volume.
* **Cylinder & Prism:** Calculates volume as $BaseArea \times Height$.
* **Cone:** Calculates volume as $(BaseArea \times Height) / 3$.
* **Sphere:** Implements the formula $\frac{4}{3} \pi r^3$ by casting the `BaseShape` back to a `Circle` to access the radius.

> [!NOTE]
> **Implementation Detail:** To ensure mathematical precision, all divisions use double literals (e.g., `4d / 3d`) to prevent integer division errors.

---

## 🚀 How to Run
1. Open **PowerShell 7.5.4**.
2. Navigate to the project folder: 
   `cd Documents/northcoders/week2/InhPoly/Vehicles`
3. Run the project:
   `dotnet run`

---

## 👨‍💻 Author
**Khalos CF Moscato** Software Engineer in Training | Multilingual Developer