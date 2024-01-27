// See https://aka.ms/new-console-template for more information

int x, y,sum;

Console.WriteLine("Enter first number: ");
int.TryParse(Console.ReadLine(), out x);

Console.WriteLine("Enter Second number: ");
int.TryParse(Console.ReadLine(), out y);

sum = x + y;
double avg = sum / 2.0;

Console.WriteLine("Summition is equal to: {0}",sum);
Console.WriteLine("Average is equal to: {0}",avg);


 
