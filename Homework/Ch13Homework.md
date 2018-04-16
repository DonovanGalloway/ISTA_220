# ISTA 220 C# Chapter 13 Homework
## Donovan Galloway
### 29 March 2018
1.  What is an interface as the term is used on object-oriented programming? is a programming structure/syntax that allows the computer to enforce certain properties on an object (class).

3.  How do you define an interface? interface I (Name the Interface (below the first line, give it a method)No 
5.  How do you define a method in an interface? You declare your interface the { declare the method(object obj);} 
6.  Can you instantiate an object through an interface? Why or why not? Yes; because a class and its objects inherit any methods specified by its interface.
7.  Using the new keyword, can you declare a reference to an interface? int FindLandSpeed(ILandBound landBoundMammal){ ... }
8.  Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?yes they can reference multiple interfaces.
9.  What does it mean to explicitly implement an interface? you specify which interface a method belongs to when you implement it.
10.  What are the restrictions on interfaces? You are not allowed to define any fields in an interface, you are not allowed to define constructors in an interface, you are not allowed to define a destructor in an interface, you cannot specify an access modifier for any method, you cannot nest any types inside an interface, an interface is not allowed to inherit from a structure or a class.
11.  What is the difference between an abstract class and an interface? The main difference between them is that a class can implement more than one interface but can only inherit from one abstract class.
12.  What is an abstract method? is implicitly a virtual method. Abstract method declarations are only permitted in abstract classes.
13.  What is an sealed class? are used to restrict the inheritance feature of object oriented programming. Once a class is defined as a sealed class, the class cannot be inherited 
14.  What is an sealed method? a method type that cannot be overridden by a class.
