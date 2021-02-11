using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Salesperson name");
    var name = Console.ReadLine ();
    Console.WriteLine ("Enter sales amount");
    double amount = Convert.ToInt32(Console.ReadLine ());
    double commission = 200 + (0.09 * amount);
    Console.WriteLine ("Sales commission for " + name + " is $" + commission);
  
  if (amount <= 2999)
  {
    Console.WriteLine ("Performance is poor");
  }
  else if (amount >= 3000 && amount <= 4999)
  {
    Console.WriteLine ("Performance is average");
  }
   else if (amount >= 5000 && amount <= 9999)
  {
    Console.WriteLine ("Performance is good");
  }
  else if (amount >= 10000 && amount <= 14999)
  {
    Console.WriteLine ("Performance is excellent");
  }
  else
  {
    Console.WriteLine ("Performance is outstanding");
  }
 


    
  }
}