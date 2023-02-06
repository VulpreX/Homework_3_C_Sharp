System.Console.WriteLine("Enter your number");
System.Console.Write("Your number =");
int.TryParse(Console.ReadLine(), out int n);
int x = 1;
while ( x<=n )
{
    System.Console.Write( $" {Math.Pow( x , 3)}" );
    x++;
    
}
