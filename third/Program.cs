
// Second assignment in Lec 2

while(true) {
    int x,y;
    char op;
    Console.WriteLine("Enter first number: ");
    int.TryParse(Console.ReadLine(), out x);

    Console.WriteLine("Enter Second number: ");
    int.TryParse(Console.ReadLine(), out y);

    Console.WriteLine("Enter The operator: (ex: +, -, *, /) ");
    char.TryParse(Console.ReadLine(), out op);
    
    if(op == '-') {
        Console.WriteLine("Sub is equal to: " + (x-y));
    } else if(op == '+') {
        Console.WriteLine("Addition is equal to: " + (x+y));
    } else if(op == '*') {
        Console.WriteLine("Multiplication is equal to: " + (x*y));
    } else if(op == '/') {
        double c = x / (y+0.0);
        Console.WriteLine("Div is equal to: " + c);
    } else {
        Console.WriteLine("Wronge Operator.");
    }
}

