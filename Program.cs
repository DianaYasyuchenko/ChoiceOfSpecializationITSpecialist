string[] CreateStringArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element of array: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] CreateNewArrayFromElements(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }
    if (size == 0) Console.WriteLine("There are no strings in the array whose length is less or equal 3 characters");

    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateStringArray(a);
ShowArray(myArray);
string[] myNewArray = CreateNewArrayFromElements(myArray);
ShowArray(myNewArray);