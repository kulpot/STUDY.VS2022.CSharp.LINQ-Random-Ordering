using System;

//ref link:https://www.youtube.com/watch?v=thZMASt-EUY&list=PL90AF0EFFEF782D27&index=19
// Random Ordering --- rand.Next()

class MainClass
{
    static void Main()
    {
        var rand = new Random();
        var contactNames =
           //DB.Customers.OrderBy(c => c.ContactName).Select(c => c.ContactName);
           DB.Customers.OrderBy(c => rand.Next()).Select(c => c.ContactName).Take(5);
        foreach (string name in contactNames)
            Console.WriteLine(name);
    }
}