// Домашняя работа

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// 3, 5 -> 243 (3⁵),  2, 4 -> 16

// int StepNumbers(int num, int step)
// {
//     int res = num;
//     for (int i = 1; i < step ; i++)
//     {
//        res = res*num;
//             }
//     return res;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень, в которую нужно возвести число: ");
// int step = Convert.ToInt32(Console.ReadLine());

// int res = StepNumbers(num, step);
// Console.WriteLine($"Число {num} в степени {step} равняется {res}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// (Массивы и строки использовать нельзя!!!)
// 452 -> 11, 82 -> 10, 9012 -> 12

// int SummNumb(int num)
// {
//     int summ = 0;
//     int a = num;
//     for (int i = 1; i < num; i++)
//     {
//         summ = summ + a % 10;
//         a = a/10;
//     }
//     return summ;
// }
// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SummNumb(num);
// Console.WriteLine($"Сумма цифр в числе {num} равняется {summ}");


// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19],  6, 1, 33 -> [6, 1, 33]

int[] Array(int numb)
{
    int[] arr = new int[numb];
    for (int i = 0; i < numb; i++)
    {
        Console.WriteLine("Укажите число, чтоб добавить его в массив: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    }
Console.WriteLine("введите размер массива: ");
int numb = Convert.ToInt32(Console.ReadLine());

ShowArray(Array(numb));

