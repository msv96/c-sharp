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

    public static void PermissionLevel()
    {
      string permission = "Admin";
      int level = 65;
      // int level = 50;

      // string permission = "Manager";
      // int level = 30;
      // int level = 10;

      // string permission = "User";
      // int level = 10;

      string access = "You do not have sufficient privileges.";

      if (permission.Contains("Admin"))
      {
        if (level > 55)
        {
          access = "Welcome, Super Admin user.";
        }
        else
        {
          access = "Welcome, Admin user.";
        }
      }
      else if (permission.Contains("Manager"))
      {
        if (level >= 20)
        {
          access = "Contact an Admin for access.";
        }
      }

      Console.WriteLine(access);
    }
  }
}