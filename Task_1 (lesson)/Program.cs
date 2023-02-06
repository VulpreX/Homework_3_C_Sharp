static int N(int t) 
{
       while (t > 4 || t < 1)// пока еще не дошел до того как сделать проверку на строку и/или, например, дробно число.  А еще если ввести значение +-0,4, -0,1 оно ломает программу. тоже не понял почему.
    {
        
        System.Console.WriteLine("You entered an invalid number, please try again (from 1 before 4)");
      t = int.Parse(Console.ReadLine());     
    }
    return t;
}
System.Console.WriteLine(" Enter number of quarter (1-4) ");
int.TryParse(Console.ReadLine(), out int n);
n = N(n);

object [,] array = new object[,] { {0}, {"PositiveInfinity"}, {"NegativeInfinity"}};

if ( n == 1)
{
    System.Console.WriteLine($" x = from {array[0,0]} before {array[1,0]}, y = from {array[0,0]} before {array[1,0]} ");
}
if ( n == 4)
{
    System.Console.WriteLine($" x = from {array[0,0]} before {array[1,0]}, y = from {array[2,0]} before {array[0,0]} ");

}
if ( n == 3)
{
    System.Console.WriteLine($" x = from {array[2,0]} before {array[0,0]}, y = from {array[2,0]} before {array[0,0]} ");

}
if ( n == 2)
{
    System.Console.WriteLine($" x = from {array[2,0]} before {array[0,0]}, y = from {array[2,0]} before {array[0,0]} ");
    
}

