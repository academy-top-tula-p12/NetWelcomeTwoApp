int[] array = new int[5] { 11, 22, 33, 44, 55 };
int[] array2 = new int[] { 11, 22, 33, 44, 55 };
int[] array3 = new[] { 11, 22, 33, 44, 55 };
int[] array4 = { 11, 22, 33, 44, 55 };

string[] students = { "Bob", "Joe", "Sam" };

//C#12
//int[] arr = [];


//for (int i = 0; i < size; i++)
//    array[i] = i + 1;

//var array2 = array;

for (int i = 0; i < array.Length; i++)
    Console.Write(array[i]);
Console.WriteLine();

for (int i = 1; i <= array.Length; i++)
    Console.Write(array[^i]);
Console.WriteLine();

foreach (var item in students)
    Console.WriteLine(item);

int[,] matrix1 = new int[3, 4];
int[,,] cube = new int[2, 3, 4];

Console.WriteLine(matrix1.GetLength(1));

int[][] zmatrix =  new int[3][];
zmatrix[0] = new int[3];
zmatrix[1] = new int[5];
zmatrix[2] = new int[4];