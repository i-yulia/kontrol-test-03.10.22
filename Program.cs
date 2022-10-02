// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
string[] FindLenght(string[] array)
{
    string[] result = new string[0];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[j] = array[i];
            j++;
        }
    }
    return result;
}
Console.Write("Введите строки массива, разделив их запятой: ");
string text = Console.ReadLine() ?? String.Empty;
string[] myArray = text.Split(",");
string[] newArray = FindLenght(myArray);
Console.WriteLine($"Строки, длина которых не более 3 символов: {String.Join(", ", newArray)}");