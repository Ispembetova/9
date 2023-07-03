Console.Clear();
int num,r,sum=0,i;
Console.Write("Введите пятизначное число:");
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
{
for(i=num;num!=0;num=num/10)
{
r=num % 10;
sum=sum*10+r;
}
if(i==sum)
Console.Write($"{i} является палиндромом.");
else
Console.Write($"{i} не является палиндромом.");
} else
Console.Write("Введите пятизначное число!");
