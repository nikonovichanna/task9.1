System.Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(n, 1));


int PrintNumbers(int n, int l)
{
    if (n == l) return n;
    else Console.Write($"{PrintNumbers(n, l + 1)}, ");
    return l;
}
 