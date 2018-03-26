# ISTA220 C# CH8 Homework
## Donovan Galloway
### 10 March 2018
1.  What is the difference between deep copy and shallow copy? shallow copies duplicate as little as possible while deep copies copy everything.

3.  What is the value of a reference after you declare and initialize it? the value of a reference becomes equal to whatever object it is bound to.
4.  How do you declare a value type? you declare a value type by using the reserved keyword for the value type you wish to use. 
5.  How do you declare a reference type? you declare a reference type by using reference type keywords.
6.  Does C# allow you to assign NULL to a value type? no, null is itself a reference so it cannot be assigned to a value type
7.  Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not? no, because the type cannot be null.
8.  What is the difference between the stack and the heap? stack memory is organized while heap memory is spread around.
9.  What does it mean when we say that all classes are specialized types? classes are specialized types of the system.object and we use system.object to create a variable that refer to any reference type.
10.  What does ref do? passes a reference to the actual argument instead of a copy of the argument.
11.  What does out do? prefixes a parameter so the parameter becomes an alias for an argument.
12.  Describe boxing and unboxing in your own words. Boxing is storing a value type as an object on the heap and unboxing is reading the value from an object. 
13.  What does cast do? specifies, in your opinion, the data referenced by an object has a specific type and that it i safe to reference the object by using that type.