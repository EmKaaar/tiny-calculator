Console.WriteLine("== Tiny Calculator ==");

int a, b;


a = ReadOperand("Erster Operand");
b = ReadOperand("Zweiter Operand");

Console.ResetColor();

Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
if (b == 0) Console.WriteLine($"{a}/{b} ist undefiniert");
else Console.WriteLine($"{a} / {b} = {(double)a / b}");

static int ReadOperand(string title)
{
    Console.Write($"{title}: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine($"Fehler, Eingabe ist keine Zahl");
        Console.Write($"{title}: ");
    }
    return a;
}