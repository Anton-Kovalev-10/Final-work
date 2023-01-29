/* Написать программу, которая из имеющегося массива сторок формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.
*/

string [] arrFirst = new string [6] {"red", "hi", "hello", "world", "res","milk"};
string [] arrSecond = new string [arrFirst.Length];

void ArrayMassive (string [] arrFirst, string [] arrSecond)
{
    int count = 0;
    for (int i = 0; i < arrFirst.Length; i++)
    {
        if (arrFirst[i].Length <= 3)
        {
            arrSecond[count] = arrFirst[i];
            count++;
        }
    }
}

void PrintArray (string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
         Console.Write($"{arr[i]},");   
    }
    Console.WriteLine();
}
ArrayMassive(arrFirst, arrSecond);
PrintArray(arrSecond);  