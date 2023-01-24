// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] array = new string [6] {"123", "qwerty", "job", "0705", "God", "Russia"};
string[] arrayResult = new string [3];

void FillArray (string[] array, string[] arrayResult)
{
    for (int i = 0; i < array.Length; i++)
        if (i < 3) arrayResult[i] = array[i];
}

void PrintArray (string[] arrayResult)
{
    for (int i = 0; i < 3; i++)
        Console.Write($"{arrayResult[i]}, ");
}

FillArray(array, arrayResult);
PrintArray(arrayResult);

