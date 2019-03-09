using System;
using System.Collections.Generic;

namespace src
{
  public class Program
  {
    static void Main(string[] args)
    {
      string j = "ab", s = "aaba";
      Console.WriteLine($"You have {NumJewelsInStones(j, s)} jewels.");
    }

    public static int NumJewelsInStones(string J, string S)
    {
      HashSet<char> hash = new HashSet<char>(J.ToCharArray());
      int count = 0;
      foreach (char stone in S)
      {
        if (hash.Contains(stone))
        {
          ++count;
        }
      }
      return count;
    }
  }
}
