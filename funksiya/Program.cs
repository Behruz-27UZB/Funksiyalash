/*Console.Write("a = "); int a = int.Parse(Console.ReadLine());
Console.Write("b = "); int b = int.Parse(Console.ReadLine());
OddiyFunksiya(a, b);
static void OddiyFunksiya(int num1, int num2)
{
    for(int i = num1; i <= num2; i++)
    {
        Console.WriteLine(i + "  ");
    }
}*/
/*Console.Write("a = "); int a = int.Parse(Console.ReadLine());
Console.Write("b = "); int b = int.Parse(Console.ReadLine());
Almashtirish(a, b);
static void Almashtirish(int num1, int num2)
{
    int c = num1;
    num1 = num2;
    num2 = c;
    Console.WriteLine("num1 = " + num1 + "\nnum2 = " + c);
}*/
/*3 - misol
Console.Write("a = ");
double a = double.Parse(Console.ReadLine()); Console.Write("b = ");
double b = double.Parse(Console.ReadLine());
double s, d;
MEAN(a, b, out s, out d);
Console.WriteLine("Urta Arifmitigi = " + s + "\nUrta Geyometrigi = " + d);
void MEAN(double a, double b, out double UrtaArifmitigi, out double UrtaGeyometrigi)
{
    UrtaArifmitigi = (a + b) / 2;
    UrtaGeyometrigi = Math.Sqrt(a * b);
}*/
/*4 - misol
Console.Write("a = ");
double a = double.Parse(Console.ReadLine());
double s, d;
Triangle(a, out s, out d);
Console.WriteLine("3 Burchagning perimetri " + s + "\n3 Burchakning yuzasi = " + d);
void Triangle(double a, out double Perimitri, out double Yuzasi)
{
    Perimitri = 3 * a;
    Yuzasi = Math.Sqrt(3) / 4 * a * a;
}*/
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[] Sum1InN(int n)
{
    int v = 0
    int[] arr = new int[n];
    for (int i = 0, b = 1; i < n; i++, b++)
    {
        arr[i] = b;
    }

    return arr;
}
