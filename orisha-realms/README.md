# Orisha Realms

**Orisha Realms** is an interactive C# console simulation inspired by Yoruba culture. The application allows users to generate entities, manage dynamic runtime specializations, handle character inventories, and track a single global world state using object-oriented principles and software design patterns.

---

## Software Architecture & Design Patterns

This project intentionally implements **4 core design patterns** to ensure flexible, maintainable, and decoupled code:

1. **Singleton Pattern (Creational)**
   * **Implementation:** `World.cs`
   * **Purpose:** Ensures a single, centrally accessible global game state tracking world time, difficulty, and running status across the application.

2. **Factory Method Pattern (Creational)**
   * **Implementation:** `Factory.cs`
   * **Purpose:** Decouples entity instantiation from the main menu loop when creating character archetypes (`Ogun`, `Eshu`, `Yemoja`).

3. **Decorator Pattern (Structural)**
   * **Implementation:** `CharacterPower.cs`, `FirePower.cs`, `WaterPower.cs`
   * **Purpose:** Dynamically enhances character attributes, actions, and speech at runtime without altering base classes or creating deep inheritance hierarchies.

4. **Facade / Encapsulation Pattern (Structural)**
   * **Implementation:** `Inventory.cs`
   * **Purpose:** Encapsulates inventory collections behind a clean interface, preventing the controller loop from interacting directly with underlying C# data collections.

---

## Character Archetypes

* **Ogun (Warrior):** High Strength and Defense.
* **Eshu (Trickster):** High Speed, Agility, and Intellect.
* **Yemoja (Water Guardian):** High Health, Defense, and Intellect.

---

## How to Run

1. Open `orisha-realms.sln` in **Visual Studio**.
2. Build the solution (`Ctrl + Shift + B`).