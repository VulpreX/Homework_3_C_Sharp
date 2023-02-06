static int N(int t) 
{
       while (t > 99999 || t < 10000)
    {
        
        System.Console.WriteLine("You entered an invalid number, please try again.");
      t = int.Parse(Console.ReadLine());     
    }
    return t;
}
System.Console.WriteLine(" Enter a five-digit number, you want to check for palindromicity");

int.TryParse(Console.ReadLine(), out int n);

n = N(n);

int s = n / 1000;
int y = n % 100;
int x =0  ; 
x = x + s % 10;
x = x * 10 + s / 10; 
System.Console.WriteLine($"{x} , {y}");
if ( x == y) System.Console.WriteLine($" Number {n} is a palindrime");
if ( x!=y) System.Console.WriteLine($" Number {n} is not a palindrome");

