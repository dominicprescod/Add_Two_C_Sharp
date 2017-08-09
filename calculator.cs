using System;
namespace calculator
{
  class Progam
  {
    // Main program 
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the first number: ");
      string fNum = Prompt();
      Console.WriteLine("Enter the second number: ");
      string sNum = Prompt();
      addTwo(fNum, sNum);
    }
    // Checks for valid number
    // private static int Parsing(string value)
    // {
      
    // }
    // Get's info from the user
    private static string Prompt()
    {
     string all = Console.ReadLine();
    while(checkInput(all)){
      Console.WriteLine("Enter a valid number: ");
      all = Console.ReadLine();
      checkInput(all);
    }
     return all;
    }
    
    // Checks for NaN number entries
    private static bool checkInput(string value)
    {
     bool badNum = false;
     for (int i = 0; i < value.Length; i++){
      if(value[i] == '0'){
        Console.WriteLine("Got a zero");
      } else {
        int num;
        int.TryParse(value[i].ToString(), out num);
        if(num <= 0) badNum = true;
      }
     }
     return badNum;
    }
    
    private static string addTwo(string val1, string val2)
    {
      int remainder = 0;
      string larger, smaller;
      string result = "";
      // Which of the entries has the larger number
      // Loop through the larger number 
      // When the smaller value does not have a element replace with zero
      if(val1.Length >  val2.Length) {
        larger = val1;
        smaller = val2;
      } else {
        larger = val2;
        smaller = val1;
      } 
      
      int diff = larger.Length - smaller.Length;
      for(int i = 0; i < diff; i++) smaller = "0"+smaller;
      
      for(int i = larger.Length - 1; i >= 0; i--){
        int a = Int32.Parse(larger[i].ToString());
        int b = Int32.Parse(smaller[i].ToString());
        int c = a + b;
        if(remainder > 0) {
          c = c + remainder;
          remainder = 0;
        }
        
        string res = c.ToString();
        
        if( res.Length > 1 ) {
          remainder = Int32.Parse(res[0].ToString());
          result = res[1] + result;
        } else {
          result = res + result;
        }
        
      }
      if(remainder > 0) result = remainder+result;
      Console.WriteLine("The sum is: "+result);
      return result;
    }
  }
}