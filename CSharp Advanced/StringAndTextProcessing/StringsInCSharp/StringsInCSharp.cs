/*
Describe the strings in C#.
What is typical for the string data type?
Describe the most important methods of the String class.
*/

/*
    The string in c# is an object whose value is text and is stored as a sequence of char objects.  String objects are
immutable - they cannot be changed after they have been created. All methods and operators that appear to modify a string
actually return the result in a new string object. 
 
Most important methods of the string class are: 
 * .Split() which splits object by given separator,
 * .Substring() which takes a part from the string from given index and eventually length,
 * .Compare() which compares two strings.
 * .Equals() which determines if two strings have the same value.
 * .Length which return integer based on the amount of elements in the string.
*/