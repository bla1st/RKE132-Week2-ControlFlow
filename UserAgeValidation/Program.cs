using System.ComponentModel.Design;

Console.WriteLine("Enter your age: ");
int userAge = Int32.Parse(Console.ReadLine());

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else  if(userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}