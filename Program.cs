string[] array1 = new string[5] {"hello", "2", "world", ":-)", "185"};
string[] array2 = new string[5] {"1234", "1565", "-2", "com", "git"};
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array2);