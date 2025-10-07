using System.Text;

int n;
Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);


uint un;
un = uint.MaxValue;
Console.WriteLine(un);

n = 42;
Console.WriteLine(ConvertToBase2(n));

string ConvertToBase2(int n)
{
    Stack<int> digits = new Stack<int>();
    while (n > 0)
    {
        int r = n % 2;
        digits.Push(r);
        n /= 2; // n = n / 2;
    }

    StringBuilder sb = new StringBuilder();
    while (digits.Count > 0)
    {
        sb.Append(digits.Pop());
    }

    return sb.ToString();
}