+ Why do we need the Dependency Injection Design Pattern in C#?
- Used to reduce the tight coupling between the software components

+ What is Tight Coupling in Software Design?
- Tight coupling means two objects are dependent on each other. In that case, if we change the dependent object, then we also need to change the classes where this dependent object is used.

+ What is Loose Coupling in Software Design?
- Loosely coupling means two objects are independent of each other. That means if we change one object then it will not affect another object.

+ What is Dependency Injection Design Pattern in C#?
- A process in which we are injecting the object of a class into a class that depends on that object.
- It allows the creation of dependency objects outside of a class and provides those objects to a class in different ways.

+ Different Types of Dependency Injection in C#?
- Constructor Injection: When the Injector injects the dependency object (i.e. service) through the client class constructor, then it is called Constructor Dependecy Injection.
- Property Injection: When the Injector injects the dependency object (i.e. service) through the public property of the client class, then it is called Property Dependency Injection. This is also called the Setter Injection.
- Method Injection: When the Injector injects the dependency object (i.e. service) through a public method of the client class, then it is called Method Dependency Injection. In this case, the client class implements an interface that declares the method(s) to supply the dependency object and the injector uses this interface to supply the dependency object (i.e. service) to the client class.

+ Advantages of Constructor Dependency Injection
- The Constructor Dependency Injection Design Pattern makes a strong dependency contract
- This design pattern support testing as the dependencies are passed through the constructor.




