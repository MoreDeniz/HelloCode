void FillArray(int[] collection)//Zapolnaet massiv
{
    int length = collection.Length;
    int index = 0;
    while (index < length)  
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)//Print massiv
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //Find number
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;  //Stop after first-find
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);   //Zapolnaem massiv array
PrintArray(array);  //Pechataem massiv array
Console.WriteLine(); //Empty string

int pos = IndexOf(array, 4);
Console.WriteLine(pos);