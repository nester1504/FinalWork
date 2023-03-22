/// <summary>
/// Медот считывает ввод с клавиатуры
/// и делает проверку на ввод только целых положительных чисел
/// </summary>
/// <returns>Целое число</returns>
int ReadNumber()
{
    bool check = false;
    int number = 0;
    while (check == false)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            if (number <= 0)
            {
                Console.WriteLine("Число должно быть больше нуля");
            }
            else
            {
                check = true;
            }

        }
        else
        {
            Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
        }
    }
    check = false;
    return number;
}

/// <summary>
/// Метод заполняем массив текстом введёный с 
/// клавиатуры пользователем
/// </summary>
/// <param name="array">Массив строк</param>
/// <param name="size">Размер массива</param>
/// <returns>Возврощяет заполненый массив</returns>
string[] CompletionArray(string[] array, int size)
{
    string[] arrayGet = new string[size];
    int count = 0;
    while (count != size)
    {
        Console.WriteLine($"Введите {count + 1} строку");
        string text = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(text))
        {
            Console.WriteLine("Строка не может быть пустой");
        }
        else
        {
            arrayGet[count] = text;
            count++;
        }
    }
    return arrayGet;
}

/// <summary>
/// Метод находит в массиве строки состоящие из трёх или менее символов
/// и записывает их в новый масиив
/// </summary>
/// <param name="array">Массив строк</param>
/// <param name="size">Длина массива</param>
/// <returns>Возврощяет новый массив состоящий из трёх или менее символов</returns>
string[] ArrayThreeChar(string[] array, int size)
{
    int sizeCount = 1;
    string[] arrayFinal = new string[sizeCount];
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref arrayFinal, sizeCount);
            arrayFinal[sizeCount - 1] = array[i];
            sizeCount++;
        }
    }
    return arrayFinal;
}

/// <summary>
/// Метод печатает одномерный массив
/// состоящий из строк
/// </summary>
/// <param name="arr">Массив строк</param>
void WriteArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}] ");
    }
}
