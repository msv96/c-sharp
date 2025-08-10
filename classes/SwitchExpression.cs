namespace CSharp
{
  public class SwitchExpression
  {
    public static void TestSwitch()
    {
      int employeeLevel = 200;
      string employeeName = "John Smith";

      string title;
      switch (employeeLevel)
      {
        case 100:
          title = "Junior Associate";
          break;
        case 200:
          title = "Senior Associate";
          break;
        case 300:
          title = "Manager";
          break;
        case 400:
          title = "Senior Manager";
          break;
        default:
          title = "Associate";
          break;
      }
      Console.WriteLine($"{employeeName}, {title}");

      /* string jobTitle = employeeLevel switch
      {
        100 => "Junior Associate",
        200 => "Senior Associate",
        300 => "Manager",
        400 => "Senior Manager",
        _ => "Associate",
      };
      Console.WriteLine($"{employeeName}, {jobTitle}"); */
    }

    public static void ConvertToSwitch()
    {
      // SKU = Stock Keeping Unit. 
      // SKU value format: <product #>-<2-letter color code>-<size code>
      string sku = "01-MN-L";

      string[] product = sku.Split('-');

      string type = product[0] switch
      {
        "01" => "Sweat shirt",
        "02" => "T-Shirt",
        "03" => "Sweat pants",
        _ => "Other",
      };

      string color = product[1] switch
      {
        "BL" => "Black",
        "MN" => "Maroon",
        _ => "White",
      };

      string size = product[2] switch
      {
        "S" => "Small",
        "M" => "Medium",
        "L" => "Large",
        _ => "One Size Fits All",
      };

      Console.WriteLine($"Product: {size} - {color} - {type}");
    }
  }
}