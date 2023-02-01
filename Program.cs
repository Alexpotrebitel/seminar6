//Напишите программу, которая перевернёт одномерный массив.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
        array[i]=new Random().Next(100,1001);
    }
    return array;
}

void ReverseArray(int[] array)
{
for (int i=0, j=array.Length -1; i<j; i++,j--)
{
    int temp=array[i];
     array[i]=array[j];
     array[j]=temp;

}
}

void ShowArray(int[] array)

{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
        Console.WriteLine();
  
}

Console.Write("Input a Length array");
int Length=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value");
int minimal=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value");
int maximal=Convert.ToInt32(Console.ReadLine());
int [] newarray=CreateRandomArray(Length,minimal, maximal);
ShowArray(newarray);
ReverseArray(newarray);
ShowArray(newarray);
*/

//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
/*bool Existtriangle(int firstside, int seconside, int thirdside)
{
   return((firstside+ seconside)>thirdside && (firstside+ thirdside)>seconside && (seconside+ thirdside)>firstside);
    
    
}
Console.WriteLine("введите первую сторону");
int firstside=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите первую сторону");
int  seconside=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите первую сторону");
int thirdside=Convert.ToInt32(Console.ReadLine());
if(Existtriangle( firstside,  seconside, thirdside))
Console.WriteLine("Может существовать");
else Console.WriteLine("Не может существовать");
*/
//не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
void fibanachi(int A, int B,double[] array)
{
   array[0]=A;
 array[1]=B;
    for(int i=2; i<array.Length; i++)
    {
        array[i]=array[i-1]+array[i-2];
    }
   
}
void ShowArray(double[] array)

{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
        Console.WriteLine();
  
}
Console.WriteLine("введите пожалуйста N");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите пожалуйста a");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите пожалуйста b");
int B=Convert.ToInt32(Console.ReadLine());
double [] array=new double[n];
fibanachi(A,B,array);
ShowArray(array);
*/
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int [] CreateRandomArray(int size)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
        array[i]=new Random().Next(-100,101);
    }
    return array;
}
void ShowArray(int[] array)

{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
        Console.WriteLine();
  }
int[] CopyArray(int[] array)
{
    int[] newArray=new int[array.Length];
    for (int i=0;i<array.Length;i++)newArray[i]=array[i];
return newArray;

}


Console.WriteLine("введите пожалуйста size");
int size=Convert.ToInt32(Console.ReadLine());

int[] newArray=CreateRandomArray(size);
ShowArray(newArray);

int[] copyArray=CopyArray(newArray);
newArray[0]=200;
ShowArray(newArray);
ShowArray(copyArray);