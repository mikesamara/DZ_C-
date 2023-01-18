System.Console.Write("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
int max=0;
if (a>b) {
    max = a;
    System.Console.Write("Максимальное числа а:");
    System.Console.Write(max);
}
else
{
    max = b;
    System.Console.Write("Максимальное число b: ");
    System.Console.Write(max);
}
