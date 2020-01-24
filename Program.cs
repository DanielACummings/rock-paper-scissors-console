using System;
using System.Collections.Generic;

namespace day_1
{
  class Program
  {
    static void Main(string[] args)
    {
      bool playing = true;
      while (playing)
      {
        var options = new List<string>
      {
        "rock", "paper", "scissors"
      };
        var rnd = new Random();
        int randomOption = rnd.Next(options.Count);
        string compChoice = options[randomOption];

        Console.WriteLine("Choose your weapon: rock, paper, or scissors?");
        string response = Console.ReadLine();

        Console.Clear();

        switch (response)
        {
          case "rock":
            if (compChoice == "rock")
            {
              Console.WriteLine("Tie");
            }
            else if (compChoice == "paper")
            {
              Console.WriteLine("You loose");
            }
            else
            {
              Console.WriteLine("You win!");
            }
            break;

          case "paper":
            if (compChoice == "paper")
            {
              Console.WriteLine("Tie");
            }
            else if (compChoice == "scissors")
            {
              Console.WriteLine("You loose");
            }
            else
            {
              Console.WriteLine("You win!");
            }
            break;

          case "scissors":
            if (compChoice == "scissors")
            {
              Console.WriteLine("Tie");
            }
            else if (compChoice == "rock")
            {
              Console.WriteLine("You loose");
            }
            else
            {
              Console.WriteLine("You win!");
            }
            break;

          default:
            {
              Console.WriteLine("Your weapon choice isn't allowed.");
            }
            break;
        }
      }
    }
  }
}
