using System;
using System.Collections.Generic;

namespace starwars
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, int> starwarsCharacters = new Dictionary<string, int>();
      starwarsCharacters.Add("Chewbacca", 234);
      starwarsCharacters.Add("Yoda", 900);
      starwarsCharacters.Add("Anakin Skywalker", 23);
      starwarsCharacters.Add("Emperor Palpatine", 75);

      foreach (KeyValuePair<string, int> character in starwarsCharacters)
      {
        Console.WriteLine($"{character.Key} is {character.Value} years old");
      }

    }
  }
}
