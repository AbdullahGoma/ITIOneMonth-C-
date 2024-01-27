// Third assignment in Lec 2
Console.Clear();
int size;

size = 3;

int row ,col ,value;

row = 1;
col = (size+1) / 2;

int ColDistance = Console.WindowWidth / (size + 1);
int RowDistance = Console.WindowHeight / (size + 1);

for(value = 1; value <= size * size; value++){
    Console.SetCursorPosition(col * ColDistance, row * RowDistance);
    Console.WriteLine(value);
    if(value % size == 0) {
        row++;
        if(row > size) row = 1;
    } else {
        row--;
        if(row < 1) row = size;
        col--;
        if(col < 1)  col = size;
    }
}
