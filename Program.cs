Console.WriteLine("Введите номер одной из 4 домашних");

int Domaha = Convert.ToInt32(Console.ReadLine());
switch (Domaha) {
    case 1:
    Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b){
Console.WriteLine("первое число больше");
}
else {
    Console.WriteLine("Второе число больше");
}
break;
case 2:
Console.WriteLine("Введите первое число:");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int v = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int n = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(c, Math.Max(v, n));

Console.WriteLine("Ответ убил: " + max);
break;

case 3:
Console.WriteLine("Введите чсло для проверки на четность и не четность: ");
int chentoe;
chentoe = Console.Read();
if ((chentoe % 2) == 0 )
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Не четное");
}
break;

case 4:
Console.Write("Введите число: ");
        int p = 1;
        int m = int.Parse(Console.ReadLine());
        for (int i = p; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.WriteLine(i + ", ");
                }
        }
        break;
}