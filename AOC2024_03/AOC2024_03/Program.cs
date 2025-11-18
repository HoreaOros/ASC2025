using System.Text.RegularExpressions;

FileStream fs = File.Open("input.txt", FileMode.Open);
StreamReader sr = new StreamReader(fs);
string text = sr.ReadToEnd();
sr.Close();
fs.Close();

//mul(666,581)
Regex r = new Regex(@"mul\(\d+,\d+\)");
MatchCollection mc = r.Matches(text);
long part1 = 0;
foreach (Match m in mc)
{
    string s1 = m.Value
        .Substring(3)
        .Trim('(', ')');
    string[] token = s1.Split(',');
    long op1 = long.Parse(token[0]);
    long op2 = long.Parse(token[1]);
    part1 += op1 * op2;
}
Console.WriteLine(part1);


Regex r2 = new Regex(@"mul\(\d+,\d+\)|do\(\)|don't\(\)");
mc = r2.Matches(text);
Console.WriteLine();