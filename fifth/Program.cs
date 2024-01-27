
int[] a;
int size;
int sum = 0,
    max,
    min;

Console.WriteLine("Enter Size of Array.");
int.TryParse(Console.ReadLine(), out size);

a = new int[size];

for (int i = 0;i < size; i++) {
    Console.WriteLine("Enter the " + i + " th element.");
    int.TryParse(Console.ReadLine(), out a[i]);
}


for(int i = 0; i < a.Length; i++) {
    Console.WriteLine("The " + i + " th element is equal to: " + a[i]);
}

max = a[0];
min = a[0];

for(int i = 0; i < a.Length; i++) {
    sum += a[i];

    if(a[i] < min) {
        min = a[i];
    }

    if(a[i] > max) {
        max = a[i];
    }

    if(i == a.Length - 1) {
        Console.WriteLine("Summition of array is equal to: " + sum);
        double avg = sum / (size * 1.0);
        Console.WriteLine("Average of elements is equal to: " + avg);
        Console.WriteLine("Maximum element is equal to: " + max);
        Console.WriteLine("Minimum element is equal to: " + min);
    }
    
}
