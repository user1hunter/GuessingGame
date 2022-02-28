using System;

Console.WriteLine("Please guess the Secret Number.");

int guess = int.Parse(Console.ReadLine());

int secretNumber = 42;

if (guess == secretNumber)
{
  Console.WriteLine("You guessed right!!");
}
else
{
  Console.WriteLine("Sorry, you guessed wrong.");
}

