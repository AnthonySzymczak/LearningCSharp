// See https://aka.ms/new-console-template for more information

//prompt user to enter the first side of a triangle
Console.WriteLine("Enter side A:");
double a = Convert.ToDouble(Console.ReadLine());

//prompt user to enter the second side of a triangle
Console.WriteLine("Enter side B:");
double b = Convert.ToDouble(Console.ReadLine());


//calculations for finding the remaining side of the triangle (hypotenuse)
double c = Math.Sqrt((a * a) + (b * b));
Console.WriteLine("The Hypotenuse is: " + c);