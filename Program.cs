using System;

int secretNumber = new Random().Next(1, 100);

int tries = 4;

int guessNumber = 1;

while (guessNumber <= tries)
{
  Console.WriteLine($"You're on guess {guessNumber} out of 4.");

  Console.WriteLine("Please guess the Secret Number.");

  int guess = int.Parse(Console.ReadLine());

  if (guess == secretNumber)
  {
    Console.WriteLine("You guessed right!!");
    break;
  }
  else
  {
    Console.WriteLine("Sorry, you guessed wrong.");

    if (tries - guessNumber == 1)
    {
      Console.WriteLine("You have 1 guess remaining.");
    }
    else
    {
      Console.WriteLine($"You have {tries - guessNumber} guesses remaining.");
    }
  }
  guessNumber++;
}

