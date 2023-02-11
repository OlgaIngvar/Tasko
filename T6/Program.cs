//  Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GenerateArray(int len)
{
  int[] array = new int[len];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(-9, 10);
  }
  return array;
}
void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    System.Console.Write($"{item}\t");
  }
  System.Console.WriteLine();
}

int SumSign(int[] array, bool positive = true)
{
    int sign = -1;
    if (positive)
    {
        sign = 1;
    }

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] * sign) > 0)
        {
            sum = sum + array[i];
        }
    }

    return sum;
}

int[] array = GenerateArray(12);
PrintArray(array);
System.Console.WriteLine($"Сумма положительных элементов {SumSign(array)}");
System.Console.WriteLine($"Сумма отрицательных элементов {SumSign(array, false)}");