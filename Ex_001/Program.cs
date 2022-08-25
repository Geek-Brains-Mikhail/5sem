//задать массив случайными положительными трехзначными числами.И написать прогу, которая покажет количе ство четных чисел в массиве.
void FillArray(int[]MyArray)
{
    for(int i=0; i < MyArray.Length; i++)
    {
        MyArray[i]=new Random().Next(100,1000);
    }
}
void PrintArr(int[] MyArray)
{
    Console.WriteLine("[{0}]", string.Join(", ", MyArray));
}
int QuantityEvenNumber(int[] MyArray)
{
    int count = 0;
    for(int i =0; i < MyArray.Length; i++)
    {
        if(MyArray[i] %2 ==0)
        {
            count++;
        }
    }
    return count;
}
//GETTINGCODE//
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = new int[size];
FillArray(MyArray);
PrintArr(MyArray);//оставил для наглядного примера и проверки.
Console.WriteLine($"Количество четных чисел равно {QuantityEvenNumber(MyArray)} ");
