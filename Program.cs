// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 


string[] Func3Symbol(string[] array)
{
    string result = string.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result += array[i] + '*';
        }
    }
    return result.Split('*');
}

string[] array = { "Hello", "OK", "Developer", "a", "A!", "12345", "11" };
string[] resultArray = Func3Symbol(array);

for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i] + " ");
}

