// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");


//pseudo random numbers

Random random = new Random();

//returns a decimal number between 0 and 1
double num = random.NextDouble();

//random number between 1 and 6
int num1 = random.Next(1, 7);

// 20 sided die
int num2 = random.Next(1, 21);


//int num3 = random.Next(1, 7);



Console.WriteLine(num);
Console.WriteLine(num1);
Console.WriteLine(num2);
//Console.WriteLine(num3);