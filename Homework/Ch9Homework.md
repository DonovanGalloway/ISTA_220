# ISTA 220 C# Chapter 9 Homework
## Donovan Galloway
### 17 March 2018
1.  Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, PFC, Corporal, or 1Lt, 2Lt, Cpt? enum Enlisted
{ REC, PVT, PV2, PFC, SPC, CPL = SPC, SGT, SSG, SFC, MSG, FSG = MSG, SGM, CSM = SGM 

2.  Using the Ranks enum, assign a rank to yourself or a friend.--Enlisted Galloway Enlisted.CPL;
4.  Determine the numeric index of particular ranks, using the Ranks enum. --The following code Console.WriteLine((int)CPL); returns the index integer of 4
5.  How do you select the type of an enum? --enum Enlisted : short { REC, ... CSM = SGM}
6.  Are structs stored on the stack or on the heap? What about enums? Structs and enums are both value types and are thus stored on the stack.
7.  Declare a struct named DOD with four branches.
struct DOD
{
string Army, Airforce, Navy, Marines;
}
9.  Why can’t you create a default constructor for a struct?The reason you can’t declare your own default constructor for a structure is that the compiler always generates one.
10.  What is CIL? What does the CLR do to the CIL? When you compile a C# application, the compiler converts your C# code into a set of instructions using a pseudo-machine code called the Common Intermediate Language (CIL). These are the instructions that are stored in an assembly. When you run a C# application, the CLR takes responsibility for converting the CIL instructions into real machine instructions that the processor on your computer can understand and execute.
