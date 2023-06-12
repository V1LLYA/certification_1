// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NaturalNumbersInInterval(int num){
//     if(num > 0){
//         Console.Write($"{num} ");
//         NaturalNumbersInInterval(num - 1);
//     }
// }

// Console.Write("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Числа от {num} до 1 ==> ");
// NaturalNumbersInInterval(num);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void SumNumbers (int m, int n, int sum){
//     if (m > n){
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} ==> {sum}"); 
//         return;
//     }
//     sum = sum + (m++);
//     SumNumbers(m, n, sum);
// }

// Console.Write("Введите начальное число: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите начальное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumNumbers(m, n, 0);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AckermanFunc (int m, int n){
//     if (m == 0) return n + 1;
//     if (m != 0 && n == 0) return AckermanFunc(m - 1, 1);
//     if (m > 0 && n > 0) return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
//     return AckermanFunc(m, n);
// }

// Console.Write("Введите первое натурально число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе натуральное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Функция Аккермана для чисел A({m}, {n}) = {AckermanFunc(m, n)}");