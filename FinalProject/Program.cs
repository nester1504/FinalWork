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
