namespace CSharp
{
  public class WhileLoop
  {
    public static void DoWhileExpression()
    {
      Random random = new();
      int current = 0;

      do
      {
        current = random.Next(1, 11);
        Console.WriteLine(current);
      } while (current != 7);
    }

    public static void WhileExpression()
    {
      Random random = new();
      int current = random.Next(1, 11);

      while (current >= 3)
      {
        Console.WriteLine(current);
        current = random.Next(1, 11);
      }
      Console.WriteLine($"Last number: {current}");
    }

    public static void DoWhileAssignment()
    {
      int hero = 10;
      int monster = 10;

      Random dice = new();

      do
      {
        int roll = dice.Next(1, 11);
        monster -= roll;
        Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

        if (monster <= 0) continue;

        roll = dice.Next(1, 11);
        hero -= roll;
        Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
      } while (hero > 0 && monster > 0);

      Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
    }

    public static void ValidateUserInput()
    {
      string? userInput;
      bool isNumberValid;

      Console.WriteLine("Enter an integer value between 5 and 10");

      do
      {
        userInput = Console.ReadLine();

        isNumberValid = int.TryParse(userInput, out int enteredNumber);

        if (!isNumberValid)
        {
          Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
        else if (enteredNumber <= 5 || enteredNumber >= 10)
        {
          Console.WriteLine($"You entered {enteredNumber}. Please enter a number between 5 and 10.");
        }
        else
        {
          Console.WriteLine($"Your input value ({enteredNumber}) has been accepted.");
        }
      } while (userInput != null);
    }
  }
}