void FillArray(double[]MyArray)
{
    for(int i=0; i < MyArray.Length; i++)
    {
        MyArray[i]=new Random().Next(-100,100)/10.0;
    }
}
void PrintArr(double[] MyArray)
{
    Console.WriteLine("[ {0} ]", string.Join(" | ", MyArray));
}
double SumMinAndMax(double[] MyArray)
{
    double min = MyArray[0];
    double max = MyArray[0];
    double sum = 0;
    for(int i = 0; i < MyArray.Length;i++)
    {
        if(MyArray[i]<min)
        {
            min = MyArray[i];
        }
        if(MyArray[i]>max)
        {
            max = MyArray[i];
        }
    }
    return sum=min+max;

}
//GETTINGCODE//
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if(size==1)
{
    Console.WriteLine("Ваш указали размер массива, равный одному.");
}
else
{
    double[] myArray = new double[size];
    FillArray(myArray);
    PrintArr(myArray);
    Console.WriteLine($"Сумма между максимальным и минимальным элементами в массиве равно {Math.Round(SumMinAndMax(myArray),2)}");
}
