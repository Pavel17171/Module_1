string[] array = {"hello", "2", "world", ":-)"};
int numberOfCharacters = 3;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= numberOfCharacters)
    {
        count++;
    }
}

char s = '"';
Console.Write($"Исходный массив: [{s}");
Console.Write(String.Join($"{s},{s}", array));
Console.WriteLine($"{s}]");

string[] newArray = new string [count];
int count2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= numberOfCharacters)
    {
        newArray[count2] = array[i];       
        count2++;
    }
}

Console.Write($"Результат выборки: [{s}");
Console.Write(String.Join($"{s},{s}", newArray));
Console.Write($"{s}]");