/*  адайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


   int n, m, sum1=0, sum2=0;
            Console.WriteLine("Введите n-строк и m-столбцов!");
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
 
            int[,] k = new int[n, m];
            Random r = new Random();        //заполняем матрицу случайными числами 
 
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    k[i, j] = r.Next(-10, 10);    //каждый элемент принимает значение от -10 до +10
                    Console.Write("{0} ", k[i, j]);
                }
                Console.WriteLine();
            }
 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum1 += k[i, j];       //находим сумму всех элементов строки
                }
                Console.WriteLine();
                Console.WriteLine("Сумма " + (i+1) + " строки равна " + sum1);     //выводим сумму строки
                sum1 = 0;    //обнуляем полученную сумму
            }
            Console.WriteLine();
 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum2 += k[j, i];       //находим сумму всех элементов столбца
                }
                Console.WriteLine();
                Console.WriteLine("Сумма " + (i + 1) + "  строки  равна " + sum2);     //выводим сумму столбца
                sum2 = 0;    //обнуляем полученную сумму
            }
 
            Console.ReadKey();



 
//сумма по строке
/*for (int i=0;i<n;i++)
    for(int j=0;j<n;j++)
            s[i]+=a[i,j];*/