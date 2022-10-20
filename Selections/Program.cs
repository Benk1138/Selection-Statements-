// See https://aka.ms/new-console-template for more information
Console.WriteLine("Try to guess my favorite number");
var r = new Random();
var favNumber = r.Next(1, 10);
var userInput = int.Parse(Console.ReadLine());

if (userInput < favNumber)
{
    Console.WriteLine($" {favNumber } is too low");
}

else if(userInput > favNumber )
{
    Console.WriteLine($"{userInput} is too high");
}
    
else
{
    Console.WriteLine($"You got it!");

   
}



Console.WriteLine("What is your favorite subject");

string subject = Console.ReadLine();

switch (subject)
{
    case "science":

        Console.WriteLine("I love science!");
        break;

    case "math":

        Console.WriteLine("I hate math!");
        break;

    case "History":

        Console.WriteLine("History is alright");
        break;

    case "pe":

        Console.WriteLine("pe is great!");
        break;

    case "study hall":

        Console.WriteLine("study hall is much needed.");
        break;

    default:

        Console.WriteLine("I no not know that subject");
        break; 






}

