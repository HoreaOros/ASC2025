
using System.Text;

int n = 125894;

Console.WriteLine(ConvertToBase2(n));

string ConvertToBase2(int n)
{
    Stack<int> st = new Stack<int>();
    while(n  > 0)
    {
        st.Push(n % 2);
        n = n / 2;
    }

    StringBuilder sb = new StringBuilder();
    while(st.Count > 0)
    {
        sb.Append(st.Pop().ToString());
    }

    return sb.ToString();
}