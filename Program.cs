using System;


int input = 0;
Random random = new Random();
int correctNumber = random.Next(1, 100);
int numberOfTries = 0;

Console.Write("Choose dificulty hard, medium, or easy: ");
string difficulty = Console.ReadLine();
if (difficulty == "hard")
{
  numberOfTries = 4;
}
else if (difficulty == "medium")
{
  numberOfTries = 6;
}
else if (difficulty == "easy")
{
  numberOfTries = 8;
}

if (difficulty == "Cheater")
{
  for (int i = 1; i > 0; i++)
  {

    Console.Write("Guess a number: ");
    input = int.Parse(Console.ReadLine());

    if (input == correctNumber)
    {
      Console.WriteLine("You guessed right!");
      break;
    }
    else
    {
      Console.WriteLine($"You guessed wrong...You guessed {input}");
      if (input > correctNumber)
      {
        Console.WriteLine("Try Lower");
      }
      else
      {
        Console.WriteLine("Try Higher");
      }
    }
  }
}
else
{
  for (int i = numberOfTries; i > 0; i--)
  {
    Console.WriteLine($"You have {i} chances left to guess the number.");

    Console.Write("Guess a number: ");
    input = int.Parse(Console.ReadLine());

    if (input == correctNumber)
    {
      Console.WriteLine("You guessed right!");
      break;
    }
    else
    {
      Console.WriteLine($"You guessed wrong...You guessed {input}");
      if (input > correctNumber)
      {
        Console.WriteLine("Try Lower");
      }
      else
      {
        Console.WriteLine("Try Higher");
      }
    }
  }

}


if (input != correctNumber)
{
  Console.WriteLine($"The right answer was {correctNumber}");
}
