// See https://aka.ms/new-console-template for more information

Console.WriteLine("Type in your name on the following line.");
String name = Console.ReadLine();

Console.WriteLine("Type in your age on the following line.");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello "+ name);
Console.WriteLine("You are " + age +" years old!");