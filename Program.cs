string[] CreateArray(int size)

{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter an array: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SortArray(string[] words)
{
    string temp = string.Empty;

    for (int i = 0; i < words.Length - 1; i++)

    {
        for (int j = 0; j < words.Length - 1 - i; j++)
        {

            if (words[j].Length >= 3)
            {
                temp = words[j];
                words[j] = words[j + 1];
                words[j + 1] = temp;
            }
        }
    }
    return words;
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input array size: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(arraySize);
PrintArray(myArray);
PrintArray(SortArray(myArray));