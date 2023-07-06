/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */
Console.Write("Введите массив:");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
    Random rand = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = rand.Next();
Console.Write($"{randomArray[i]:F2}");
}

}

double dif(double[] randomArray)
{
double Max = randomArray [0];
double Min = randomArray[0];
int i=1;

while (i < randomArray.Length)
{
    if(Max<randomArray[i])
    Max=randomArray[i];
    if(Min<randomArray[i])
    Min=randomArray[i];

i = i + 1;
}
return Max-Min;
}

mas(a);
Console.Write($"\n difference: {dif(randomArray):F2}");