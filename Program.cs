string[] words = { "Friday", "Hello", "Two", "Hi!", "Greetings", "Yo!", "=P", "Lesson", "Test", "Job" };

int ArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateArray(int count)
{
    string[] array = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

string[] ThreeSymbols(string[] array)
{
    string[] line = new string[ArrayLength(array)];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            line[j] = array[i];
            j++;
        }
    }
    return line;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string PromptString(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToString(Console.ReadLine());
}

int PromptInt32(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool ConfirmInput(string text)
{
    if (text == "Y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintAnswer(string[] array)
{
    PrintArray(array);
    System.Console.WriteLine("\nОтсортированный вариант:");
    string[] arrayEnd = ThreeSymbols(array);
    PrintArray(arrayEnd);
}

string answer = (PromptString("Введете матрицу в ручную?(Y/N)"));

while (answer != "Y" && answer != "N")
{
    answer = PromptString("Повторите ответ(Y/N)");
}

if (ConfirmInput(answer))
{
    int count = PromptInt32("Какое количество элементов вы желаете ввести?");
    string[] wordsSelf = CreateArray(count);
    Console.WriteLine("Это ваша матрица:");
    PrintAnswer(wordsSelf);
}
else
{
    string[] array = ThreeSymbols(words);
    Console.WriteLine("Это стандартная матрица:");
    PrintAnswer(words);
}