namespace CSharp
{
  public class BoolExpression
  {
    public static void CoinFlip()
    {
      Random coin = new();
      int flip = coin.Next(0, 2);
      bool isHead = flip == 0;
      Console.WriteLine(isHead ? "heads" : "tails");
    }
  }
}