// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void FillArray(int[] collection) 
// {
// int length = collection.Length; 
// int index = 0;
// while (index < length)
// {
// collection[index] = new Random().Next(100, 1000); 

// index++;
// }
// }

// void PrintArray(int[] col)
// {
// int count = col.Length;
// int position = 0;
// while (position < count)
// {
// Console.WriteLine(col[position]);
// position++;
// }
// }

// int myFunc(int[] collection) 
// {
//     int count = 0;

// for (int i = 0; i < collection.Length; i++)
// {
//     if(collection[i] % 2 == 0)
//     count++;
// }

// return count;
//  }


// int[] array = new int[5];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int res = myFunc(array);

// Console.WriteLine($"всего {array.Length} чисел, {res} из них чётные");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArray(int[] collection) 
// {
// int length = collection.Length; 
// int index = 0;
// while (index < length)
// {
// collection[index] = new Random().Next(0, 100); 

// index++;
// }
// }

// void PrintArray(int[] col)
// {
// int count = col.Length;
// int position = 0;
// while (position < count)
// {
// Console.WriteLine(col[position]);
// position++;
// }
// }

// int myFunc(int[] collection) 
// {
// int num = 0;
// int count = collection.Length; 
// for (int i = 0; i < count; i+=2)
// {
//     num = num + collection[i];
// }
// return num;
//  }


// int[] array = new int[4];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int result = myFunc(array);


//  Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях = {result}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите раз массива");
// int array = Convert.ToInt32(Console.ReadLine());

// double[] arr = new double[array];
// FillArrayRandomNumbers(arr);

// Console.WriteLine("Массив");
// PrintArray(arr);

// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     if(arr[i] < min)
//     {
//         min = arr[i];
//     }
// }

// Console.WriteLine($"всего {arr.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers) {

//     for (int j = 0; j < arr.Length; j++)
//     {
//         arr[j] = Convert.ToDouble(new Random().Next(100, 1000)) /100;
//     }
// }


// void PrintArray(double[] numbers) {

//     Console.Write("[ ");

//     for (int z = 0; z < numbers.Length; z++)
//     {
//         Console.Write(numbers[z] + " ");
//     }

//         Console.Write(" ]");
//         Console.WriteLine();
// }