using System;

Console.WriteLine("Please select a difficulty level: Easy(1), Medium(2), Hard(3), Cheater(4).");

int chosenDifficulty = int.Parse(Console.ReadLine());

int secretNumber = new Random().Next(1, 100);

int tries = 0;

bool cheater = false;

switch (chosenDifficulty)
{
  case 1:
    tries = 8;
    break;
  case 2:
    tries = 6;
    break;
  case 3:
    tries = 4;
    break;
  case 4:
    cheater = true;
    break;

  default:
    tries = 1;
    break;
}

int guessNumber = 1;

while (guessNumber <= tries || cheater)
{
  if (!cheater)
  {
    Console.WriteLine($"You're on guess {guessNumber} out of {tries}.");
  }

  Console.WriteLine("Please guess the Secret Number.");

  int guess = int.Parse(Console.ReadLine());

  if (guess == secretNumber)
  {
    Console.WriteLine("You guessed right!!");
    cheater = false;
    break;
  }
  else
  {
    if (guess < secretNumber)
    {
      Console.WriteLine("Sorry, you guessed low.");
    }
    else
    {
      Console.WriteLine("Sorry, you guessed high.");
    }
    if (!cheater)
    {
      if (tries - guessNumber == 1)
      {
        Console.WriteLine("You have 1 guess remaining.");
      }
      else
      {
        Console.WriteLine($"You have {tries - guessNumber} guesses remaining.");
      }
    }
    else
    {
      Console.WriteLine("You have unlimited guesses left.");
    }
    guessNumber++;
  }
}

