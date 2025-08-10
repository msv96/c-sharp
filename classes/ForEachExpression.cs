namespace CSharp
{
  public class ForEachExpression
  {
    public static void UnderstandingForEach()
    {
      string[] names = ["Alex", "Eddie", "David", "Michael"];

      for (int i = 0; i < names.Length; i++)
        if (names[i] == "David") names[i] = "Sammy";

      foreach (var name in names)
        Console.WriteLine(name);
    }

    public static void ForEachAssignment()
    {
      for (int i = 1; i <= 100; i++)
      {
        string result = $"{i}";
        bool divisibleByThree = i % 3 == 0;
        bool divisibleByFive = i % 5 == 0;

        if (divisibleByThree && divisibleByFive)
          result += " - FizzBuzz";
        else if (divisibleByThree)
          result += " - Fizz";
        else if (divisibleByFive)
          result += " - Buzz";

        Console.WriteLine(result);
      }
    }
  }
}