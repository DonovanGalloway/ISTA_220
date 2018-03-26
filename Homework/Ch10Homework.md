# ISTA C# Chapter 10 Homework
## Donovan Galloway
### 24 March 2018

1.  What does an array look like in memory? It looks like a memory block having consecutive addresses.

3.  Where is memory allocated to hold an array, on the stack or on the heap? Arrays are dynamic. They are reference types and are allocated memory on heap. Every type of array is allocated to heap.
4.  Where is memory allocated to hold an array reference, on the stack or on the heap? The stack.
5.  Can an array hold values of different types? This is a trick question, the answer is, “It depends.” This can be done by using implicitly typed arrays. However the fields must be the same for each element of the array.
6.  Describe the syntax of the condition or a foreach loop. Foreach statement iterates through the entire array.
For example: foreach(int i in data), or foreach(var familyMember in names).

7.  How do you make a deep copy of an array?A deep copy of an Array copies the elements and everything directly or indirectly referenced by the elements. This can be done by using the appropriate code in a for loop.
8.  What is the difference between a multi-dimensional array and an array of arrays? Array of arrays (jagged arrays) are faster than multi-dimensional arrays and can be used more effectively. Multidimensional arrays have nicer syntax. If you write some simple code using jagged and multidimensional arrays and then inspect the compiled assembly with an IL disassembler you will see that the storage and retrieval from jagged (or single dimensional) arrays are simple IL instructions while the same operations for multidimensional arrays are method invocations which are always slower.
9.  How do you “flatten” a multidimensional array? In other words, take something that looks like a matrix   and turn it into an array [1,2,3,4,5,6,7,8,9]? This can be done by using a nested for loop or a foreach loop.