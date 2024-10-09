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
