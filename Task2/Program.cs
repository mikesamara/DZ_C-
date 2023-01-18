System.Console.Write("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b:");
int c = Convert.ToInt32(Console.ReadLine());
int max=0;
if (a>b) { 
    max = a;
    }
else { 
    max = b;
}
if (max>c){
    System.Console.Write("Максимальное число:");
    System.Console.Write(max);
}
else {
    max=c;
    System.Console.Write("Максимальное числа:");
    System.Console.Write(max);
}
