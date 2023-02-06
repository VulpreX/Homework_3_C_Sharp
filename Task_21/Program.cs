/*Find the distance between two points*/
System.Console.WriteLine("Enter the first coordinate point");
System.Console.Write("x=");
int.TryParse(Console.ReadLine(), out int x);
System.Console.Write("y=");
int.TryParse(Console.ReadLine(), out int y);
System.Console.Write("z=");
int.TryParse(Console.ReadLine(), out int z);
System.Console.WriteLine("Enter the second coordinate point");
System.Console.Write("x=");
int.TryParse(Console.ReadLine(), out int x1);
System.Console.Write("y=");
int.TryParse(Console.ReadLine(), out int y1);
System.Console.Write("z=");
int.TryParse(Console.ReadLine(), out int z1);
double r = Math.Sqrt(Math.Pow( x1 - x , 2) + Math.Pow( y1 - y , 2)+ (Math.Pow( z1 - z , 2)));
System.Console.WriteLine(r);