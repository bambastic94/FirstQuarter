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