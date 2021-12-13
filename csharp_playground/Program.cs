// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

decimal dec1 = 0.0000000000000000000000000000000000000000000000000000321M;
decimal dec2 = 0.0000000000000000000000000000000000000000000000000000322M;
double doub1 = 0.0000000000000000000000000000000000000000000000000000322;
double doub2 = 0.0000000000000000000000000000000000000000000000000000321;

Console.WriteLine($"decimals are equal: {dec1 == dec2}"); // prints true
Console.WriteLine($"doubles are equal: {doub1 == doub2}"); // prints false
// lesson: don't use == with doubles, decimals have accurate precision

Console.WriteLine($"double NaN: {double.NaN}");
Console.WriteLine($"double epsilon: {double.Epsilon}");
Console.WriteLine($"double positive infinity: {double.PositiveInfinity}");
Console.WriteLine($"double negative infinity: {double.NegativeInfinity}");
// lesson: these could be useful

object height = 1.88; // storing a double in an object
object name = "Jack"; // storing a string in an object
//int len1 = name.Length; // this gives a compile error
int len2 = ((string)name).Length; // compiler needs to be told it's a string
Console.WriteLine($"{name} has {len2} characters.");
// lesson: these are objects I guess, not sure if I'll run into em much since
// generics seem to have effectively replaced them :-)

dynamic something = "Jack"; // storing a string in a dynamic object
something = 12; // int does not have a length property
something = new[] { 3, 5, 7 }; // an array of any type does have a length property

// this compiles but would throw an exception at run-time
// if you later store a data type that does not have a length property
Console.WriteLine($"Length of something is: {something.Length}");
