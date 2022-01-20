// See https://aka.ms/new-console-template for more information





String fullName = "Anthony Szymczak";
String phoneNumber = "123-456-7890";

//displays full name as uppercase
//fullName = fullName.ToUpper();

//displays full name as lowercase
fullName = fullName.ToLower();

// Replace method replaces characters in a string. the first declaration is the character the program searches for/ replaces, the second declaration is the new character to replace 
phoneNumber = phoneNumber.Replace("-", "/");

//The insert method, we can insert a character or a string at a given index in a pre existing string
// String userName = fullName.Insert(0, "@");

//Propery length returns the length of the string
Console.WriteLine(fullName.Length);

//Substring method takes a string allowing you to extract a piece of the string to create a new substring.
String firstName = fullName.Substring(0, 8);
Console.WriteLine(firstName);

String lastName = fullName.Substring(7, 9);
Console.WriteLine(lastName);
Console.WriteLine(fullName);
Console.WriteLine(phoneNumber);
//Console.WriteLine(userName);