# DelegateEvent

Delegate: It is a Pointer or takes a reference of another function.
  For Method: => Point To => Method
  For Events: => Point To = > Event Handler Method

In .NET every single event based on the Delegate. It points the same kind of method, including number and types of parameters and also the return type.

Simple Delegates:
  public delegate void myDelegateName(int x, int y)
  
NOTES:
With the help of delegates, we can extend an application and simply add a new feature by adding a class
The glue between the event and the methods to be executed are the delegates.
Event Handlers in the .NET Framework return void and take two parameters.
The first paramter is the source of the event; that is the publishing object.
The second parameter is an object derived from EventArgs.
The primary difference between Delegates and Interfaces is that while delegates reduce the code base and increase readability of code, you have to be careful on how you use them otherwise you might end up sacrificing testability. Coding to interfaces is usually more reliable, even if it requires more code.

Event VS Delegates
Delegates are independent of events. ==> The event can not be created without delegates.


  
  
Imp Links:

https://www.intertech.com/Blog/c-sharp-tutorial-understanding-c-events/
https://medium.com/@mail2sagarsalunkhe/understanding-delegates-and-events-in-c-7093ad8a22e7
http://www.dotnet-guide.com/delegates-vs-interfaces-in-c-sharp.html
https://www.codeproject.com/Articles/468967/Interfaces-vs-Delegates
