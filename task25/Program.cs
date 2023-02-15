// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int powerBase = Promt("Введите основание: ");
int exponent = Promt("Введите показатель: ");
if (ValidateExponent (exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}

int Promt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i=0; i<exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}
bool ValidateExponent (int exponent)
{
    if (exponent <0)
    {
        System.Console.WriteLine("Показатель не должне быть меньше нуля");
        return false;
    }
    return true;
}