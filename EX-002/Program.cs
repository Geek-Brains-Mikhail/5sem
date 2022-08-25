void FillArray(int[]MyArray)
{
    for(int i=0; i < MyArray.Length; i++)
    {
        MyArray[i]=new Random().Next(-100,101);
    }
}
void PrintArr(int[] MyArray)
{
    Console.WriteLine("[{0}]", string.Join(", ", MyArray));
}
int SumOddNumbers(int[] MyArray)
{
    int sum =0;
    for(int i = 1; i< MyArray.Length; i++)
    {
        sum+=MyArray[i++];
    }
    return sum;
}
//GETTINGCODE//
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];
FillArray(myArray);
PrintArr(myArray);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равно {SumOddNumbers(myArray)} ");
