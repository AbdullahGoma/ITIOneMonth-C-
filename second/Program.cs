
//First assignment in Lec 2
while(true) {
    int x,y,z;
    x = 0;
    y = 0;
    Console.WriteLine("Enter first number: ");
    int.TryParse(Console.ReadLine(), out x);

    Console.WriteLine("Enter Second number: ");
    int.TryParse(Console.ReadLine(), out y);

    Console.WriteLine("Press Key from 1 to 5 :");
    
    Console.WriteLine("1- For Minimum.");
    Console.WriteLine("2- For Maximum.");
    Console.WriteLine("3- For Summition.");
    Console.WriteLine("4- For Average.");
    Console.WriteLine("5- For Exit.");
    int.TryParse(Console.ReadLine(), out z);
 
    if(z == 1) {
        Console.WriteLine("Minimum value is equal to: " + Math.Min(x,y));
    } else if(z == 2) {
        Console.WriteLine("Maximum value is equal to: " + Math.Max(x,y));
    } else if (z == 3) {
        Console.WriteLine("Summition is equal to: " + (x+y));
    } else if (z == 4) {
        Console.WriteLine("Average is equal to: " + (x+y)/2.0);
    }else if (z == 5) {
        break;
    } else {
        Console.WriteLine("Wrong Key.");
    }
}




