using System;
namespace addTwo
{
  class Progam
  {
    static void Main(string[] args)
    {
      int num, x, y, result, result2;
      Console.Write("Enter the first number: ");
      x = Prompt();
      Console.Write("Enter the second number: ");
      y = Prompt();
      result = x + y;
      Console.Write("The sum of two numbers is: "+result);  
      result2 = x * y;
      Console.Write("The multiplication of two numbers is: "+result2);
    }
    
    private static int Parsing(string value)
    {
      int num;
      int.TryParse(value, out num);
      if(num == 0) {
        return 0;
      } else {
        return num;
      }
    }
    
    private static int Prompt()
    {
      int number = Parsing(Console.ReadLine());
      while(number <= 0){
        Console.Write("Please enter a valid number: ");
        number = Parsing(Console.ReadLine());
      }
      return number;
    }
  }
}
