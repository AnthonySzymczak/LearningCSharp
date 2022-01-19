// See https://aka.ms/new-console-template for more information





String fullName = "Anthony Szymczak";
String phoneNumber = "123-456-7890";


//displays full name as uppercase
//fullName = fullName.ToUpper();

//displays full name as lowercase
fullName = fullName.ToLower();

// Replace method re
phoneNumber = phoneNumber.Replace("-", "/");


Console.WriteLine(fullName);
Console.WriteLine(phoneNumber);