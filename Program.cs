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
    int count = 0;
    int k = 1;
    string[] newArray = new string[words.Length];
    string temp = string.Empty;
    
    for (int i = 0; i < words.Length - 1; i++)
    {
        temp = words[i];

        for (int j = 0; j < temp.Length; j++)
        {
            count = j + 1;
        }
        if (count <= 3)
        {
            k++;
            newArray[k] = words[i];
        }
    }
    return newArray;
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