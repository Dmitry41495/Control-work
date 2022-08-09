// Итоговая проверочная работа, текст программы

Console.WriteLine("Введите количество элементов в исходном массиве");
int sizeFirstArray = CheckinPositiveNumber();
string [] firstArray = FillArray(sizeFirstArray);
Console.WriteLine("Введите максимальную длинну элемента для нового массива");
int maxSizeElem = CheckinPositiveNumber();
string [] secondArray = GetArrayElementsByLength(firstArray, maxSizeElem);
Console.WriteLine("Исходеый массив:");
Console.WriteLine(string.Join(", ", firstArray));
Console.WriteLine("Требуемый массив:");
Console.WriteLine(string.Join(", ", secondArray));

int CheckinPositiveNumber()
{
bool check = true;
int number = 0;
while(check)
{
    while(!int.TryParse(Console.ReadLine(), out number ))
        Console.WriteLine("Неверный ввод! Введите целое чило.");
    if(number>0)
    {
        check = false;
    }
    else
    {
        Console.WriteLine("Чило должно быть положительным! Повторите ввод.");
    }
}
return number;

}

string [] FillArray(int size)
{
    string [] array = new string[size];
    for(int i = 0; i<size; i++)
    {
        Console.WriteLine("Введите элемент");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] GetArrayElementsByLength(string[] array, int lengthElem)
{
    int sizeNewArray = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=lengthElem) 
            sizeNewArray++;
    }
    string[] arrayRez = new string[sizeNewArray];
    int j =0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=lengthElem)
        {
            arrayRez[j]=array[i];
            j++;
        }
    }
    return arrayRez;    
}
