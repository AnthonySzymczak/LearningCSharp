// See https://aka.ms/new-console-template for more information


double x = 3;
double y = -4;
double z = 3.14;
double j = 3.99;

//raises x to the second power returning 9
double a = Math.Pow(x, 2);

// finds the square root of a number
double b = Math.Sqrt(x);

//displays the absolute value of a given number
double c = Math.Abs(y);

//Rounds a number to the nearest whole number <.5 or >.5
double d = Math.Round(z);

//rounds up no matter what with the Ceiling method.
double e = Math.Ceiling(z);

//rounds down no matter what with the floor method.
double f = Math.Floor(j);

// Maximum number between x and y and stores it in variable g
double g = Math.Max(x,y);

// minimum number between x and y and stores it in variable h
double h = Math.Min(y,z);




Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);


