// See https://aka.ms/new-console-template for more information

// if statement = a basic form of decision making.
// if a block of code is true, return the true option, if false return something else


// if statement checks to see if you are at least 18

Console.WriteLine("please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

// 
if (age > 100)
{
    Console.WriteLine("congratulations on reaching that milestone! you're signed up!");
}
else if (age >= 18)
{
    Console.WriteLine("you are now signed up!");
}
else if(age < 0)
{
    Console.WriteLine("You haven't been born yet!");
}
else
{
    Console.WriteLine("you must be 18+ to sign up");
}




