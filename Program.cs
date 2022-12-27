// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Домашнее задание №47
/*
void NewMatrix(double[,] test){
    for (int i = 0; i < test.GetLength(0); i++){
        for (int j = 0; j < test.GetLength(1); j++){
            test[i, j] = new Random().NextDouble() * (100 - 0) + 0;
            Console.Write($"{Math.Round(test[i, j], 2)} \t");
        }
    Console.WriteLine();    
    }
}

Console.Clear();
Console.WriteLine("Введите число столбцов и строк ");
string[] numbers = Console.ReadLine().Split(" ");
double[,] test = new double[int.Parse(numbers[0]), int.Parse(numbers[1])];
NewMatrix(test);
*/


//Домашнее задание №50
/*
void InputMatrix(int[,] matrix){   //заведем процедуру
    for (int i =0; i < 5; i++){
        for (int j =0; j < 4; j++){
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix = new int[5, 4];
InputMatrix(matrix);
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
if (n >= matrix.GetLength(0) || m >= matrix.GetLength(1) || m < 0 || n < 0)  // эту часть списал с ношиона
    Console.WriteLine("Нет такой позиции"); 
else   
    Console.WriteLine(matrix[n, m]);
*/



//Домашнее задание №52
/*
void InputMatrix(int[,] matrix){   //заведем процедуру
    
    for (int i =0; i < matrix.GetLength(0); i++){
        for (int j =0; j < matrix.GetLength(1);j++){
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите число столбцов и строк ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
for (int i =0; i < matrix.GetLength(0); i++){
    double n = 0, m = 0;
    for (int j =0; j < matrix.GetLength(1);j++){
        n++;
        m += matrix[j, i]; 
        
        }
    Console.WriteLine(m/n);
    }
*/