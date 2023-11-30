Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b)
{
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" равно числу ");
    Console.Write(b);
}
else {
    if(a > b)
    {
        Console.Write("Число ");
        Console.Write(a);
        Console.Write(" больше, чем число ");
        Console.Write(b);
    }
    else{
        Console.Write("Число ");
        Console.Write(b);
        Console.Write(" больше, чем число ");
        Console.Write(a);
    }
}
