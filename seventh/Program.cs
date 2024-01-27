

while(true) {
    Console.WriteLine("Enter the equation. (ex: 1+1,1-1,1*1,1/1,1%1)");
    String Equation = Console.ReadLine();

    if(Equation.Contains('+')) {
        String[] Operator = Equation.Split("+");
        int num1 = int.Parse(Operator[0]);
        int num2 = int.Parse(Operator[1]);
        int Result = num1 + num2;
        Console.WriteLine("Result is = " + Result);
    } else if(Equation.Contains('-')) {
        String[] Operator = Equation.Split("-");
        int num1 = int.Parse(Operator[0]);
        int num2 = int.Parse(Operator[1]);
        int Result = num1 - num2;
        Console.WriteLine("Result is = " + Result);
    } else if(Equation.Contains('*')) {
        String[] Operator = Equation.Split("*");
        int num1 = int.Parse(Operator[0]);
        int num2 = int.Parse(Operator[1]);
        int Result = num1 * num2;
        Console.WriteLine("Result is = " + Result);
    } else if(Equation.Contains('/')) {
        String[] Operator = Equation.Split("/");
        int num1 = int.Parse(Operator[0]);
        int num2 = int.Parse(Operator[1]);
        double Result = num1 / (num2 * 1.0);
        Console.WriteLine("Result is = " + Result);
    } else if(Equation.Contains('%')) {
        String[] Operator = Equation.Split("%");
        int num1 = int.Parse(Operator[0]);
        int num2 = int.Parse(Operator[1]);
        int Result = num1 % num2;
        Console.WriteLine("Result is = " + Result);
    } else {
        Console.WriteLine("Enter Right Equation.");
    }

}

































// Console.WriteLine("Enter the equation.");
// String Equation = Console.ReadLine();

// int b = int.Parse(Equation[0].ToString());
// int c = int.Parse(Equation[2].ToString());

// char a = Equation[1];

// if(a == '+') {
//     Console.WriteLine("Result is = " + (b + c));
// } else if(a == '*') {
//     Console.WriteLine("Result is = " + (b * c));
// } else if(a == '-') {
//     Console.WriteLine("Result is = " + (b - c));
// } else if(a == '/') {
//     Console.WriteLine("Result is = " + (b / (c + 0.0)));
// }