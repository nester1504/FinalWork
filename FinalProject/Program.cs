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