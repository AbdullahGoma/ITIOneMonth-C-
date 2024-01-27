//a.GetLength(0) get rows
//a.GetLength(1) get colomn

double[,] a;
int row, col;
double Summition = 0.0;
double[] sum;
double[] avg;

Console.WriteLine("Enter number of rows for Students and number of colomns for Subjects respectively.");
int.TryParse(Console.ReadLine(), out row);
int.TryParse(Console.ReadLine(), out col);

a = new double[row,col];
sum = new double[row];
avg = new double[col];

for(int i = 0;i < a.GetLength(0);i++) {
    for(int j = 0;j < a.GetLength(1);j++) {
        Console.WriteLine("Enter the " + j + " th mark for " + i + " th Student");
        double.TryParse(Console.ReadLine(), out a[i,j]);
        sum[i] += (a[i,j] + 0.0);
    }
}

for(int j = 0;j < a.GetLength(1);j++) {
    for(int i = 0;i < a.GetLength(0);i++) {
        Summition += (a[i,j] + 0.0);
    }
    avg[j] = Summition / (row * 1.0);
    Summition = 0.0;
}

for(int i = 0;i < sum.Length;i++) {
    Console.WriteLine("Summition of grades for " + i + " th Student = " + sum[i]);
}

for(int i = 0;i < avg.Length;i++) {
    Console.WriteLine("Average of grades for Subject " + i + " th = "+ avg[i]);
}
