# Design-Patterns

## Object-Oriented Programming Principles

### Encapsulation

Encapsulation is the process of bundling data (attributes) and methods (functions) that operate on the data into a single unit or class. It restricts direct access to some of the object's components, which is a means of preventing accidental interference and misuse of the data. Encapsulation allows you to control the visibility and accessibility of class members by using access modifiers like `private`, `protected`, and `public`.

### Abstraction

Abstraction is the concept of hiding complex implementation details and showing only the essential features of the object. It allows the user to interact with the system without knowing the underlying complexity. Abstraction is typically achieved through abstract classes or interfaces that define methods without implementing them, leaving the implementation to subclasses.

### Inheritance

Inheritance is a mechanism in object-oriented programming that allows one class (the child or subclass) to inherit properties and behaviors (fields and methods) from another class (the parent or superclass). This promotes code reusability and establishes a relationship between the child and parent classes, where the child can add new features or override existing ones from the parent.

### Polymorphism

Polymorphism is the ability of an object to take on many forms. In object-oriented programming, polymorphism allows objects of different classes to be treated as instances of the same class through a common interface. This can be achieved through method overriding (runtime polymorphism) or method overloading (compile-time polymorphism).

### Coupling

Coupling refers to the degree of direct dependence between two modules or classes in a software system. It indicates how closely connected different components are to each other. There are two main types of coupling:

- **Tight (High) Coupling**: Occurs when components are highly dependent on each other. Changes in one module often require changes in another. Tight coupling makes the system harder to maintain and scale because it reduces modularity and increases complexity.

- **Loose (Low) Coupling**: Occurs when components have minimal dependencies on each other. Loose coupling allows for greater flexibility, easier testing, and better maintainability, as changes in one module don't heavily impact other modules. This is usually preferred in software design.

### Composition

Composition is a design principle in object-oriented programming where one class contains an instance (or instances) of another class as a part of its properties, rather than inheriting from it. It represents a "has-a" relationship, meaning one class is made up of one or more objects of other classes. Composition allows for greater flexibility than inheritance because it provides more control over which objects should be included and how they are managed.

## SOLID Principles

### Single Responsibility Principle (SRP)

The **Single Responsibility Principle** states that a class should have one, and only one, reason to change. This means that a class should only have one job or responsibility. By adhering to SRP, we keep classes focused and easy to maintain, as changes in one functionality of the system will affect only the related class and not others.

In simpler terms, a class should do one thing and do it well.

### Open/Closed Principle (OCP)

The **Open/Closed Principle** states that software entities (such as classes, modules, or functions) should be **open for extension** but **closed for modification**. This means that the behavior of a class can be extended (through inheritance or composition) without modifying its existing code. The goal is to allow the class to adapt to new functionality without changing the current implementation, reducing the risk of breaking existing functionality.

### Liskov Substitution Principle (LSP)

The **Liskov Substitution Principle** states that objects of a superclass should be replaceable with objects of a subclass **without affecting the correctness of the program**. In other words, derived classes must be substitutable for their base classes without altering the expected behavior.

This principle ensures that a subclass maintains the integrity of the base class’s contract, allowing polymorphism to be implemented reliably.

### Interface Segregation Principle (ISP)

The **Interface Segregation Principle** states that no client should be forced to depend on methods it does not use. Instead of creating large, monolithic interfaces that contain all possible functionalities, it’s better to break them into smaller, more specific interfaces. This ensures that classes only need to implement the methods that are relevant to them.

In simpler terms, ISP promotes having multiple small, focused interfaces rather than a single large interface that does too much.

### Dependency Inversion Principle (DIP)

The **Dependency Inversion Principle** states that high-level modules should not depend on low-level modules. Both should depend on abstractions (e.g., interfaces or abstract classes). Additionally, abstractions should not depend on details; details should depend on abstractions.

In simpler terms, this principle promotes the decoupling of code by ensuring that both high-level and low-level components rely on a shared abstract interface, making the system more flexible and easier to maintain.
