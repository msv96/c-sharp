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
  }
}